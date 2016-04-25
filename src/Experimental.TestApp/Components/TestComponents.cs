using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Experimental.TestApp.Components
{
    public class TestComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var testModel = "Bella, SEM";
            return View("_Default", testModel);
        }
    }
}
