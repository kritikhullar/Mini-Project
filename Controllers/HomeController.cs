using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Virtual_Bank.Models;

namespace Virtual_Bank.Controllers
{
    public class HomeController : Controller
    {
        MINIPROJECTEntities1 entities = new MINIPROJECTEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        
        public ActionResult SignUp()
        {
            return View();
        }
        //postmethod

        [HttpPost]
        public ActionResult SignUp(FormCollection form,LOGIN log)
        {
            log.UserName = form["UserName"];
            log.Pasword = form["Pasword"];
            log.Email_id = form["Email_id"];
            log.Phone_no = long.Parse(form["Phone_no"]);
            log.D_O_B = DateTime.Parse(form["D_O_B"]);
            log.Opening_date = DateTime.Now;
            log.Amount = 50000;
            log.Type_Acc = form["Type_Acc"];
            entities.LOGINs.Add(log);
            entities.SaveChanges();
            Random R = new Random();
            string s1 = "51104250";
            string s2 = R.Next(10000000,99999999).ToString()+s1;
            CreditCard_Details cc = new CreditCard_Details();
            cc.CC_No = s2;
            cc.EXP_dateyear = 2050;
            cc.Limit = 1000;
            cc.User_ph_no = log.Phone_no;
            cc.CVV = R.Next(100, 999);
            entities.CreditCard_Details.Add(cc);
            entities.SaveChanges();
            return RedirectToAction("Login");
           // return View();

        }
    }
}