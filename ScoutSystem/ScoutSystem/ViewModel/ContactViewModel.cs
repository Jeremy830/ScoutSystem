using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoutSystem.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace ScoutSystem.ViewModel
{
    public class ContactViewModel:INotifyPropertyChanged
    {
        private ContactModel _contactModel;
        private string _message;

        public ContactModel ContactModel
        {
           get { return _contactModel; }
           set
            {
                _contactModel = value;
                OnPropertyChanged();
            }
        }

        public ContactViewModel(string param) 
        {
            ContactModel = new ContactModel
            {
                ContactName = param,
                Introduction = " "
            };
        }
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();

            }
        }
        public Command SaveCommand
        {
            get
            {
                return new Command(() =>
                {
                    Message = "Your Greet to" + ContactModel.ContactName + "'s coach: " + ContactModel.Introduction +"--->  was successfully sended!";
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
