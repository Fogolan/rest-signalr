using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using WebstackOfLove.Hubs;
using WebstackOfLove.Models;

namespace WebstackOfLove.Controllers
{
    [InvalidModelStateFilter]
    public class GeolocationController : ApiControllerWithHub<GeolocationHub>
    {
    }
}