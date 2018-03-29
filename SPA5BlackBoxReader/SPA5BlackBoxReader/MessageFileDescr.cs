using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace SPA5BlackBoxReader
{
    class MessageFileDescr
    {
        ResourceManager resmgr = new ResourceManager("SPA5BlackBoxReader.Lang", typeof(Message).Assembly);
        CultureInfo internalCI = null;

        public MessageFileDescr()
        {
            internalCI = CultureInfo.DefaultThreadCurrentCulture;
        }

        public string Decode(byte[] file)
        {
            string decodedFile = null;

            foreach (byte letter in file)
            {
                if (letter != 0x00)
                    decodedFile += (char)letter;
            }

            return decodedFile;
        }

    }
}
