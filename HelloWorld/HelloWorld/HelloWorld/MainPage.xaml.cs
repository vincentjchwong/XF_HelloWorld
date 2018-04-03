using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace HelloWorld
{
	public partial class MainPage : ContentPage
	{
        //public Button Nav1;

		public MainPage()
		{
			InitializeComponent();
            //Nav1 = this.FindByName<Button>("Nav1BButton");
            //Nav1.Margin = new Thickness(0);
        }

        //Move to SettingsPage
        private void Settings_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage());
        }

        //Move to MealPage
        private void Meal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MealPage());
        }
    }
}
