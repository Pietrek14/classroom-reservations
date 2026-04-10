using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Reservations
{
    internal class ReservationList : IObjectList<Reservation>
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

        public void Add(Reservation reservation)
        {
            this.reservations.Add(reservation.Id, reservation);
            this.ElementAdded?.Invoke(this, reservation);
        }

        public void Remove(Reservation reservation)
        {
            this.reservations.Remove(reservation.Id);
            this.ElementRemoved?.Invoke(this, reservation);
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
