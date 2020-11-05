using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace VevericaOnline.Controllers
{
    public class VevericaController : Controller
    {
        // GET: Veverica
        public string[] Update()
        {
            var data = Directory.GetFiles(@"C:\Users\Nesani\Desktop\Updater");

            return data;

        }
    }
}