using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1- Define a delegate (the delgate determines the signature of the method in the subscriber
        //    that will be called when the publisher publishes an event.  
        // 2- Define an event based on that delegate
        // 3- Raise (publish) the event

        // delegate holds a reference to a method that looks like this (below)
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // This is the definition of the event
        //public event VideoEncodedEventHandler VideoEncoded;

        // .net introduced a better way to implement this with built in stuff

        public event EventHandler<VideoEventArgs> VideoEncoded;     // with this we don't need to define a delegate explicitly
        // public event EventHandler VideoEncoded;                  // We would do this if we didn't need to pass an special args

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);   // This raises the event
        }

        // Naming convention here is "On" + name of event (above) e.g. "OnVideoEncoded"
        protected virtual void OnVideoEncoded(Video video) //convention states we use protected virtual void
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}
