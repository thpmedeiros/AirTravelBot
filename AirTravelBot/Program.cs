using AirTravelBot.Interface;
using AirTravelBot.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;

namespace AirTravelBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IDatabaseService, DatabaseRepository>()
                .AddSingleton<IMessageService, MessageRepository>()
                .AddSingleton<ITwitterServiceBot, TwitterRepository>()
                .BuildServiceProvider();

            var twitterService = serviceProvider.GetService<ITwitterServiceBot>();
            
            while(true)
            {
                twitterService.SendTweetWithMedia();
                Console.WriteLine("Tweet sent ! {0}", DateTime.Now);
                Thread.Sleep(600000);
            }

           
        }
    }
}
