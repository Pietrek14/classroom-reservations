using dpiotrowski_lab2.Model.Rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Presenter.RoomPresenter
{
    public class RoomData
    {
        public string RoomNumber { get; set; }
        public  string RoomType { get; set; }
        public uint Capacity { get; set; }
        public Guid DepartmentId { get; set; }

        public RoomData(Room room)
        {
            this.RoomNumber = room.Number;
            switch(room.RoomType)
            {
                case Model.Rooms.RoomType.Lecture:
                    this.RoomType = "wykładowa";
                    break;
                case Model.Rooms.RoomType.Computer:
                    this.RoomType = "komputerowa";
                    break;
                case Model.Rooms.RoomType.Seminar:
                    this.RoomType = "ćwiczeniowa";
                    break;
                default:
                    this.RoomType = room.RoomType.ToString();
                    break;
            }
            this.Capacity = room.Capacity;
            this.DepartmentId = room.Department.Id;
        }

        public RoomData(string roomNumber, string roomType, uint capacity, Guid departmentId)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            Capacity = capacity;
            DepartmentId = departmentId;
        }
    }
}
