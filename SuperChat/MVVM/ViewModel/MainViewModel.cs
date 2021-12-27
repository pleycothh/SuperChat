using SuperChat.Core;
using SuperChat.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChat.MVVM.ViewModel
{
    internal class MainViewModel: ObservableObject 
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }


        /* Commands */

        public ContactModel SelectedContact { get; set; }

        // check video on property changed:

        private string _message;
        public string Message { 
            get 
            { 
                return _message; 
            } 
            set 
            {
                _message = value;
                OnpropertyChanged();
            } 
        }



        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();


            Messages.Add(new MessageModel
            {
                Username = "Allison",
                UsernameColor = "#409aff",
                ImageSource = "https://i.imgur.com/yMWvLXd.png",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Allison",
                    UsernameColor = "#409aff",
                    ImageSource = "https://i.imgur.com/yMWvLXd.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Ben",
                    UsernameColor = "#409aff",
                    ImageSource = "https://i.imgur.com/i2szTsp.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true
                });

            }
            Messages.Add(new MessageModel
            {
                Username = "Ben",
                UsernameColor = "#409aff",
                ImageSource = "https://i.imgur.com/i2szTsp.png",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true
            });


            for(int i = 0; i<5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Allison {i}",
                    //   ImageSource = "https://i.imgur.com/i2szTsp.png",
                    ImageSource = "https://i.imgur.com/yMWvLXd.png",
                    Messages = Messages
                });
            }
        }
    }
}
