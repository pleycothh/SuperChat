﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChat.MVVM.Model
{
    internal class ContactModel
    {
        public string Username { get; set; }
        public string ImageSource { get; set; }

        public ObservableCollection<MessageModel> Messages { get; set; }

        public string LastMessage => Messages.Last().Message;


    }
}
