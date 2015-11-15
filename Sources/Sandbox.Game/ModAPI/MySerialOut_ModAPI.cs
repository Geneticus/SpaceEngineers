using Sandbox.ModAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VRage.ModAPI;
using VRage.SerialOutput;

namespace Sandbox.ModAPI
{
    public class MySerialOut : IMySerialOutAccess
    {
        bool IMySerialOutAccess.SendMessageToSerial(String Message, String devicename)
        {
            return SerialOut.SendMessageToSerial(Message, devicename);
        }
        bool IMySerialOutAccess.SendMessageToSerial(String Message, int COMPortNumber)
        {
            return SerialOut.SendMessageToSerial(Message, COMPortNumber);
        }


    }
}
