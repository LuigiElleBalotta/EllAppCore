using System;
using Lappa.ORM;

namespace Server.Classes.Entities
{
	public class Account : Entity
	{
		public int		idAccount { get; set; }
		public string	Username { get; set; }
		public string	Password { get; set; }
		public string	Email { get; set; }
		public DateTime DataCreazione { get; set; }
		public string	LastConnection { get; set; }
		public string	LastIp { get; set; }
		public bool		IsOnline { get; set; }
	}
}
