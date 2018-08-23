using System;
using System.Collections.Generic;
using System.Text;
using TennisAppV2.Src.Common.Models;
using TennisAppV2.Src.Presentation.MvvM;

namespace TennisAppV2.Src.Presentation.Pages.CreatePlayer
{
    public class CreatePlayerPageViewCellViewModel : BaseViewModel
    {

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
            set { SetProperty(ref _LastName, value); }
        }
        private string _Gender;
        public string Gender
        {
            get { return _Gender; }
            set { SetProperty(ref _Gender, value); }
        }
        private string _Country;
        public string Country
        {
            get { return _Country; }
            set { SetProperty(ref _Country, value); }
        }
        private DateTime _DateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { SetProperty(ref _DateOfBirth, value); }
        }



        public Player _Player;
        public CreatePlayerPageViewCellViewModel(Player Player)
        {
            _Player = Player;
            FirstName = _Player.FirstName;
            LastName = _Player.LastName;
            Gender = _Player.Gender;
            DateOfBirth = _Player.DateOfBirth;
            Country = _Player.Country;
        }
       
    }
}
