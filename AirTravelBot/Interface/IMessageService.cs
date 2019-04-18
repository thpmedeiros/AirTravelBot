using System;
using System.Collections.Generic;
using System.Text;

namespace AirTravelBot.Interface
{
    public interface IMessageService
    {
        string GetPhotoURL();
        string GetMessage();
        int GenerateRandomNumbers(int maxNumber);
    }
}
