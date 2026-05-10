using ConnnectedProject.Models;
using ConnnectedProject.Views;
namespace ConnnectedProject
{
    internal static class Program
    {
        
        
        
        [STAThread]
        static void Main()
        {
            
            
            ApplicationConfiguration.Initialize();
            
            //faut absolument  charger les fausses données  ici avant de lancer la form sinon le login  il marchera  jamais
            DataStore.InitializeData();
            Application.Run(new LoginForm());
        }
    }
}