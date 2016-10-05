namespace AddressBook.Services
{
    using Models;
    using System.Collections.Generic;
    
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAll();
    }
}
