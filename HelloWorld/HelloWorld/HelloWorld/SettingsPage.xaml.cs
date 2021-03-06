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
	public partial class SettingsPage : ContentPage
	{
        //Options SwitchCell definitions
        private SwitchCell NightModeSC;
        private SwitchCell CloudBackupSC;
        private SwitchCell PushNotifSC;
        private SwitchCell MealRecSC;
        private SwitchCell WorkoutRecSC;

        public SettingsPage ()
		{
			InitializeComponent ();
            
            //Get references for SwitchCells
            NightModeSC = this.FindByName<SwitchCell>("NightMode");
            CloudBackupSC = this.FindByName<SwitchCell>("CloudBackup");
            PushNotifSC = this.FindByName<SwitchCell>("PushNotif");
            MealRecSC = this.FindByName<SwitchCell>("MealRec");
            WorkoutRecSC = this.FindByName<SwitchCell>("WorkoutRec");
        }

        //Reset Preferences to default values
        private async void Reset_Clicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Are you sure?", "All your preferences will be reset", "Yes", "No");
            if (answer == true)
            {
                NightModeSC.On = false;
                CloudBackupSC.On = false;
                PushNotifSC.On = true;
                MealRecSC.On = true;
                WorkoutRecSC.On = true;
            }
        }
    }
}