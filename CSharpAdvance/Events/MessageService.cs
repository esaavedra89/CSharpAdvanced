﻿using System;

namespace CSharpAdvance.Events
{
    public class MessageService
    {
        //public void OnVideoEncoded(object source, EventArgs args) 
        public void OnVideoEncoded(object source, VideoEventArgs args) 
        {
            //Console.WriteLine("MessageService: Sending a text message...");
            Console.WriteLine("MessageService: Sending a text message..." + args.Video.Title);
        }
    }
}
