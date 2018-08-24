﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TennisAppV2.Src.Presentation.Pages.CreateCourt
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateCourtPage : ContentPage
	{
        CreateCourtViewModel _ViewModel;
		public CreateCourtPage (CreateCourtViewModel ViewModel)
		{
            Title = "Create Court";
            _ViewModel = ViewModel;
			InitializeComponent ();
            BindingContext = ViewModel;
		}
	}
}