using dpiotrowski_lab2.Model.Rooms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace dpiotrowski_lab2.Model.Reservations
{
    public class ReservationList : IObjectList<Reservation>
    {
        private Dictionary<Guid, Reservation> reservations;
        public List<Reservation> Elements { get => reservations.Values.ToList(); }
        public event EventHandler<Reservation>? ElementAdded;
        public event EventHandler<Reservation>? ElementRemoved;
        public event EventHandler<Reservation>? ElementUpdated;

        public ReservationList()
        {
            this.reservations = new Dictionary<Guid, Reservation>();
        }

        public Reservation Get(Guid elementId)
        {
            return this.reservations[elementId];
        }

        public void Add(Reservation reservation)
        {
            this.reservations.Add(reservation.Id, reservation);
            this.ElementAdded?.Invoke(this, reservation);
        }

        public void Remove(Guid reservationId)
        {
            var removed = this.reservations[reservationId];
            this.reservations.Remove(reservationId);
            this.ElementRemoved?.Invoke(this, removed);
        }

        public void Update(Reservation reservation)
        {
            if(!this.reservations.ContainsKey(reservation.Id))
            {
                throw new ArgumentException(String.Format("Reservation with id {0} does not exist", reservation.Id));
            }

            this.reservations[reservation.Id] = reservation;
            this.ElementUpdated?.Invoke(this, reservation);
        }
    }
}
