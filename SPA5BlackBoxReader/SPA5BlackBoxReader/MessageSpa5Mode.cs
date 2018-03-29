using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace SPA5BlackBoxReader
{
    class MessageSpa5Mode : IMessageStrategy
    {
        ResourceManager resmgr = new ResourceManager("SPA5BlackBoxReader.Lang", typeof(Message).Assembly);
        CultureInfo internalCI = null;

        public MessageSpa5Mode()
        {
            internalCI = CultureInfo.DefaultThreadCurrentCulture;
        }

        public List<string> Decode(byte[] spaMode)
        {
            List<string> decodedMode = new List<string>();
            string mode = spaMode[0].ToString();
            string modNumber1 = spaMode[1].ToString();
            string errNumber1 = spaMode[2].ToString();
            string modNumber2 = spaMode[3].ToString();
            string errNumber2 = spaMode[4].ToString();
            string modNumber3 = spaMode[5].ToString();
            string errNumber3 = spaMode[6].ToString();

            decodedMode.Add("SPA-5 Mode");
            decodedMode.Add("");
            decodedMode.Add("Mode: " + mode + ", Mod Num 1: " + modNumber1 + ", Err Num 1: " + errNumber1
                                            + ", Mod Num 2: " + modNumber2 + ", Err Num 2: " + errNumber2
                                            + ", Mod Num 3: " + modNumber3 + ", Err Num 3: " + errNumber3 );

            return decodedMode;
        }




    }
}
