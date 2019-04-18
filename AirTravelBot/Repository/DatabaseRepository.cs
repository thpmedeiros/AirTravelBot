using AirTravelBot.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AirTravelBot.Repository
{
    public class DatabaseRepository : IDatabaseService
    {

        private const string directoryPath = @"C:\Users\thiag\source\repos\AirTravelBot\AirTravelBot\Database\";
        private const string messagesDatabaseName = "MessagesDatabase.txt";
        private const string imagesDatabaseName = "ImagesDatabase.txt";

        public void CreateImagesDatabase()
        {
            try
            {
                if(!VerifyIfImagesDatabaseExists())
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Creating Images Database \n\n");
                    Console.ResetColor();
                    File.Create(GetImagesDatabasePath());
                }
            }
            catch (Exception ex)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Error -> {0} \n\n", ex.Message);
                Console.ResetColor();
                throw ex;
            }
        }

        public void CreateMessagesDatabase()
        {
            try
            {
                if (!VerifyIfMessagesDatabaseExists())
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Creating Messages Database \n\n");
                    Console.ResetColor();
                    File.Create(GetMessagesDatabasePath());
                }
            }
            catch (Exception ex)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Error -> {0} \n\n", ex.Message);
                Console.ResetColor();
                throw ex;
            }
        }

        public string GetImagesDatabasePath()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Getting image path \n\n");
                Console.ResetColor();

                return directoryPath + imagesDatabaseName;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error -> {0} \n\n", ex.Message);
                Console.ResetColor();
                throw ex;
            }
            
        }

        public string GetMessagesDatabasePath()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Getting message path \n\n");
                Console.ResetColor();

                return directoryPath + messagesDatabaseName;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error -> {0} \n\n", ex.Message);
                Console.ResetColor();
                throw ex;
            }
        }

        public bool VerifyIfImagesDatabaseExists()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Verifying if Images Database exists \n\n");
                Console.ResetColor();

                return File.Exists(GetImagesDatabasePath());
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error -> {0} \n\n", ex.Message);
                Console.ResetColor();
                throw ex;
            }
        }

        public bool VerifyIfMessagesDatabaseExists()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Verifying if Messages Database exists \n\n");
                Console.ResetColor();

                return File.Exists(GetMessagesDatabasePath());
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
