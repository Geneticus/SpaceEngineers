using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VRage.ModAPI;

namespace Sandbox.ModAPI
{
    public interface IMySerialOutAccess
    {
        bool SendMessageToSerial(String Message, String devicename);
        bool SendMessageToSerial(String Message, int COMPortNumber, int baudRate);

        //VRage.SerialOutput.SerialOut Message = new VRage.SerialOutput.SerialOut();
        //bool MessageSuccess = SendMessageToSerial(String Message, int x);




    }








    //public interface IMyCharacter
    //{
    //    float EnvironmentOxygenLevel { get; }
    //    float BaseMass { get; }
    //    float CurrentMass { get; }

    //    //event CharacterMovementStateDelegate OnMovementStateChanged;

    //    void Kill(object killData = null);
    //}
}
