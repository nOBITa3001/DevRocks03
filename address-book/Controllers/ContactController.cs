namespace AddressBook.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Services;

    public class ContactController : Controller
    {
        private readonly IContactRepository contactRepo;
        
        public ContactController (IContactRepository contactRepo)
        {
            this.contactRepo = contactRepo;
        }

        public IActionResult Index()
        {
            var model = this.contactRepo.GetAll();
            return this.View(model);
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (this.ModelState.IsValid)
            {
                this.contactRepo.Add(contact);
                
                return this.RedirectToAction("Index");
            }

            return this.View(contact);
        }
    }
}