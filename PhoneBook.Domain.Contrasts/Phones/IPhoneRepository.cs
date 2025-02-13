using PhoneBook.Domain.Contrasts.Common;
using PhoneBook.Domain.Entities.People;
using PhoneBook.Domain.Entities.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain.Contrasts.Phones
{
    public interface IPhoneRepository: IBaseRepository<Phone>
    {
    }
}
