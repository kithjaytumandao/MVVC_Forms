using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MVVC_Forms.Models;

namespace MVVC_Forms.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
       public PersonModel Person { get; set; }
        public void OnGet()
        {
        }
        public ActionResult OnPost() 
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
     
                return Redirect("/Index ");
            

    
           
            /*string name = Request.Form["txtname"];
            string age = Request.Form["txtage"];
            string address = Request.Form["txtAddress"];
            string contact = Request.Form["txtContactNo"];
            string birthday = Request.Form["txtBirthDay"];
            string email = Request.Form["txtEmail"];
            string ethnicity = Request.Form["txtEthnicity"];
            HttpResponseWritingExtensions.WriteAsync(this.Response,"Good Day!"+Person.name+
                                                    ".\nYou are:"+ Person.age + "y/o.\nYou live in"+ Person.address +
                                                    "Your Contact Number is:"+ Person.contact +
                                                    "\nYour BirthDay is:"+ Person.birthday +
                                                    "\nYour Email is:"+ Person.email +
                                                    "\nYour Ethnicity is:"+ Person.ethnicity);*/
           
        }
    }
}
