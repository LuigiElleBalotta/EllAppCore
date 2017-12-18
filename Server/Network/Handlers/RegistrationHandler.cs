using System.Collections.Generic;
using Server.Classes;
using Server.definitions;
using Server.Network.Packets.Client;
using Server.Network.Packets.Server;

namespace Server.Network.Handlers
{
	public class RegistrationHandler
	{
		public static List<GenericSerializableResponsePacket> RegisterAccount(RegistrationPacket packet, ClientContext uContext)
		{
            List<GenericSerializableResponsePacket> responsePackets = new List<GenericSerializableResponsePacket>();

			bool result = AccountMgr.CreateAccount(packet.Username, packet.Psw, packet.Email);

            GenericSerializableResponsePacket grp = new GenericSerializableResponsePacket
            {
                                            Response = new RegistrationResponse
                                                       {
                                                           MessageType = MessageType.MSG_TYPE_REGISTRATION_RESPONSE,
                                                           Result = result
                                                       },
                                            SenderType = SenderType.Server
                                        };

            responsePackets.Add( grp );

            return responsePackets;
		}
	}
}
