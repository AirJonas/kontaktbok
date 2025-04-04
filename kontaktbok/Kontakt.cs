using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontaktbok
{
    public class Kontakt
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Kontakt(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}
