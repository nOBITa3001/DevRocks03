namespace AddressBook.Controllers
{
    public class HomeController
    {
        public string Index()
        {
            //throw new System.Exception("TEST");
            return "Hello World!";
        }

        public string Error()
        {
            return "An error occurs.";
        }
    }
}