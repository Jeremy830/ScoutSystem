using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ScoutSystem.ParentsSystem
{
    public partial class PressurePage : ContentPage
    {
        private double stress;
        
        public PressurePage()
        {
            InitializeComponent();
            Random ran = new Random();
            int RandKey = ran.Next(1, 100);
            stress = RandKey * 0.01;
            if (stress < 0.6)
            {
                ResultLabel.Text = "The pressure of your child is normal (score under 0.6)!";
            }
            else
            {
                ResultLabel.Text = "Your child is under stress! (score above 0.6)";
            }

        }
        protected override  async void OnAppearing()
        {
            base.OnAppearing();

            await MainProgressBar.ProgressTo(stress, 900, Easing.Linear);
        }
    }
}
