using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA5BlackBoxReader
{
    class BinToListReader
    {
        public List<string> ReadFile(byte[] fileBytes)
        {
            List<string> itemsList = new List<string>();    //to jest szybkie

            string bufor = "";
            int hexNumber = 0, lineNumber = 0;

            itemsList.Clear();
            foreach (byte b in fileBytes)
            {
                if (hexNumber == 0) bufor += lineNumber.ToString() + ": ";
                bufor += " ";
                if (b < 16) bufor += "0";
                bufor += b.ToString("x").ToUpperInvariant();
                hexNumber++;
                if (hexNumber > 16)
                {
                    itemsList.Add(bufor);
                    bufor = "";
                    hexNumber = 0;
                    lineNumber += 16;
                }
            }

            return itemsList;
        }

    }
}
