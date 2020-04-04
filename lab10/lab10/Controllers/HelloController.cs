using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lab10.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult CreateAlphanumeric()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAlphanumeric(string firstName, string lastName, string dateOfBirth, string group)
        {
            string authData = $"First name: {firstName}   Last name: {lastName}   Date of birth: {dateOfBirth}   Group: {group}";

            string FN = firstName.Substring(0,1);//getting first letter of the first name
            string LN = lastName.Substring(0,1);//getting first letter of the last name
            string DB = dateOfBirth.Substring(8);//getting last two digits from year
            string GR = "";
            for (int i = 0; i < group.Length; i++) {
                if (char.IsDigit(group[i])) {
                    GR += group[i];//getting only digits from the group
                }
            }

            string alphanumeric = FN + LN + DB + GR;//our alphanumeric code

            List<string> alphanumericList = new List<string>();
            alphanumericList.Add(alphanumeric);

            foreach (string i in alphanumericList)
            {
                Console.WriteLine(i);
            }

            return Content("Your alphanumeric code: " + alphanumeric);
        }
    }
}