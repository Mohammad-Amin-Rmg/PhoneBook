using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain.Entities
{

    public class BaseEntity<T>
    {
        public T Id { get; set; }
    }

    public class BaseEntity : BaseEntity<int> { }
   
}
