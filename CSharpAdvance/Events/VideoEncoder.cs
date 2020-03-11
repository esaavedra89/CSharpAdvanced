using System;
using System.Threading;

namespace CSharpAdvance.Events
{
    // Hence to EventArgs to use like a EventArgs.
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    } 

    public class VideoEncoder
    {
        // 1- Define a delegate.
        // 2- Define an event based on that delegate.
        // 3- Raise the event.

        // 1-.
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args); // This is generic.
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);// This is more custom.

        // 2-.
        public event VideoEncodedEventHandler VideoEncoded;
        
        public void Encode(Video video) 
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            //OnVideoEncoded();
            OnVideoEncoded(video);
        }

        // 3-.
        protected virtual void OnVideoEncoded(Video video) 
        {
            // For combention of .Net, the method need to be protected virtual.
            if (VideoEncoded != null)
            {
                // this is the reference.
                //VideoEncoded(this, EventArgs.Empty); // Don't receive parameters.
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }
    }
}
