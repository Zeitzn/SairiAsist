using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sairi.ModuloAsistencia.Areas.Seguridad.Controllers
{
    public class AccountController : Controller
    {
        // GET: Seguridad/Account
        public ActionResult Login()
        {
            return View();
        }
    }
}