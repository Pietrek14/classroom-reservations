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
        public IObjectList<Employee> EmployeeList { get; set; }
        public IObjectList<Room> RoomList { get; set; }
        public IObjectList<Reservation> ReservationList { get; set; }
        public IObjectList<Department> DepartmentList { get; set; }

        public ModelManager()
        {
            EmployeeList = new EmployeeList();
            RoomList = new RoomList();
            ReservationList = new ReservationList();
            DepartmentList = new DepartmentList();

            DepartmentList.Add(new Department(
                "Wydział Matematyki Stosowanej",
                new Address("Gliwice", new PostalCode("44", "100"), "Kaszubska", "23"))
            );
            DepartmentList.Add(new Department(
                "Wydział Automatyki, Elektroniki i Informatyki",
                new Address("Gliwice", new PostalCode("44", "100"), "Akademicka", "16"))
            );
            DepartmentList.Add(new Department(
                "Wydział Transportu i Inżynierii Lotniczej",
                new Address("Katowice", new PostalCode("40", "019"), "Zygmunta Krasińskiego", "8"))
            );
        }
    }
}
