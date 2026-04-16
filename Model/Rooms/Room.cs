using dpiotrowski_lab2.Model.Rooms.Departments;
using dpiotrowski_lab2.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace dpiotrowski_lab2.Model.Rooms
{
    public class Room : IGuided
    {
        public Guid Id { get; }
        public string Number { get; }
        public uint Capacity { get; }
        public RoomType RoomType { get; }
        public Department Department { get; }

        public Room(string number, uint capacity, RoomType roomType, Department department)
        {
            this.Id = Guid.NewGuid();
            this.Number = number;
            this.Capacity = capacity;
            this.RoomType = roomType;
            this.Department = department;
        }

        [JsonConstructor]
        public Room(Guid id, string number, uint capacity, RoomType roomType, Department department)
        {
            this.Id = id;
            this.Number = number;
            this.Capacity = capacity;
            this.RoomType = roomType;
            this.Department = department;
        }

        public override string ToString()
        {
            String typeString = this.RoomType switch
            {
                RoomType.Computer => "komputerowa",
                RoomType.Seminar => "ćwiczeniowa",
                RoomType.Lecture => "wykładowa",
                _ => throw new NotImplementedException()
            };

            var pluralizerService = new PolishPluralizerService("miejsce", "miejsca", "miejsc");

            return $"{this.Number} (sala {typeString}, {this.Capacity} {pluralizerService.Pluralize((int)this.Capacity)})";
        }
    }
}
