using System.Collections.Generic;
using Server.Classes;
using Server.Classes.Entities;

namespace Server.Network.Packets.Server
{
	public class ChatRequestListResponse : Response
	{
		public List<ChatRoomForApp> ChatList { get; set; }
	}
}
