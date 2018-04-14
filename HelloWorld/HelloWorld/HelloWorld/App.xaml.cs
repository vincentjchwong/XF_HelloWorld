﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class App : Application
	{
        public static int ScreenHeight { get; set; }
        public static int ScreenWidth { get; set; }

        public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
            //SettingsPage = new NavigationPage(new Settings());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
