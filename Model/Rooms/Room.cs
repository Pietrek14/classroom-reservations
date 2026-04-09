using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Rooms
{
    internal class Room
    {
        public Guid Id { get; }
        public uint Number { get; set; }
        public uint Capacity { get; set; }
        public RoomType RoomType { get; set; }

        public Room(uint number, uint capacity, RoomType roomType) {
            this.Id = Guid.NewGuid();
            this.Number = number;
            this.Capacity = capacity;
            this.RoomType = roomType;
        }
    }
}
