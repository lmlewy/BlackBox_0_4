using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace SPA5BlackBoxReader
{
    class MessageAlert : IMessageStrategy
    {
        ResourceManager resmgr = new ResourceManager("SPA5BlackBoxReader.Lang", typeof(Message).Assembly);
        CultureInfo internalCI = null;

        public MessageAlert()
        {
            internalCI = CultureInfo.DefaultThreadCurrentCulture;
        }

        public List<string> Decode(byte[] alert)
        {
            List<string> decodedAlarm = new List<string>();
            int alertNumber = 0;
            string alertName = "";
            string alertStatus = "";
            string alertCategory = "";
            string alertGroup = "";

            alertNumber = (alert[1] << 8) + alert[2];

            alertName = resmgr.GetString("alert" + alertNumber.ToString(), internalCI);
            //alertName = resmgr.GetString("alert" + alertNumber.ToString(), ci);
            if (alertName == null) alertName = "Not Recognized event";

            if (alert[3] == 0x01) alertStatus = resmgr.GetString("alertNotActive", internalCI);
            else if (alert[3] == 0x02) alertStatus = resmgr.GetString("alertActive", internalCI);
            else alertStatus = resmgr.GetString("alertNotRecognized", internalCI);

            if (alert[4] == 0x01) alertCategory = resmgr.GetString("alertFirstCategory", internalCI);
            else if (alert[4] == 0x02) alertCategory = resmgr.GetString("alertSecondCategory", internalCI);
            else alertCategory = resmgr.GetString("alertCategoryNotRecognized", internalCI);

            alertGroup = alert[5].ToString();

            decodedAlarm.Add(resmgr.GetString("alertMessage", internalCI));
            decodedAlarm.Add(alertNumber.ToString());
            decodedAlarm.Add(alertName);
            decodedAlarm.Add(alertStatus);
            decodedAlarm.Add(alertCategory);
            decodedAlarm.Add(alertGroup);

            return decodedAlarm;

        }

    }
}
