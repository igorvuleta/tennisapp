using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TennisAppV2.Src.Presentation.Pages.PlayerDetail.Details
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsPage : ContentPage
	{
        DetailsPageViewModel _ViewModel;
		public DetailsPage (DetailsPageViewModel ViewModel)
		{
            Title = "Details";
            _ViewModel = ViewModel;
			InitializeComponent ();
            BindingContext = _ViewModel;
		}
	}
}