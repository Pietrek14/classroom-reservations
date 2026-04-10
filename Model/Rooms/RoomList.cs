using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Rooms
{
    internal class RoomList : IObjectList<Room>
    {
        private Dictionary<Guid, Room> rooms;
        public List<Room> Elements { get => rooms.Values.ToList(); }

        public event EventHandler<Room>? ElementAdded;
        public event EventHandler<Room>? ElementRemoved;
        public event EventHandler<Room>? ElementUpdated;

        public RoomList()
        {
            this.rooms = new Dictionary<Guid, Room>();
        }

        public void Add(Room room)
        {
            this.rooms.Add(room.Id, room);
            
            this.ElementAdded?.Invoke(this, room);
        }

        public void Remove(Room room)
        {
            this.rooms.Remove(room.Id);

            this.ElementRemoved?.Invoke(this, room);
        }

        public void Update(Room room) {
            if (!this.rooms.ContainsKey(room.Id))
            {
                throw new ArgumentException($"Room with id {room.Id} does not exist.");
            }

            this.rooms[room.Id] = room;

            this.ElementUpdated?.Invoke(this, room);
        }
    }
}
