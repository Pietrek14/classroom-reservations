using dpiotrowski_lab2.Model.Rooms;
using dpiotrowski_lab2.Model.Rooms.Departments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace dpiotrowski_lab2.Presenter.RoomPresenter
{
    internal class RoomDataValidator
    {
        public Room GetRoom(RoomData roomData, Department department)
        {
            if (!Regex.IsMatch(roomData.RoomNumber, @"^\d+[A-Za-z]*$"))
            {
                throw new ArgumentException("Numer sali musi być liczbą, z ewentualnymi literami na końcu.");
            }

            RoomType roomType;

            switch (roomData.RoomType)
            {
                case "wykładowa":
                    roomType = RoomType.Lecture;
                    break;
                case "komputerowa":
                    roomType = RoomType.Computer;
                    break;
                case "ćwiczeniowa":
                    roomType = RoomType.Seminar;
                    break;
                default:
                    throw new ArgumentException("Nieprawidłowy typ sali. Dozwolone wartości to: wykładowa, komputerowa, ćwiczeniowa.");
            }

            return new Room(roomData.RoomNumber, roomData.Capacity, roomType, department);
        }
        public Room GetRoomWithId(Guid id, RoomData roomData, Department department)
        {
            if (!Regex.IsMatch(roomData.RoomNumber, @"^\d+[A-Za-z]*$"))
            {
                throw new ArgumentException("Numer sali musi być liczbą, z ewentualnymi literami na końcu.");
            }

            RoomType roomType;

            switch (roomData.RoomType)
            {
                case "wykładowa":
                    roomType = RoomType.Lecture;
                    break;
                case "komputerowa":
                    roomType = RoomType.Computer;
                    break;
                case "ćwiczeniowa":
                    roomType = RoomType.Seminar;
                    break;
                default:
                    throw new ArgumentException("Nieprawidłowy typ sali. Dozwolone wartości to: wykładowa, komputerowa, ćwiczeniowa.");
            }

            return new Room(id, roomData.RoomNumber, roomData.Capacity, roomType, department);
        }
    }
}
