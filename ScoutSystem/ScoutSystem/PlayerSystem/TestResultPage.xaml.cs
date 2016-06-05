using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ScoutSystem.PlayerSystem
{
    public partial class TestResultPage : ContentPage
    {
        public TestResultPage(string param)
        {
            InitializeComponent();
            MainLabel.Text = param;
        }
    }
}
