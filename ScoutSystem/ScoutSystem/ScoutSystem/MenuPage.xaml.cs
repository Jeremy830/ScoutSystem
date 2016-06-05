using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ScoutSystem
{
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        public async void DiscoverClicked(object sender, EventArgs e)
        {
            Detail = new HomePage();
            await Navigation.PushAsync(new DiscoverPage());
        }

        public async void HistoryClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage(null));
        }
        public async void ContactClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactPage());
        }
    }
}
