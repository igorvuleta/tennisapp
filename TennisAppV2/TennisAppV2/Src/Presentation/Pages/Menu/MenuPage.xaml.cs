using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TennisAppV2.Src.Presentation.Pages.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
        MenuPageViewModel _ViewModel;
		public MenuPage (MenuPageViewModel ViewModel)
		{
            Title = "Page";
            _ViewModel = ViewModel;
			InitializeComponent ();
            BindingContext = ViewModel;
		}
	}
}