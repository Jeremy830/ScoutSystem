using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;

namespace ScoutSystem.ViewModel
{
        public class CoachCommentViewModel : INotifyPropertyChanged
        {
            public static string jade;

            public event PropertyChangedEventHandler PropertyChanged;

         

            public string Jade
            {
                set
                {
                    if (jade != value)
                    {
                        jade = value;
                        OnPropertyChanged("Jade");
                    }


                }
                get
                {
                    return jade;
                }
            }

            protected virtual void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this,
                        new PropertyChangedEventArgs(propertyName));
                }
            }
        }
}

