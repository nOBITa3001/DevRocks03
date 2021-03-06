namespace AddressBook.Services
{
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class InMemoryContactRepository : IContactRepository
    {
        private IList<Contact> contacts = new List<Contact>()
        {
            new Contact() { ID = 1, FirstName = "Arsene", LastName = "Wenger", PhoneNumber = "0999999999", EmailAddress = "wenger@aresenal.com" }
            , new Contact() { ID = 2, FirstName = "Jose", LastName = "Mourinho", PhoneNumber = "0888888888", EmailAddress = "mourinho@manu.com" }
            , new Contact() { ID = 3, FirstName = "Pep", LastName = "Guardiola", PhoneNumber = "0777777777", EmailAddress = "guardiola@mancity.com" }
        };

        public IEnumerable<Contact> GetAll()
        {
            return this.contacts;
        }

        public void Add(Contact contact)
        {
            contact.ID = this.GenerateNewID();
            this.contacts.Add(contact);
        }

        private int GenerateNewID()
        {
            return (this.contacts.Max(x => x.ID) + 1);
        }
    }
}
