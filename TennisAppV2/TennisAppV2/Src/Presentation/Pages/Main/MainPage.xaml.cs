using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TennisAppV2.Src.Presentation.Pages.Main
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        MainPageViewModel _ViewModel;
		public MainPage (MainPageViewModel ViewModel)
		{
            Title = "Main Page";
            _ViewModel = ViewModel;
			InitializeComponent ();
            BindingContext = ViewModel;
		}
	}
}