using System;

namespace EventsAndDeleagates
{
    class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video("Movie.mp4");
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);

            Console.ReadKey();
        }
    }
}
