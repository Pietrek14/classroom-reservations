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

            var mathematicsDepartment = new Department(
                "Wydział Matematyki Stosowanej",
                new Address("Gliwice", new PostalCode("44", "100"), "Kaszubska", "23"));

            DepartmentList.Add(mathematicsDepartment);
            DepartmentList.Add(new Department(
                "Wydział Automatyki, Elektroniki i Informatyki",
                new Address("Gliwice", new PostalCode("44", "100"), "Akademicka", "16"))
            );
            DepartmentList.Add(new Department(
                "Wydział Transportu i Inżynierii Lotniczej",
                new Address("Katowice", new PostalCode("40", "019"), "Zygmunta Krasińskiego", "8"))
            );

            var room403 = new Room("403", 120, RoomType.Lecture, mathematicsDepartment);

            RoomList.Add(room403);
            RoomList.Add(new Room("406", 45, RoomType.Seminar, mathematicsDepartment));
            RoomList.Add(new Room("306", 30, RoomType.Computer, mathematicsDepartment));

            var adamZielonka = new Employee("Adam", "Zielonka", new Title("dr hab.", "prof. PŚ"));
            var dawidPiotrowski = new Employee("Dawid", "Piotrowski", new Title("tech.", ""));
            var beniaminStecula = new Employee("Beniamin", "Stecuła", new Title("mgr² inż.", ""));

            EmployeeList.Add(adamZielonka);
            EmployeeList.Add(dawidPiotrowski);
            EmployeeList.Add(beniaminStecula);

            var reservation1 = new Reservation(
                room403,
                adamZielonka,
                DateOnly.FromDateTime(DateTime.Today),
                new TimeOnly(8, 30),
                new TimeOnly(10, 00)
            );

            var reservation2 = new Reservation(
                room403,
                dawidPiotrowski,
                DateOnly.FromDateTime(DateTime.Today),
                new TimeOnly(12, 00),
                new TimeOnly(13, 30)
            );

            var reservation3 = new Reservation(
                room403,
                beniaminStecula,
                DateOnly.FromDateTime(DateTime.Today),
                new TimeOnly(13, 45),
                new TimeOnly(15, 15)
            );

            var reservation4 = new Reservation(
                room403,
                adamZielonka,
                DateOnly.FromDateTime(DateTime.Today.AddDays(1)),
                new TimeOnly(10, 15),
                new TimeOnly(11, 45)
            );

            ReservationList.Add(reservation1);
            ReservationList.Add(reservation3);
            ReservationList.Add(reservation2);
            ReservationList.Add(reservation4);
        }
    }
}
