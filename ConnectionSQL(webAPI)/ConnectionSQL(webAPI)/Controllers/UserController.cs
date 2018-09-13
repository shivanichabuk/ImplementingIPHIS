using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConnectionSQL_webAPI_.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ConnectionSQL_webAPI_.Controllers
{
    public class UserController : Controller
    {
        UserModels obj = new UserModels();
        // GET: User
        public ActionResult Index(UserRecords ur)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string s1 = "SELECT * FROM [dbo].[User]";
            SqlCommand sqlcomm = new SqlCommand(s1);
            sqlcomm.Connection = sqlconn;
            sqlconn.Open();
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            List<UserRecords> objmodel = new List<UserRecords>();
            if(sdr.HasRows)
            {
                while(sdr.Read())
                {
                    var details = new UserRecords();
                    details.FirstName = sdr["FirstName"].ToString();
                    details.MiddleName = sdr["MiddleName"].ToString();
                    details.LastName = sdr["LastName"].ToString();
                    details.EmailAddress = sdr["EmailAddress"].ToString();
                    details.Password = sdr["Password"].ToString();
                    details.PhoneNumber = sdr["PhoneNumber"].ToString();
                    objmodel.Add(details);
                }
                ur.userinfo = objmodel;
                sqlconn.Close();
            }
            return View("Index",ur);
        }

        [HttpGet]
        public ActionResult Registration(int id=0)
        {
            
            //var countrys = obj.Countries.ToList();
            //List<SelectListItem> licountry = new List<SelectListItem>();
            //licountry.Add(new SelectListItem() { Text = "Select Country", Value = "0" });
            //foreach(var item in countrys)
            //{
            //    licountry.Add(new SelectListItem() { Text = item.CountryName, Value = item.CountryId });
            //}
            //TempData["licountry"] = licountry;
            User usermodel = new User();
            return View(usermodel);

        }

        [HttpPost]
        public ActionResult Registration(User usermodel)
        {
            using (UserModels dbmodel = new UserModels())
            {
                dbmodel.Users.Add(usermodel);
                dbmodel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successfull.";
            return View("Registration", new User());
        }

        [HttpGet]
        public ActionResult Question(int id=0)
        {
            Answer answermodel = new Answer();
            using (UserModels dbmodel = new UserModels())
            {
                answermodel.QuestionCollection = dbmodel.SecurityQuestions.ToList<SecurityQuestion>();

            }
                return View(answermodel);
        }

        [HttpPost]
        public ActionResult Question(Answer answermodel)
        {
            
            return View();
        }

        [HttpGet]
        public ActionResult Login(int id = 0)
        {
            User usermodel = new User();
            return View(usermodel);
        }

        [HttpPost]
        public ActionResult Login(User usermodel)
        {
            using (UserModels dbmodel = new UserModels())
            {
                var userDetails = dbmodel.Users.Where(x => x.EmailAddress == usermodel.EmailAddress && x.Password == usermodel.Password).FirstOrDefault();
                if(userDetails==null)
                {
                    usermodel.LoginErrorMessage = "Invalid Email or Password.";
                    return View("Login", usermodel);
                }
                else
                {
                    Session["userID"] = userDetails.UserId;
                    Session["firstName"] = userDetails.FirstName;
                    Session["lastName"] = userDetails.LastName;
                    return RedirectToAction("Home","Home");
                }
                
            }
           
        }

        public ActionResult Logout()
        {
            int userId = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("Login","User");
        }
    }
}