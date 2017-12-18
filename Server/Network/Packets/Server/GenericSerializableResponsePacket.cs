using System;
using System.Collections.Generic;
using System.Text;
using Server.Classes;
using Server.definitions;

namespace Server.Network.Packets.Server
{
    public class GenericSerializableResponsePacket 
    {
        public Response Response { get; set; }

        public SenderType SenderType { get; set; }
        public int IDAccountSender { get; set; }
        public int IDAccountReceiver { get; set; }
    }
}
