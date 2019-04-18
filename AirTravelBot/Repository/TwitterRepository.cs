using AirTravelBot.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TweetSharp;

namespace AirTravelBot.Repository
{
    public class TwitterRepository : ITwitterServiceBot
    {
        private const string customerKey = "JKCQxETtpfc0YNDwrEE83QWzQ";
        private const string customerSecretKey = "h7YagrykLnRoqKOWFfxUo8tOgbMKMr7x9Q3tN8oUsF0P7ajYBL";
        private const string accessToken = "1116847969985335301-zFBuuA1qSHdk0k2hwk95qXL2CB82wc";
        private const string accessSecretToken = "WVLn9FCryizk0HMAQNCLCQ3SBFJQsD7UmXg9iktVinMHS";

        private readonly IMessageService _messageService;

        public TwitterRepository(IMessageService messageService)
        {
            _messageService = messageService;
        }


        public TwitterService ConfigureTwitterUser()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Authentication of user \n\n");
                var user = new TwitterService(customerKey, customerSecretKey, accessToken, accessSecretToken);
                Console.ResetColor();

                return user;
            }

            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error -> {0} \n\n", ex.Message);
                Console.ResetColor();
                throw ex;
            }


        }

        public void SendTweetWithMedia()
        {
            try
            {
                string urlPhoto = _messageService.GetPhotoURL();
                string message = _messageService.GetMessage();

                using (var fileStream = new FileStream(urlPhoto, FileMode.Open))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Sending tweet \n\n");
                    Console.ResetColor();
                    var twitterService = ConfigureTwitterUser();
                    twitterService.SendTweetWithMedia(new SendTweetWithMediaOptions
                    {
                        Status = message,
                        Images = new Dictionary<string, Stream> { { urlPhoto, fileStream } }

                    });
                }

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error -> {0} \n\n", ex.Message);
                Console.ResetColor();
                throw ex;
            }
        }
    }
}
