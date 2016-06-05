using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ScoutSystem.ParentsSystem
{
    public partial class LinkPage : ContentPage
    {
        public LinkPage()
        {
            InitializeComponent();
        }

        private async void LinkButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ParentsHomePage(MainEntry.Text));
        }
    }
}
