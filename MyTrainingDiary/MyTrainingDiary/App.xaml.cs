using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyTrainingDiary.Views;
using MyTrainingDiary.DAL;
using MyTrainingDiary.DAL.Entities;
using System;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyTrainingDiary
{
    public partial class App : Application
    {
        private static string _dbPath;

        public static MtdAppDbContext GetAppDbContext()
        {
            return new MtdAppDbContext(_dbPath);
        }

        public App() // kvuli designeru, aby se zobrazovalo co pisu v xamlu
        {
            InitializeComponent();
        }

        public App(string dbPath)
        {
            InitializeComponent();

            _dbPath = dbPath;

            //using (var dc = App.GetAppDbContext()) // pri kazdem startu appky se smaze db. Zatim, pro ucely testovani app.
            //{
            //    dc.Database.EnsureDeleted();
            //    // DELETE Provest po zmene database seedu (tela OnModelCreating metody v contextu/konfiguraci entit),
            //    // jinak se zmeny v datech neprojevi.
            //}

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
