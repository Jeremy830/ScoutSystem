using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ScoutSystem.PlayerSystem
{
    public partial class PlayerHomepage : ContentPage
    {
        private string result;
        public PlayerHomepage()
        {
            InitializeComponent();
            result = Result();
        }

        private void EMGSwitch(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            emgLabel.Text = isToggled.ToString();

        }

        private void EDGSwitch(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            edgLabel.Text = isToggled.ToString();
        }

        private void HRSwitch(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            hrLabel.Text = isToggled.ToString();
        }
        private void HRVSwitch(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            hrvLabel.Text = isToggled.ToString();
        }

        private void PFTSwitch(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            pftLabel.Text = isToggled.ToString();
        }

        public string Result()
        {
            return "System is linking to sensors...";
        }
  
            private async void StartTestButton_Onclicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestResultPage(result));
        }

    }
}
