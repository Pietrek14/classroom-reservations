using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Rooms
{
    internal class RoomList
    {
        private Dictionary<Guid, Room> rooms;
        public List<Room> Rooms { get => rooms.Values.ToList(); }

        public event EventHandler<Room>? RoomAdded;
        public event EventHandler<Room>? RoomRemoved;
        public event EventHandler<Room>? RoomUpdated;

        public RoomList()
        {
            this.rooms = new Dictionary<Guid, Room>();
        }

        public void Add(Room room)
        {
            this.rooms.Add(room.Id, room);
            
            this.RoomAdded?.Invoke(this, room);
        }

        public void Remove(Room room)
        {
            this.rooms.Remove(room.Id);

            this.RoomRemoved?.Invoke(this, room);
        }

        public void Update(Room room) {
            if (!this.rooms.ContainsKey(room.Id))
            {
                throw new ArgumentException($"Room with id {room.Id} does not exist.");
            }

            this.rooms[room.Id] = room;

            this.RoomUpdated?.Invoke(this, room);
        }
    }
}
