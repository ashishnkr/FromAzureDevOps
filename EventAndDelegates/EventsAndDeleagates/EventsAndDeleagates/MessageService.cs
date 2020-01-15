using System;

namespace EventsAndDeleagates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MessageService: Sending a message");
        }
    }
}