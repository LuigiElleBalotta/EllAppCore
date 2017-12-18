using Server.Classes;
using Server.definitions;

namespace Server.Network.Packets.Server
{
    public class GenericResponsePacket : GenericSerializableResponsePacket
    {
        public ClientContext Client { get; set; }

        public void CopyToResponsePacket(ClientContext ctx, GenericSerializableResponsePacket pkt)
        {
            this.Client = ctx;

            this.Response = pkt.Response;
            this.IDAccountReceiver = pkt.IDAccountReceiver;
            this.IDAccountSender = pkt.IDAccountSender;
            this.SenderType = pkt.SenderType;
        }
    }
}
