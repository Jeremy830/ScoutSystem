using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ScoutSystem.ViewModel;

namespace ScoutSystem
{
    public partial class ContactPage : ContentPage
    {
        public ContactPage() : this(string.Empty)
        {
           
        }

        public ContactPage(string param)
        {
            InitializeComponent();
            BindingContext = new ContactViewModel(param);

        }
    }
}
