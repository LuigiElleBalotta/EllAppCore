﻿using System;
using Lappa.ORM;

namespace Server.Classes.Entities
{
    public class Message : Entity
    {
        public int ID { get; set; }
        public int ChatRoom { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int Author { get; set; }
    }
}
