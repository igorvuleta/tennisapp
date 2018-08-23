using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TennisAppV2.Src.Presentation.Pages.PlayerDetail
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlayerDetailsPage : ContentPage
	{
        PlayerDetailsPageViewModel _ViewModel;
		public PlayerDetailsPage (PlayerDetailsPageViewModel ViewModel)
		{
            Title = "Player Details";
            _ViewModel = ViewModel;
			InitializeComponent ();
            BindingContext = _ViewModel;
            
		}
	}
}