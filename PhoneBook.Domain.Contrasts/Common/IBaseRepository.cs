using PhoneBook.Domain.Entities;

namespace PhoneBook.Domain.Contrasts.Common
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity, new()
    {
        TEntity Get(int id);
        IQueryable<TEntity> GetAll();
        void Delete(int id);
        TEntity Add(TEntity entity);
    }
}
