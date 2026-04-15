using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Model.Employees;
using dpiotrowski_lab2.Model.Reservations;
using dpiotrowski_lab2.Model.Rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Presenter.ReservationPresenter
{
    internal class ReservationDataValidator
    {
        public Reservation GetReservation(
            ReservationData reservationData,
            IObjectList<Reservation> reservations,
            IObjectList<Room> rooms,
            IObjectList<Employee> employees)
        {
            return this.GetReservationWithId(
                Guid.NewGuid(),
                reservationData,
                reservations,
                rooms,
                employees);
        }

        public Reservation GetReservationWithId(
            Guid reservationId,
            ReservationData reservationData,
            IObjectList<Reservation> reservations,
            IObjectList<Room> rooms,
            IObjectList<Employee> employees)
        {
            Room room = rooms.Get(reservationData.Room.Value);
            Employee employee = employees.Get(reservationData.Reservee.Value);

            if(reservationData.From >= reservationData.To)
            {
                throw new ArgumentException("Rezerwacja musi się zacząć wcześniej niż skończyć");
            }

            if(reservationData.Date < DateOnly.FromDateTime(DateTime.Now))
            {
                throw new ArgumentException("Nie można zarezerwować na dzień w przeszłości");
            }

            this.verifyNoOverlap(reservationId, reservationData, reservations);

            return new Reservation(
                reservationId,
                room,
                employee,
                reservationData.Date,
                reservationData.From,
                reservationData.To
             );
        }

        private void verifyNoOverlap(
            Guid reservationId,
            ReservationData reservationData,
            IObjectList<Reservation> reservations)
        {
            var overlap = reservations.Elements
                .Where(reservation => reservation.Id != reservationId)
                .Where(reservation => reservation.Date == reservationData.Date)
                .Where(reservation => reservation.Room.Id == reservationData.Room.Value)
                .Where(reservation => reservation.From < reservationData.To && reservation.To > reservationData.From)
                .FirstOrDefault<Reservation?>();

            if (overlap != null)
            {
                throw new ArgumentException($"Sala {overlap.Room.Number} jest już zarezerwowana w tym terminie przez {overlap.Reservee}");
            }
        }
    }
}
