using PhoneBook.Domain.Entities.Tags;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook_Project.Models.People
{
    public abstract class AddNewPersonViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        public IFormFile Image { get; set; }
    }

    public class AddNewPersonDisplayViewModel : AddNewPersonViewModel
    {
        public List<Tag> TagsForDisplay { get; set; }
    }

    public class AddNewPersonGetViewModel : AddNewPersonViewModel
    {
        public List<int> SelectedTag { get; set; }
    }
}
