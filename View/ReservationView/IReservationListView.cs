using dpiotrowski_lab2.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab2.View.ReservationView
{
    internal interface IReservationListView
    {
        public event EventHandler LoadDepartmentList;
        public event EventHandler<Guid> SelectDepartment;
        public event EventHandler<DateOnly> SelectDate;
        public event EventHandler<Guid> SelectReservationToEdit;
        public event EventHandler AddReservation;

        public void UpdateDepartmentList(List<ListItem> items);
        public void UpdateReservationList(Dictionary<ListItem, List<ListItem>> items);
        public ISingleReservationView OpenSingleReservationView();
    }
}
