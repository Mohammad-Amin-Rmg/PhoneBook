using PhoneBook.Domain.Contrasts.Common;
using PhoneBook.Domain.Entities.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain.Contrasts.People
{
    public interface IPersonRespository : IBaseRepository<Person>
    {
    }
}
