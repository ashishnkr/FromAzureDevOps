using System;
using System.Threading;

namespace EventsAndDeleagates
{
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding {0}",video.Title);
            Thread.Sleep(3000);

            OnVideoEncoded();
            // OnVideoEncoded(this, new EventArgs e); Can create such method to pass the object and arguments if available.
            // In the above case Method signature should change, if implemented
        }

        protected virtual void OnVideoEncoded()
        {
            if(VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
