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

            string WDNumber = elsDiagnostics[0].ToString() ;
            string WDStatus = elsDiagnostics[1].ToString();
            string F1Level = elsDiagnostics[2].ToString();
            string F2Level = elsDiagnostics[3].ToString();

            decodedElsDiagnostics.Add("ELS-95 Diagn.");
            decodedElsDiagnostics.Add(WDNumber);
            decodedElsDiagnostics.Add(WDStatus + " " + F1Level + " " + F2Level);


            return decodedElsDiagnostics;
        }




    }
}
