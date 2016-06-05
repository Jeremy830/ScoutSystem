using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ScoutSystem.CoachSystem
{
    public partial class Comment : ContentPage
    {
        public Comment()
        {
            InitializeComponent();
        }

        void OnCallHistory(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}
