namespace AddressBook.Controllers
{
    using Microsoft.AspNetCore.Mvc;
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
    }
}