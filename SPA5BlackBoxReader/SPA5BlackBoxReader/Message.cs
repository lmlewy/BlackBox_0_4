using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace SPA5BlackBoxReader
{
    class Message
    {   

        public Message()
        {

        }

        public List<string> DecodeMessageToList(byte[] message)
        {
            List<string> decodedMessage = new List<string>();
            decodedMessage.Clear();
            IMessageStrategy str = null;
            switch (message[0])
            {
                case (byte)Constants.MessageType.MESSTYPE_LOCATION:
                    str = GetMessageStrategy(Constants.MessageType.MESSTYPE_LOCATION);
                    decodedMessage = str.Decode(message).ToList();
                    break;

                case (byte)Constants.MessageType.MESSTYPE_ALERT:
                    str = GetMessageStrategy(Constants.MessageType.MESSTYPE_ALERT);
                    decodedMessage = str.Decode(message).ToList();
                    break;

                case (byte)Constants.MessageType.MESSTYPE_EVENT:
                    str = GetMessageStrategy(Constants.MessageType.MESSTYPE_EVENT);
                    decodedMessage = str.Decode(message).ToList();
                    break;

                case (byte)Constants.MessageType.MESSTYPE_ELS95:
                    str = GetMessageStrategy(Constants.MessageType.MESSTYPE_ELS95);
                    decodedMessage = str.Decode(message).ToList();
                    break;

                case (byte)Constants.MessageType.MESSTYPE_MODE:
                    str = GetMessageStrategy(Constants.MessageType.MESSTYPE_MODE);
                    decodedMessage = str.Decode(message).ToList();
                    break;

                //case (byte)Constants.MessageType.MESSTYPE_FILEDESC:
                //    str = GetMessageStrategy(Constants.MessageType.MESSTYPE_FILEDESC);
                //    decodedMessage = str.Decode(message).ToList();
                //    break;

                case (byte)Constants.MessageType.MESSTYPE_EHE2:
                    str = GetMessageStrategy(Constants.MessageType.MESSTYPE_EHE2);
                    decodedMessage = str.Decode(message).ToList();
                    break;

                default:
                    decodedMessage.Add("Message type Error");
                    break;
            }

            return decodedMessage;
        }

        static IMessageStrategy GetMessageStrategy(Constants.MessageType messType)
        {
            switch (messType)
            {
                case Constants.MessageType.MESSTYPE_LOCATION:
                    return new MessageLocation();
                case Constants.MessageType.MESSTYPE_ALERT:
                    return new MessageAlert();
                case Constants.MessageType.MESSTYPE_EVENT:
                    return new MessageEvent();
                case Constants.MessageType.MESSTYPE_ELS95:
                    return new MessageELS95();
                case Constants.MessageType.MESSTYPE_MODE:
                    return new MessageSpa5Mode();
                //case Constants.MessageType.MESSTYPE_FILEDESC:
                //    return new MessageFileDescr();
                case Constants.MessageType.MESSTYPE_EHE2:
                    return new MessageEHE2();
                default:
                    return new MessageLocation();

            }
        }

    }

}

