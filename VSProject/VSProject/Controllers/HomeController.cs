using Glass.Mapper.Sc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VSProject.Models;

namespace VSProject.Controllers
{
    public class HomeController: BaseController
    {
        // GET: Home
        public ActionResult HelloWorld()
        {
            IHomeModel context = SitecoreContext.GetCurrentItem<IHomeModel>();
            return View(context);
        }
    }
}