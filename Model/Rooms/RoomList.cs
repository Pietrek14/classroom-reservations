using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace dpiotrowski_lab2.Model.Rooms
{
    public class RoomList : IObjectList<Room>
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

        public Room Get(Guid elementId)
        {
            return this.rooms[elementId];
        }

        public void Add(Room room)
        {
            this.rooms.Add(room.Id, room);
            
            this.ElementAdded?.Invoke(this, room);
        }

        public void Remove(Guid roomId)
        {
            var removed = this.rooms[roomId];

            this.rooms.Remove(roomId);

            this.ElementRemoved?.Invoke(this, removed);
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
