using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ScoutSystem
{
    public partial class PlayerDetial : ContentPage
    {
        private string param;

        public PlayerDetial(string parameter)
        {
            param = parameter;
            InitializeComponent();
            MainListView.ItemsSource = new List<Person>
            {
                new Person
                {
                    Name =parameter
                },
            };

        }
        private async void ContactButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactPage(param));
        }
        private async void HistoryButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage(param));
        }
    }
}
