using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Reservations
{
    internal class ReservationList
    {
        private Dictionary<Guid, Reservation> reservations;
        public List<Reservation> Reservations { get => reservations.Values.ToList(); }
        public event EventHandler<Reservation>? ReservationAdded;
        public event EventHandler<Reservation>? ReservationRemoved;
        public event EventHandler<Reservation>? ReservationUpdated;

        public ReservationList()
        {
            this.reservations = new Dictionary<Guid, Reservation>();
        }

        public void Add(Reservation reservation)
        {
            this.reservations.Add(reservation.Id, reservation);
            this.ReservationAdded?.Invoke(this, reservation);
        }

        public void Remove(Reservation reservation)
        {
            this.reservations.Remove(reservation.Id);
            this.ReservationRemoved?.Invoke(this, reservation);
        }

        public void Update(Reservation reservation)
        {
            if(!this.reservations.ContainsKey(reservation.Id))
            {
                throw new ArgumentException(String.Format("Reservation with id {0} does not exist", reservation.Id));
            }

            this.reservations[reservation.Id] = reservation;
            this.ReservationUpdated?.Invoke(this, reservation);
        }
    }
}
