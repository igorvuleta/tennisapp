using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TennisAppV2.Src.Presentation.Pages.CreatePlayer
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreatePlayerPage : ContentPage
	{
        CreatePlayerPageViewModel _ViewModel;
		public CreatePlayerPage (CreatePlayerPageViewModel ViewModel)
		{
            Title = "Create Player";
            _ViewModel = ViewModel;
			InitializeComponent ();
            BindingContext = _ViewModel;
		}
	}
}