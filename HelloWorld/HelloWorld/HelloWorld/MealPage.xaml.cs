﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MealPage : ContentPage
	{
		public MealPage ()
		{
			InitializeComponent ();
		}

        //Move to SettingsPage
        private void AddMeal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddMealPage());
        }
    }
}