using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TennisAppV2.Src.Common.Models;
using TennisAppV2.Src.Presentation.MvvM;
using TennisAppV2.Src.Presentation.Pages.PlayerDetail;
using Xamarin.Forms;

namespace TennisAppV2.Src.Presentation.Pages.CreatePlayer
{
    public class CreatePlayerPageViewModel : BaseViewModel
    {
        public ICommand CreatePlayer { get; set; }
        public ICommand LoadPlayer { get; set; }

        public ObservableCollection<CreatePlayerPageViewCellViewModel> _PlayerListView = new ObservableCollection<CreatePlayerPageViewCellViewModel>();
        public ObservableCollection<CreatePlayerPageViewCellViewModel> PlayerListView
        {
            get { return _PlayerListView; }
            set
            {
                Debug.WriteLine("--------------- AllPlayerListView ----------- added " + value.ToString());
                SetProperty(ref _PlayerListView, value);
            }
        }
        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { SetProperty(ref _FirstName, value); }
        }
        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (_LastName != value)
                {
                    _LastName = value;
                    Debug.WriteLine("--------------- Surname ----------- " + LastName);
                }
                SetProperty(ref _LastName, value);
            }
        }
        private string _Gender;
        public string Gender
        {
            get { return _Gender; }
            set { SetProperty(ref _Gender, value); }
        }
        private DateTime _DateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {

                SetProperty(ref _DateOfBirth, value);

            }
        }
        private string _Country;
        public string Country
        {
            get { return _Country; }
            set { SetProperty(ref _Country, value); }
        }


        public CreatePlayerPageViewModel()
        {




            CreatePlayer = new Command(async () =>
            {
                await CreatePlayerInfo();
                Debug.WriteLine("===================Player Created=====================");

            });
            LoadPlayer = new Command(async () =>
            {
                foreach (var item in await App.Database.GetAllPlayer())
                {
                    PlayerListView.Add(new CreatePlayerPageViewCellViewModel(item));
                    Debug.WriteLine("===================Player Loaded=====================");
                }
                

            });
        }
       


        public async Task CreatePlayerInfo()
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
            {
                await App._Navigation.DisplayAlert("Alert", "You have been alerted", "OK");
                return;
            }
            var NewPlayer = new Player() { FirstName = FirstName, LastName = LastName, DateOfBirth = DateOfBirth, Country = Country, Gender = Gender };

            Debug.WriteLine("--------------- CreatePlayer ----------- " + NewPlayer.FirstName + " " + NewPlayer.LastName + " " + NewPlayer.Gender + " " + NewPlayer.Country + " " + NewPlayer.DateOfBirth.ToString());

            PlayerListView.Add(new CreatePlayerPageViewCellViewModel((Player)NewPlayer));

            await App.Database.SavePlayer(NewPlayer);

        }


    }
}

