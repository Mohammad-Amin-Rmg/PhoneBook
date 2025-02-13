using PhoneBook.Domain.Contrasts.Tags;
using PhoneBook.Domain.Entities.Tags;
using PhoneBook.Infrastructures.DataAccess.Common;

namespace PhoneBook.Infrastructures.DataAccess.Tags
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(AppDbContext dbContext) : base(dbContext) { }
    }
}
