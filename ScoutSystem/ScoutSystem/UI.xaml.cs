using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ScoutSystem
{
    public partial class UI : ContentPage
    {
        public UI()
        {
            InitializeComponent();

            MainListView.ItemsSource = new List<U_I>
            {
                new U_I
                {
                    Scout="Scout System",

                    Coach="Coach System",
            
                    Player ="Player System",
            
                    Parents="Parents Syetem",
                },
            };
        }

        private async void ScoutButton_Onclicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }
        private async void CoachButton_Onclicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CoachSystem.MainPage());
        }
        private async void PlayerButton_Onclicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlayerSystem.PlayerHomepage());
        }
        private async void ParentsButton_Onclicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ParentsSystem.LinkPage ());
        }
    }
}
