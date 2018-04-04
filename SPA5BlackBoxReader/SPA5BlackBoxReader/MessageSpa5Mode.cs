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
            string mode = spaMode[1].ToString();
            string modNumber1 = spaMode[2].ToString();
            string errNumber1 = spaMode[3].ToString();
            string modNumber2 = spaMode[4].ToString();
            string errNumber2 = spaMode[5].ToString();
            string modNumber3 = spaMode[6].ToString();
            string errNumber3 = spaMode[7].ToString();

            string modeName = null;
            switch(spaMode[1])
            {
                case 1:
                    modeName = "Start";
                    break;
                case 2:
                    modeName = "Diag";
                    break;
                case 8:
                    modeName = "Active";
                    break;
                default:
                    modeName = "Not Recognized";
                    break;
            }

            decodedMode.Add("SPA-5 Mode");
            decodedMode.Add("");

            //decodedMode.Add("Mode: " + mode + "-" + modeName + ";\n"
            //                + " Mod Num " + modNumber1 + ", Err Num " + errNumber1 + ";\n"
            //               + " Mod Num " + modNumber2 + ", Err Num " + errNumber2 + ";\n"
            //                + " Mod Num " + modNumber3 + ", Err Num " + errNumber3 );

            string fullMessage = null;
            fullMessage = "Mode: " + mode + "-" + modeName + ";";
            if (modNumber1 != "0" && errNumber1 != "0")
            {
                fullMessage +="\n Mod Num " + modNumber1 + ", Err Num " + errNumber1 + ";";
            }
            if (modNumber2 != "0" || errNumber2 != "0")
            {
                fullMessage +="\n Mod Num " + modNumber2 + ", Err Num " + errNumber2 + ";";
            }
            if (modNumber3 != "0" || errNumber3 != "0")
            {
                fullMessage += "\n Mod Num " + modNumber3 + ", Err Num " + errNumber3 + ";";
            }

            decodedMode.Add(fullMessage);
            return decodedMode;
        }

    }
}
