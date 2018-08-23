using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using TennisAppV2.Src.Presentation.MvvM;
using TennisAppV2.Src.Presentation.Pages.CreatePlayer;
using TennisAppV2.Src.Presentation.Pages.PlayerDetail;
using Xamarin.Forms;

namespace TennisAppV2.Src.Presentation.Pages.Menu
{
    public class MenuPageViewModel : BaseViewModel
    {
        public ICommand CreatePlayerPage { get; set; }
        public ICommand PlayerDetailsPage { get; set; }
        public ICommand CreateCourt { get; set; }
        public ICommand CreateCourtDetails { get; set; }
        public ICommand ArrangeMatch { get; set; }
        public ICommand Results { get; set; }

        public MenuPageViewModel()
        {
            InitCommand();
        }

        private void InitCommand()
        {
            CreatePlayerPage = new Command(async () =>
            {
                await App._Navigation.Navigation.PushAsync(new CreatePlayerPage(new CreatePlayerPageViewModel()));
                Debug.WriteLine("---Worked----");
            });
            PlayerDetailsPage = new Command(async () =>
            {
                await App._Navigation.Navigation.PushAsync(new PlayerDetailsPage(new PlayerDetailsPageViewModel()));
                Debug.WriteLine("---Worked----");
            });
            //CreateCourt = new Command(async () =>
            //{
            //    await App._Navigation.Navigation.PushAsync(new CourtPage(new CourtPageViewModel()));
            //    Debug.WriteLine("---Worked----");
            //});
            //CreateCourtDetails = new Command(async () =>
            //{
            //    await App._Navigation.Navigation.PushAsync(new CourtDetailsPage(new CourtDetailsPageViewModel()));
            //    Debug.WriteLine("---Worked----");
            //});
            //ArrangeMatch = new Command(async () =>
            //{
            //    await App._Navigation.Navigation.PushAsync(new MatchPage(new MatchPageViewModel()));
            //    Debug.WriteLine("---Worked----");
            //});
            //Results = new Command(async () =>
            //{
            //    await App._Navigation.Navigation.PushAsync(new ResultsPage(new ResultsPageViewModel()));
            //    Debug.WriteLine("---Worked----");
            //});

        }

    }
}
