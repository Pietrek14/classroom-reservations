using dpiotrowski_lab2.Model;

namespace dpiotrowski_lab2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ModelManager model = new ModelManager();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(model));
        }
    }
}