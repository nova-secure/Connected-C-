using ConnnectedProject.Models;
using ConnnectedProject.Views;
namespace ConnnectedProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //jai retrai le 'new' vu  qe la classe ai  maintenant stitique
            DataStore.InitialiserDonnees();
            Application.Run(new LoginForm());
        }
    }
}