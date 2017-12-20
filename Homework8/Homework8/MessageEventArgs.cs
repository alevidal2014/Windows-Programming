using System;

namespace Homework8
{
    public abstract class BaseMessageEventArgs : EventArgs
    {
        
    }


    public class CustomMessageEventArgs : BaseMessageEventArgs
    {
        public Document Document { get; set; }
    }

    public class MessageEventArgs : BaseMessageEventArgs
    {
        public string Text { get; set; }
    }
}