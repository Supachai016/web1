using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web1.Models
{
    public class Contact
    {
        public String Name { get; set; }
        [EmailAddress]
        public String Email { get; set; }
        public String Supject { get; set; }
        public String Message { get; set; }
        public bool SendCopy { get; set; }

    }
}
