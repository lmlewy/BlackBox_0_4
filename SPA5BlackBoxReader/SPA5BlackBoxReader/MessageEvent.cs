using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace SPA5BlackBoxReader
{
    class MessageEvent : IMessageStrategy
    {
        ResourceManager resmgr = new ResourceManager("SPA5BlackBoxReader.Lang", typeof(Message).Assembly);
        CultureInfo internalCI = null;

        public MessageEvent()
        {
            internalCI = CultureInfo.DefaultThreadCurrentCulture;
        }

        public List<string> Decode(byte[] decEvent)
        {
            List<string> decodedEvent = new List<string>();
            int eventNumber = 0;
            string eventName = "";
            string eventStatus = "";
            string eventGroup = "";

            eventNumber = (decEvent[1] << 8) + decEvent[2];

            eventName = resmgr.GetString("event" + eventNumber.ToString(), internalCI);
            if (eventName == null) eventName = "Not Recognized event";

            if (decEvent[3] == 0x01) eventStatus = resmgr.GetString("eventNotActive", internalCI);
            else if (decEvent[3] == 0x02) eventStatus = resmgr.GetString("eventActive", internalCI);
            else eventStatus = resmgr.GetString("eventNotRecognized", internalCI);

            eventGroup = decEvent[5].ToString();

            decodedEvent.Add(resmgr.GetString("eventMessage", internalCI));
            decodedEvent.Add(eventNumber.ToString());
            decodedEvent.Add(eventName);
            decodedEvent.Add(eventStatus);
            decodedEvent.Add("");
            decodedEvent.Add(eventGroup);

            return decodedEvent;

        }

    }
}
