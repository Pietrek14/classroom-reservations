using dpiotrowski_lab2.Model.Employees;
using dpiotrowski_lab2.Model.Reservations;
using dpiotrowski_lab2.Model.Rooms;
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
        public IObjectList<Room> RoomList { get; set;  }
        public IObjectList<Reservation> ReservationList { get; set; }

        public ModelManager()
        {
            EmployeeList = new EmployeeList();
            RoomList = new RoomList();
            ReservationList = new ReservationList();
        }
    }
}
