using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace SPA5BlackBoxReader
{
    class MessageELS95 : IMessageStrategy
    {
        ResourceManager resmgr = new ResourceManager("SPA5BlackBoxReader.Lang", typeof(Message).Assembly);
        CultureInfo internalCI = null;

        public MessageELS95()
        {
            internalCI = CultureInfo.DefaultThreadCurrentCulture;
        }

        public List<string> Decode(byte[] elsDiagnostics)
        {
            List<string> decodedElsDiagnostics = new List<string>();

            string WDNumber = elsDiagnostics[1].ToString() ;
            string WDStatus = DecodeWDStatus(elsDiagnostics[2]);
            string F1Level = ((elsDiagnostics[3] * 3.0) / 255.0).ToString();
            string F2Level = ((elsDiagnostics[4] * 3.0) / 255.0).ToString();
            string WDstatusAM = DecodeWDStatusAM(elsDiagnostics[5]);
            string WDSts = DecodeWDSts(elsDiagnostics[6]);

            decodedElsDiagnostics.Add(resmgr.GetString("WDDiagn", internalCI));
            decodedElsDiagnostics.Add(WDNumber);

            decodedElsDiagnostics.Add(resmgr.GetString("WDStatus", internalCI) + ": " + WDStatus + ";\n"
                                      + resmgr.GetString("WDF1Level", internalCI) + ": " + F1Level + ", " + resmgr.GetString("WDF2Level", internalCI) + ": " + F2Level + ";\n"
                                      + WDstatusAM + ";\n"
                                      + WDSts);

            return decodedElsDiagnostics;
        }

        private string DecodeWDStatus(byte message)
        {
            string WDStatus;
            if (message == 0x01)
                WDStatus = resmgr.GetString("WDStatusNoFault", internalCI);
            else if (message == 0x02)
                WDStatus = resmgr.GetString("WDStatusHWFault", internalCI);
            else if (message == 0x04)
                WDStatus = resmgr.GetString("WDStatusTransFault", internalCI);
            else
                WDStatus = resmgr.GetString("WDStatusNotRecogn", internalCI);

            return WDStatus;
        }


        private string DecodeWDStatusAM(byte message)
        {
            string status = "Status ";
            if ((message & 0x80) == 0x00)
                status += "A ";
            else if ((message & 0x80) == 0x01)
                status += "M ";
            else
                status += "? ";

            if ((message & 0x40) == 0x01)
                status += "ELS-95: ";
            else
                status += "?: ";

            if ((message & 0x20) == 0x01)
                status += (resmgr.GetString("WDErrorDisturbance", internalCI) + ", ");

            if ((message & 0x10) == 0x01)
                status += (resmgr.GetString("WDErrorAutoTest", internalCI) + ", ");

            if ((message & 0x08) == 0x01)
                status += (resmgr.GetString("WDErrorAdjust", internalCI) + ", ");

            if ((message & 0x04) == 0x01)
                status += (resmgr.GetString("WDErrorSequence", internalCI) + ", ");

            if ((message & 0x04) == 0x01)
                status += (resmgr.GetString("WDErrorAdc", internalCI) + ", ");

            if ((message & 0x04) == 0x01)
                status += (resmgr.GetString("WDErrorLevel", internalCI) + ", ");

            return status;
        }


        private string DecodeWDSts(byte message)
        {
            string WDSts = "STS:";
            if ((message & 0x80) == 0x01)
                WDSts += (resmgr.GetString("WDStsCriticalError", internalCI) + ", ");

            if ((message & 0x40) == 0x01)
                WDSts += (resmgr.GetString("WDStsHeadOccupied", internalCI) + ", ");

            if ((message & 0x20) == 0x01)
                WDSts += (resmgr.GetString("WDStsSendingPermition", internalCI) + ", ");

            if ((message & 0x10) == 0x01)
                WDSts += (resmgr.GetString("WDStsMode", internalCI) + ", ");

            if ((message & 0x02) == 0x01)
                WDSts += (resmgr.GetString("WDStsOK", internalCI) + ", ");

            if ((message & 0x01) == 0x01)
                WDSts += (resmgr.GetString("WDStsCriticalErrHwSw", internalCI) + ", ");

            return WDSts;
        }

    }
}
