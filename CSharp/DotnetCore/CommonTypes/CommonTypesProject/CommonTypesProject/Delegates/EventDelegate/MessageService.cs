using CommonTypesProject.Delegates.EventDelegate;

namespace CommonTypesProject.Delegates.AdditionalPracticeClasses
{
    public class MessageService
    {
        public void OnVideoEncodedSubscriber(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MessageService: Sending a text message {e.video.Title}");
        }
    }
}
