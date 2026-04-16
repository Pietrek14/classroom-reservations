using dpiotrowski_lab2.Model.Employees;
using dpiotrowski_lab2.Model.Reservations;
using dpiotrowski_lab2.Model.Rooms;
using dpiotrowski_lab2.Model.Rooms.Addresses;
using dpiotrowski_lab2.Model.Rooms.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab2.Model
{
    public class ModelManager
    {
        public EmployeeList EmployeeList { get; set; }
        public RoomList RoomList { get; set; }
        public ReservationList ReservationList { get; set; }
        public DepartmentList DepartmentList { get; set; }

        public ModelManager()
        {
            EmployeeList = new EmployeeList();
            RoomList = new RoomList();
            ReservationList = new ReservationList();
            DepartmentList = new DepartmentList();

            // We have to hard-code the deparments' IDs so they can persist
            var mathematicsDepartment = new Department(
                new Guid("00000000-0000-0000-0000-000000000000"),
                "Wydział Matematyki Stosowanej",
                new Address("Gliwice", new PostalCode("44", "100"), "Kaszubska", "23"));

            DepartmentList.Add(mathematicsDepartment);
            DepartmentList.Add(new Department(
                new Guid("00000000-0000-0000-0000-000000000001"),
                "Wydział Automatyki, Elektroniki i Informatyki",
                new Address("Gliwice", new PostalCode("44", "100"), "Akademicka", "16"))
            );
            DepartmentList.Add(new Department(
                new Guid("00000000-0000-0000-0000-000000000002"),
                "Wydział Transportu i Inżynierii Lotniczej",
                new Address("Katowice", new PostalCode("40", "019"), "Zygmunta Krasińskiego", "8"))
            );
        }

        public void Persist(string employeeListFilePath, string roomListFilePath, string reservationListFilePath)
        {
            var employeeListSerializer = new ObjectListSerializer<EmployeeList, Employee>(employeeListFilePath);
            var roomListSerializer = new ObjectListSerializer<RoomList, Room>(roomListFilePath);
            var reservationListSerializer = new ObjectListSerializer<ReservationList, Reservation>(reservationListFilePath);

            var deserializedEmployeeList = employeeListSerializer.Deserialize();
            var deserializedRoomList = roomListSerializer.Deserialize();
            var deserializedReservationList = reservationListSerializer.Deserialize();

            this.EmployeeList = deserializedEmployeeList ?? new EmployeeList();
            this.RoomList = deserializedRoomList ?? new RoomList();
            this.ReservationList = deserializedReservationList ?? new ReservationList();

            this.EmployeeList.ElementAdded += (sender, employee) => employeeListSerializer.Serialize(this.EmployeeList);
            this.EmployeeList.ElementUpdated += (sender, employee) => employeeListSerializer.Serialize(this.EmployeeList);
            this.EmployeeList.ElementRemoved += (sender, employee) => employeeListSerializer.Serialize(this.EmployeeList);

            this.RoomList.ElementAdded += (sender, room) => roomListSerializer.Serialize(this.RoomList);
            this.RoomList.ElementUpdated += (sender, room) => roomListSerializer.Serialize(this.RoomList);
            this.RoomList.ElementRemoved += (sender, room) => roomListSerializer.Serialize(this.RoomList);
            this.DepartmentList.ElementAdded += (sender, department) => roomListSerializer.Serialize(this.RoomList);
            this.DepartmentList.ElementUpdated += (sender, department) => roomListSerializer.Serialize(this.RoomList);
            this.DepartmentList.ElementRemoved += (sender, department) => roomListSerializer.Serialize(this.RoomList);

            this.ReservationList.ElementAdded += (sender, reservation) => reservationListSerializer.Serialize(this.ReservationList);
            this.ReservationList.ElementUpdated += (sender, reservation) => reservationListSerializer.Serialize(this.ReservationList);
            this.ReservationList.ElementRemoved += (sender, reservation) => reservationListSerializer.Serialize(this.ReservationList);
            this.EmployeeList.ElementAdded += (sender, reservation) => reservationListSerializer.Serialize(this.ReservationList);
            this.EmployeeList.ElementUpdated += (sender, reservation) => reservationListSerializer.Serialize(this.ReservationList);
            this.EmployeeList.ElementRemoved += (sender, reservation) => reservationListSerializer.Serialize(this.ReservationList);
            this.RoomList.ElementAdded += (sender, reservation) => reservationListSerializer.Serialize(this.ReservationList);
            this.RoomList.ElementUpdated += (sender, reservation) => reservationListSerializer.Serialize(this.ReservationList);
            this.RoomList.ElementRemoved += (sender, reservation) => reservationListSerializer.Serialize(this.ReservationList);
            this.DepartmentList.ElementAdded += (sender, reservation) => reservationListSerializer.Serialize(this.ReservationList);
            this.DepartmentList.ElementUpdated += (sender, reservation) => reservationListSerializer.Serialize(this.ReservationList);
            this.DepartmentList.ElementRemoved += (sender, reservation) => reservationListSerializer.Serialize(this.ReservationList);
        }
    }
}
