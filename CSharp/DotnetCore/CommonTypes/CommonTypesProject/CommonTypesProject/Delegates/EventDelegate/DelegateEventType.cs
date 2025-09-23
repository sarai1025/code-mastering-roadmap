using CommonTypesProject.Delegates.AdditionalPracticeClasses;

namespace CommonTypesProject.Delegates.EventDelegate
{
    public class DelegateEventType
    {
        //This two lines...
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs video);
        //public event VideoEncodedEventHandler VideoEncoded;

        //Is the same as:
        public EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");

            Thread.Sleep(1000);
            OnVideoEncodedPublisher(video);
        }

        public void OnVideoEncodedPublisher(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { video = video });
        }

    }

    public class  VideoEventArgs: EventArgs
    {
        public Video video { get; set; }
    }
}
