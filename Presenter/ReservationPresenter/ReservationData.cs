using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Presenter.ReservationPresenter
{
    public class ReservationData
    {
        public ListItem Department { get; set; }
        public ListItem Room { get; set; }
        public ListItem Reservee { get; set; }

        public TimeOnly From { get; set; }
        public TimeOnly To { get; set; }
        public DateOnly Date { get; set; }

        public ReservationData(ListItem department, ListItem room, ListItem reservee, TimeOnly from, TimeOnly to, DateOnly date)
        {
            this.Department = department;
            this.Room = room;
            this.Reservee = reservee;
            this.From = from;
            this.To = to;
            this.Date = date;
        }
    }
}
