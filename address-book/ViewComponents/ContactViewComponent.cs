namespace AddressBook.ViewComponents
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Services;

    public class ContactViewComponent : ViewComponent
    {
        private readonly IContactRepository contactRepo;

        public ContactViewComponent(IContactRepository contactRepo)
        {
          this.contactRepo = contactRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync(Contact contact)
        {
            return this.View(contact);
        } 
    }
}