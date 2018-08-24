using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisAppV2.Src.Common.Models;
using TennisAppV2.Src.Presentation.Pages.PlayerDetail.Details;
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
        public async void ListItemClicked(object sender, ItemTappedEventArgs e)
        {
            Debug.WriteLine(((PlayerDetailsPageViewCellViewModel)e.Item).FirstName);
            Player P = ((PlayerDetailsPageViewCellViewModel)e.Item)._Player;
            await App._Navigation.Navigation.PushAsync(new DetailsPage(new DetailsPageViewModel(P)));
        }
    }
}