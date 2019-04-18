using System;
using System.Collections.Generic;
using System.Text;
using TweetSharp;

namespace AirTravelBot.Interface
{
    public interface ITwitterServiceBot
    {
        TwitterService ConfigureTwitterUser();
        void SendTweetWithMedia();
    }
}
