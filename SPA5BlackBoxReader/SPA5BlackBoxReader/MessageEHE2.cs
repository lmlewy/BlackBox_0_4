using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace SPA5BlackBoxReader
{
    class MessageEHE2 : IMessageStrategy
    {
        ResourceManager resmgr = new ResourceManager("SPA5BlackBoxReader.Lang", typeof(Message).Assembly);
        CultureInfo internalCI = null;

        public MessageEHE2()
        {
            internalCI = CultureInfo.DefaultThreadCurrentCulture;
        }

        public List<string> Decode(byte[] eheDiagnostics)
        {
            List<string> decodedEheDiagnostics = new List<string>();

            string EheNumber = (eheDiagnostics[1] & 0x1F).ToString() ;
            string Diagnostics = null;

            switch ((eheDiagnostics[1] & 0xE0) >> 5)
            {
                case 0x01:
                    Diagnostics = DecodeEheDiagType1(eheDiagnostics);
                    break;
                case 0x02:
                    Diagnostics = DecodeEheDiagType2(eheDiagnostics);
                    break;
                case 0x03:
                    Diagnostics = DecodeEheDiagType3(eheDiagnostics);
                    break;
                default:
                    Diagnostics = "???";
                    break;

            }

            decodedEheDiagnostics.Add("EHE-2 Diagn.");
            decodedEheDiagnostics.Add(EheNumber);
            decodedEheDiagnostics.Add(Diagnostics);

            return decodedEheDiagnostics;
        }

        private string DecodeEheDiagType1(byte[] message)
        {
            string decodedMessage = null;

            decodedMessage += resmgr.GetString("EhePDM", internalCI) + ": " + message[2] + "\n";
            decodedMessage += resmgr.GetString("EheErrNr1", internalCI) + ": " + message[3] + "\n";
            decodedMessage += resmgr.GetString("EheErrNr2", internalCI) + ": " + message[4] + "\n";
            decodedMessage += resmgr.GetString("EheErrNr3", internalCI) + ": " + message[5] + "\n";
            decodedMessage += resmgr.GetString("EheErrNr4", internalCI) + ": " + message[6];

            return decodedMessage;
        }

        private string DecodeEheDiagType2(byte[] message)
        {
            string decodedMessage = null;

            decodedMessage += resmgr.GetString("EheTemp", internalCI) + ": " + message[2] + "\n";
            decodedMessage += resmgr.GetString("EheZpr", internalCI) + ": " + message[3] + "\n";
            decodedMessage += resmgr.GetString("EheILed", internalCI) + ": " + message[4] + "\n";
            decodedMessage += resmgr.GetString("EheULed", internalCI) + ": " + message[5];

            return decodedMessage;
        }

        private string DecodeEheDiagType3(byte[] message)
        {
            string decodedMessage = null;

            decodedMessage += resmgr.GetString("EheFs1Sample", internalCI) + ": " + message[2] + "\n";
            decodedMessage += resmgr.GetString("EheFs1", internalCI) + ": " + message[3] + "\n";
            decodedMessage += resmgr.GetString("EheFs2Sample", internalCI) + ": " + message[4] + "\n";
            decodedMessage += resmgr.GetString("EheFs2", internalCI) + ": " + message[5] + "\n";
            decodedMessage += resmgr.GetString("EheFs3Sample", internalCI) + ": " + message[6] + "\n";
            decodedMessage += resmgr.GetString("EheFs3", internalCI) + ": " + message[7];

            return decodedMessage;
        }

    }
}
