using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using TennisAppV2.Src.Common.Models;
using TennisAppV2.Src.Presentation.MvvM;
using TennisAppV2.Src.Presentation.Pages.CreatePlayer;
using Xamarin.Forms;

namespace TennisAppV2.Src.Presentation.Pages.PlayerDetail
{
    public class PlayerDetailsPageViewModel : BaseViewModel
    {

        public ObservableCollection<PlayerDetailsPageViewCellViewModel> _DetailPlayerListView = new ObservableCollection<PlayerDetailsPageViewCellViewModel>();
        public ObservableCollection<PlayerDetailsPageViewCellViewModel> DetailPlayerListView
        {
            get { return _DetailPlayerListView; }
            set
            {
                Debug.WriteLine("--------------- AllPlayerListView ----------- added " + value.ToString());
                SetProperty(ref _DetailPlayerListView, value);
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


       
        public PlayerDetailsPageViewModel()
        {

            LoadPlayerData();

        }
        public async void LoadPlayerData()
        {
            foreach (var item in await App.Database.GetAllPlayer())
            {

                DetailPlayerListView.Add(new PlayerDetailsPageViewCellViewModel(item));
                Debug.WriteLine("===================Player Loaded=====================");
            }


        }





    }
}
