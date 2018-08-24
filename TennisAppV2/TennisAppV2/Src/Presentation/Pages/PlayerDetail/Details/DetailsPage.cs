using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TennisAppV2.Src.Presentation.Pages.PlayerDetail.Details
{
	public class DetailsPage : ContentPage
	{
		public DetailsPage ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Xamarin.Forms!" }
				}
			};
		}
	}
}