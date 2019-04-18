using AirTravelBot.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AirTravelBot.Repository
{
    public class MessageRepository : IMessageService
    {
        private readonly IDatabaseService _databaseService;

        public MessageRepository(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public int GenerateRandomNumbers(int maxNumber)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, maxNumber -1);

            return index;
        }

        public string GetMessage()
        {
            try
            {
                if (_databaseService.VerifyIfMessagesDatabaseExists())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Getting Message \n\n");
                    Console.ResetColor();
                    var listofMessages = File.ReadAllLines(_databaseService.GetMessagesDatabasePath());
                    var index = GenerateRandomNumbers(listofMessages.Length);
                    string message = listofMessages[index];

                    return message;
                }

                else
                {
                    Console.WriteLine("Database doesn't exists \n\n");
                    return String.Empty;
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

        public string GetPhotoURL()
        {
            try
            {
                if (_databaseService.VerifyIfImagesDatabaseExists())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Getting URL of photo \n\n");
                    Console.ResetColor();
                    var listofURL = File.ReadAllLines(_databaseService.GetImagesDatabasePath());
                    var index = GenerateRandomNumbers(listofURL.Length);
                    string urlPhoto = listofURL[index];

                    return urlPhoto;
                }

                else
                {
                    Console.WriteLine("Database doesn't exists \n\n");
                    return String.Empty;
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
