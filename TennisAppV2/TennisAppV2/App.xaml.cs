using System;
using TennisAppV2.Src.Presentation.Pages.Menu;
using TennisAppV2.Src.Presentation.Pages.Main;
using TennisAppV2.Src.Presentation.Pages.Root;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TennisAppV2.Src.Data.Database;
using TennisAppV2.Src.Data.DatabasePath;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace TennisAppV2
{
	public partial class App : Application
	{
        public static NavigationPage _Navigation;

        public App ()
		{
			InitializeComponent();

			
		}
        static SqlDatabase database;

        public static SqlDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new SqlDatabase(DependencyService.Get<IDatabasePath>().DbConnectionPath());
                }
                return database;
            }
        }

        protected override void OnStart ()
		{
            // Handle when your app starts
            var root = new RootPage();
            var menu = new MenuPage(new MenuPageViewModel());
            _Navigation = new NavigationPage(new MainPage(new MainPageViewModel())) { BarBackgroundColor = Color.FromHex("#673AB7"), BarTextColor = Color.White };

            _Navigation.Pushed += (a, s) => { root.IsPresented = false; };

            root.Master = menu;
            root.Detail = _Navigation;
            MainPage = root;
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
