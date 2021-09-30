﻿
using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Notify
    {
        [Key]
        public int NotifyId { get; set; }
        public string Message { get; set; }
        public DateTime MessageDate { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public bool MessageStatus { get; set; }

    }
}
