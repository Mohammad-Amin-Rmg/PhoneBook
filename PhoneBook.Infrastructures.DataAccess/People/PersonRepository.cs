using PhoneBook.Domain.Contrasts.People;
using PhoneBook.Domain.Entities.People;
using PhoneBook.Infrastructures.DataAccess.Common;

namespace PhoneBook.Infrastructures.DataAccess.People
{
    public class PersonRepository : BaseRepository<Person>, IPersonRespository
    {
        public PersonRepository(AppDbContext dbContext) : base(dbContext) { }
    }
}
