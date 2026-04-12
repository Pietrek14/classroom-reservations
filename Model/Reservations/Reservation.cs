using dpiotrowski_lab2.Model.Rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Reservations
{
    public class Reservation : IGuided
    {
        public Guid Id { get; }
        public Room Room { get; }
        public TimeOnly From { get; }
        public TimeOnly To { get; }
        public DateOnly Date { get; }

        public Reservation(Room room, DateOnly date, TimeOnly from, TimeOnly to)
        {
            this.Id = Guid.NewGuid();
            this.Room = room;
            this.Date = date;
            this.From = from;
            this.To = to;
        }
    }
}