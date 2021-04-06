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
        public RegisterModel(appDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        private readonly appDBContext _appDBContext;
        [BindProperty]
       public PersonModel Person { get; set; }
        public List<PersonModel> Persons = new List<PersonModel>();
        public void OnGet()
        {
            Persons = _appDBContext.PersonModels.ToList();
        }
         public ActionResult OnPost() 
         {

             if (!ModelState.IsValid)
             {
                Persons = _appDBContext.PersonModels.ToList();
                return Page();
             }

                 
            _appDBContext.PersonModels.Add(Person);
            _appDBContext.SaveChanges();
            return Redirect("/Register ");

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
        /* public void OnPost()
         {
             if (!ModelState.IsValid)
             {
                 return Page();
             }

             return Redirect("/Index ");
             _appDBContext.PersonModels.Add(Person);
             _appDBContext.SaveChanges();
         }*/
        public void OnGetDelete(string id)
        {

            var Person = _appDBContext.PersonModels.FirstOrDefault(Person => Person.name == id);

            if (Person != null)
            {
                _appDBContext.PersonModels.Remove(Person);
                _appDBContext.SaveChanges();
            }
            OnGet();

        }
    }
}
