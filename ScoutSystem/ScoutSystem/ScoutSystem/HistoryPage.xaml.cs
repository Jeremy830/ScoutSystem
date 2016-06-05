using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ScoutSystem.ViewModel;

namespace ScoutSystem
{
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage() : this(string.Empty)
        {

        }

        public HistoryPage(string param)
        {
            InitializeComponent();
            BindingContext = new HistoryViewModel(param);

        }
    }
}
