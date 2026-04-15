using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Presenter;
using dpiotrowski_lab2.Presenter.RoomPresenter;
using dpiotrowski_lab2.Presenter.EmployeePresenter;
using dpiotrowski_lab2.Presenter.ReservationPresenter;

namespace dpiotrowski_lab2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var model = new ModelManager();
            var mainForm = new MainForm();

            var employeeListPresenter = new EmployeeListPresenter(model.EmployeeList, mainForm);
            var roomListPresenter = new RoomListPresenter(model.RoomList, model.DepartmentList, mainForm);
            var reservationListPresenter = new ReservationListPresenter(
                model.ReservationList, model.RoomList, model.DepartmentList, model.EmployeeList, mainForm);

            Application.Run(mainForm);
        }
    }
}