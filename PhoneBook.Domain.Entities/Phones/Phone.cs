using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain.Entities.Phones
{
    public class Phone : BaseEntity
    {
        public string Number { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
