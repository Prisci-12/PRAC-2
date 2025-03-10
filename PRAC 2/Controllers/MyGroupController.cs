using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PRAC_2.Models; 

namespace PRAC_2.Controllers
{
    public class MyGroupController : Controller
    {
        // GET: MyGroup
        public ActionResult Index()
        {
            var members = new List<MyGroup>
            {
                new MyGroup { studentNumber = "u23755629", firstName = "Pricilia", lastName = "Nembelwe", emailAddress = "pricilia.nembelwe@gmail.com"  },
                new MyGroup { studentNumber = "u36356483", firstName = "Sharon", lastName = "Nkanyani", emailAddress = "sharon.nkanyani@gmail.com" },
                new MyGroup { studentNumber = "u98369836", firstName = "Tshilisanani", lastName = "Mamathuntsha", emailAddress = "tshilisanani.mamathuntsha@gmail.com"},
                new MyGroup { studentNumber = "u35168187", firstName = "Lugisani", lastName = "Mukhwathi", emailAddress = "lugisani.mukhwathi@gmail.com"},
                new MyGroup { studentNumber = "u73466466", firstName = "Collin", lastName = "Nembilwi", emailAddress = "collin.nembilwi@gmail.com"}
            };
            return View(members);

            
        }

        public ActionResult PersonalPage(string id)
        {
            return View(id);  // Will look for a view named "john.cshtml", "jane.cshtml", etc.
        }
    }
}