using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ScoutSystem.CoachSystem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       void OnCallHistory(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Comment());
        }

        void GoingBack(object sender, EventArgs e)
        {

        }

    }
}
