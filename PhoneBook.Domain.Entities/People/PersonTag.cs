using PhoneBook.Domain.Entities.Tags;

namespace PhoneBook.Domain.Entities.People
{
    public class PersonTag : BaseEntity
    {
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
