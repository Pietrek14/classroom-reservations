using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Presenter.EmployeeList;
using dpiotrowski_lab2.Presenter.RoomList;

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

            Application.Run(mainForm);
        }
    }
}