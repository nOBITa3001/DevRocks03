namespace AddressBook.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Contact
    {
        public int ID { get; set; }
        
        [Required, MaxLength(30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Required, MaxLength(80)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Required]
        [Phone]
        [Display(Name = "Phone Numner")]
        public string PhoneNumber { get; set; }
        
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}