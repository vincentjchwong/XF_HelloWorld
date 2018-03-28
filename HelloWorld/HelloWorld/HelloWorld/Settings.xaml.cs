using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Settings : ContentPage
	{

        public Boolean NightModeButton;

        public Settings()
        {
            InitializeComponent();
            NightModeButton = this.FindByName<SwitchCell>("NightMode").IsEnabled;
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            if (NightModeButton == true)
            {
                this.FindByName<SwitchCell>("NightMode").On = false;
            }
        }
    }
}