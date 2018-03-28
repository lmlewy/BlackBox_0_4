using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace SPA5BlackBoxReader
{
    class MessageLocation : IMessageStrategy
    {
        ResourceManager resmgr = new ResourceManager("SPA5BlackBoxReader.Lang", typeof(Message).Assembly);
        CultureInfo internalCI = null;

        public MessageLocation()
        {
            internalCI = CultureInfo.DefaultThreadCurrentCulture;
        }

        public List<string> Decode(byte[] byteToDecode)
        {
            List<string> decodedLocation = new List<string>();
            string lxLocation = null;

            for(int i = 0; i < 9; i++)
                lxLocation += byteToDecode[i].ToString();

            decodedLocation.Add("Location");
            decodedLocation.Add(lxLocation);

            return decodedLocation;
        }



    }
}
