using dpiotrowski_lab2.Model.Employees;
using dpiotrowski_lab2.Model.Rooms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace dpiotrowski_lab2.Model.Reservations
{
    public class Reservation : IGuided
    {
        public Guid Id { get; }
        public Room Room { get; }
        public Employee Reservee { get; }
        public TimeOnly From { get; }
        public TimeOnly To { get; }
        public DateOnly Date { get; }

        public Reservation(Room room, Employee reservee, DateOnly date, TimeOnly from, TimeOnly to)
        {
            this.Id = Guid.NewGuid();
            this.Room = room;
            this.Reservee = reservee;
            this.Date = date;
            this.From = from;
            this.To = to;
        }

        [JsonConstructor]
        public Reservation(Guid id, Room room, Employee reservee, DateOnly date, TimeOnly from, TimeOnly to)
        {
            this.Id = id;
            this.Room = room;
            this.Reservee = reservee;
            this.Date = date;
            this.From = from;
            this.To = to;
        }
    }
}