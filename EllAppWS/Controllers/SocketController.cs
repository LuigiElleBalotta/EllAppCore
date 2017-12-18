using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server;

namespace WebSocketDemo.Controllers
{
    public class SocketController : BaseController
    {
        public string SendData( string data )
        {
            return Program.Client.Send( data );
        }
    }
}