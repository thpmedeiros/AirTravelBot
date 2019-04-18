using System;
using System.Collections.Generic;
using System.Text;

namespace AirTravelBot.Interface
{
    public interface IDatabaseService
    {
        string GetMessagesDatabasePath();
        string GetImagesDatabasePath();
        bool VerifyIfMessagesDatabaseExists();
        bool VerifyIfImagesDatabaseExists();
        void CreateMessagesDatabase();
        void CreateImagesDatabase();
    }
}
