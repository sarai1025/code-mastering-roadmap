using CommonTypesProject.Delegates.EventDelegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypesProject.Delegates.AdditionalPracticeClasses
{
    public class MailService
    {
        public void OnVideoEncodedSubscriber(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Sending an email {e.video.Title}");
        }
    }
}
