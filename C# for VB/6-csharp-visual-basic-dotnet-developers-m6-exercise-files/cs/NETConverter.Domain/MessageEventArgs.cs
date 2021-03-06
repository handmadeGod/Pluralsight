﻿using System;

namespace NETConverter.Domain
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; set; }

        public MessageEventArgs(string message)
        {
            this.Message = message;
        }
    }
}
