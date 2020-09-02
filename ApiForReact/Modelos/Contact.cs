using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiForReact.Modelos
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string  Name { get; set; }
        public string Email { get; set; }
        public List<Company> Companies { get; set; }
    }
}
