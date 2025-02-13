using PhoneBook.Domain.Contrasts.Phones;
using PhoneBook.Domain.Entities.Phones;
using PhoneBook.Infrastructures.DataAccess.Common;

namespace PhoneBook.Infrastructures.DataAccess.Phones
{
    public class PhoneRepository : BaseRepository<Phone>, IPhoneRepository
    {
        public PhoneRepository(AppDbContext dbContext) : base(dbContext) { }
    }
}
