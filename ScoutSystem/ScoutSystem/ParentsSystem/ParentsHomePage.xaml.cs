using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ScoutSystem.ParentsSystem
{
    public partial class ParentsHomePage : ContentPage
    {
        public ParentsHomePage(string param)
        {
            InitializeComponent();
            MainLabel.Text = param;
        }

        private async void PressureButton_Onclicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PressurePage());
        }
        private async void CommentButton_Onclicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CoachSystem.MainPage());
        }
    }
}
