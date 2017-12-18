using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Server.Socket;
using Server;
using WebSocketDemo.Custom.Serialization;

namespace WebSocketDemo.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Program.settings.Converters.Add(new IPAddressConverter());
            Program.settings.Converters.Add(new IPEndPointConverter());
            Program.settings.Formatting = Formatting.Indented;
            base.OnActionExecuting(context);
        }
    }
}