using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TennisAppV2.Src.Common.Models;
using TennisAppV2.Src.Presentation.MvvM;
using TennisAppV2.Src.Presentation.Pages.CreatePlayer;
using Xamarin.Forms;

namespace TennisAppV2.Src.Presentation.Pages.CreateCourt
{
    public class CreateCourtViewModel : BaseViewModel
    {
        public ICommand CreateCourt { get; set; }
        public ICommand LoadCourt { get; set; }

        public ObservableCollection<CreateCourtPageViewCellViewModel> _CourtListView = new ObservableCollection<CreateCourtPageViewCellViewModel>();
        public ObservableCollection<CreateCourtPageViewCellViewModel> CourtListView
        {
            get { return _CourtListView; }
            set
            {
                Debug.WriteLine("--------------- CourtListView ----------- added " + value.ToString());
                SetProperty(ref _CourtListView, value);
            }
        }
        private string _CourtName;
        public string CourtName
        {
            get { return _CourtName; }
            set { SetProperty(ref _CourtName, value); }
        }
        private string _CourtAdress;
        public string CourtAdress
        {
            get { return _CourtAdress; }
            set { SetProperty(ref _CourtAdress, value); }
        }
        private string _CourtCountry;
        public string CourtCountry
        {
            get { return _CourtCountry; }
            set { SetProperty(ref _CourtCountry, value); }
        }
        private DateTime _DateEstablished;
        public DateTime DateEstablished
        {
            get { return _DateEstablished; }
            set { SetProperty(ref _DateEstablished, value); }
        }
        private string _CourtType;
        public string CourtType
        {
            get { return _CourtType; }
            set { SetProperty(ref _CourtType, value); }
        }








        public CreateCourtViewModel()
        {
            CreateCourt = new Command(async () =>
            {
                await CreateCourtInfo();
                Debug.WriteLine("===================Court Created=====================");

            });
            LoadCourt = new Command(async () =>
            {
                foreach (var item in await App.Database.GetAllPlayer())
                {
                    CourtListView.Add(new CreateCourtPageViewCellViewModel(item));
                    Debug.WriteLine("===================Player Loaded=====================");
                }


            });
        }
        public async Task CreateCourtInfo()
        {
            if (string.IsNullOrEmpty(CourtName) || string.IsNullOrEmpty(CourtAdress))
            {
                await App._Navigation.DisplayAlert("Alert", "You have been alerted", "OK");
                return;
            }
            var NewCourt = new Court() { CourtName = CourtName, CourtAdress = CourtAdress, DateEstablished = DateEstablished.ToString(), CourtCountry = CourtCountry, CourtType = CourtType };

            Debug.WriteLine("--------------- CreatePlayer ----------- " + NewCourt.CourtName + " " + NewCourt.CourtAdress + " " + NewCourt.DateEstablished + " " + NewCourt.CourtCountry);

            CourtListView.Add(new CreatePlayerPageViewCellViewModel((Court)NewCourt));

            await App.Database.SavePlayer(NewCourt);

        }
    }
}
