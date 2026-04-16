using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Presenter;
using dpiotrowski_lab2.Presenter.RoomPresenter;
using dpiotrowski_lab2.Presenter.EmployeePresenter;
using dpiotrowski_lab2.Presenter.ReservationPresenter;
using System.Diagnostics;

namespace dpiotrowski_lab2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            string storageDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            const string storageFolderName = "ReservationManager";

            var model = new ModelManager();
            var mainForm = new MainForm();

            Directory.CreateDirectory(Path.Combine(storageDirectory, storageFolderName));
            Debug.WriteLine($"Storage can be found at {Path.Combine(storageDirectory, storageFolderName)}");

            model.Persist(
                Path.Combine(storageDirectory, storageFolderName, "employees.json"),
                Path.Combine(storageDirectory, storageFolderName, "rooms.json"),
                Path.Combine(storageDirectory, storageFolderName, "reservations.json")
            );

            var employeeListPresenter = new EmployeeListPresenter(model.EmployeeList, mainForm);
            var roomListPresenter = new RoomListPresenter(model.RoomList, model.DepartmentList, mainForm);
            var reservationListPresenter = new ReservationListPresenter(
                model.ReservationList, model.RoomList, model.DepartmentList, model.EmployeeList, mainForm);

            Application.Run(mainForm);
        }
    }
}