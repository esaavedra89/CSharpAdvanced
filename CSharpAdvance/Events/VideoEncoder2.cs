using System;
using System.Threading;

namespace CSharpAdvance.Events
{
    public class VideoEncoder2
    {
        // This way, we can achive the same thing that VideoEncoder but 
        // just using the default EventHandler of .Net.
        public event EventHandler<VideoEventArgs> VideoEncoded;

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
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
