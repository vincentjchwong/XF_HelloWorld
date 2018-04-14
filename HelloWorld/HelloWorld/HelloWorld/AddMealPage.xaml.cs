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
	public partial class AddMealPage : ContentPage
	{
        private readonly List<string> MealItemsList = new List<string>
        {
            "Chicken", "Eggs", "Bread", "Rice", "Broccoli", "Beef", "Spaghetti"
        };

        private readonly List<string> AddedMealList = new List<string>
        {
            "Big Mac", "Banana", "Coffee"
        };

        public AddMealPage ()   
		{
			InitializeComponent ();
            this.FindByName<ListView>("MealListView").ItemsSource = AddedMealList;
        }

        private void Update_SearchBar(object sender, TextChangedEventArgs e)
        {
            var searchWord = this.FindByName<SearchBar>("MealSearchBar").Text;

            if (searchWord.Length == 0)
            {
                this.FindByName<ListView>("MealListView").ItemsSource = AddedMealList;
            } else
            {
                this.FindByName<ListView>("MealListView").ItemsSource = MealItemsList.Where(name => name.ToLower().Contains(searchWord.ToLower()));
            }
        }
	}
}