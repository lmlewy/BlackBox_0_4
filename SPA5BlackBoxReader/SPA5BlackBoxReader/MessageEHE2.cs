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



            decodedEheDiagnostics.Add("EHE-2 Diagn.");




            return decodedEheDiagnostics;
        }



    }
}
