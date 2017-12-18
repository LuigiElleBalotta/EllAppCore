using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server;

namespace WebSocketDemo.Controllers
{
    public class LoginController : BaseController
    {
        public string Index()
        {
            return Program.Client.Send( "{ Type: 0, LoginPacket: { Username: \"test\", Psw: \"test\", WantWelcomeMessage: true }}");
        }
    }
}