using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;

namespace ScoutSystem
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            MainListView.ItemsSource = new List<Person>
            {
               new Person
                {
                    Name="Player: Jack",
                    Age= "Age: 16",
                    Position="Position: Centre Forward",
                    Ability="Comprehensive abilities: 5/7"
                },
                new Person
                {
                    Name="Player: Frank",
                    Age="Age: 15",
                    Position="Position: GoalKeeper",
                    Ability="Comprehensive abilities: 4.5/7"

                },
                new Person
                {
                    Name="Player: Ollie",
                    Age="Age: 15",
                    Position="Position: Centre Halfback",
                    Ability="Comprehensive abilities: 5.5/7"
                },
                new Person
                {
                    Name="Player: Jeremy",
                    Age="Age: 14",
                    Position="Position: Right Winger",
                    Ability="Comprehensive abilities: 6/7"
                },
                new Person
                {
                    Name="Player: David",
                    Age="Age: 16",
                    Position="Left Fullback",
                    Ability="Comprehensive abilities: 4/7"
                },
                new Person
                {
                    Name="Player: Tom",
                    Age="Age: 13",
                    Position="Position: Left Inside FW",
                    Ability="Comprehensive abilities: 5/7"
                },
            };
        }

        private async void PlayerNameButton_Onclicked(object sender, EventArgs e)
        {
            Button tempBTN = (Button)sender;
            await Navigation.PushAsync(new PlayerDetial(tempBTN.Text));
        }
         private async void Save_OnClicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {
               string choice=await DisplayActionSheet("Do you wish to save?","Cancel", "OK");
                if (choice == "OK")
                {
                }
            }
        }

        private async void Delete_OnClicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {
               string choice=await DisplayActionSheet("Do you wish to delete?", "Cancel","OK");
                if(choice == "OK")
                {
                    MainListView.ItemsSource = null;
                }
            }
        }

        private async void SearchButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DiscoverPage());
        }
    }
}
