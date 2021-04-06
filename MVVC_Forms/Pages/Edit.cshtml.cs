using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MVVC_Forms.Models;

namespace MVVC_Forms.Pages
{
    public class EditModel : PageModel
    {
        public EditModel(appDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        private readonly appDBContext _appDBContext;
        public PersonModel Person { get; set; }

        public void OnGet(string id)
        {
            Person = _appDBContext.PersonModels.FirstOrDefault( Person => Person.name == id);
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            PersonModel pers = new PersonModel();
            pers = _appDBContext.PersonModels.FirstOrDefault(Person=>Person.name==Person.name);
            if (pers != null)
            {
                pers.name = Person.name;
                pers.age = Person.age;
                pers.address = Person.address;
                pers.contact = Person.contact;
                pers.birthday = Person.birthday;
                pers.email = Person.email;
                pers.ethnicity = Person.ethnicity;
                _appDBContext.Update(pers);
                _appDBContext.SaveChanges();
            }
            return Redirect("Register");   
        }
    }
}
