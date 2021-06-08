using System;
using System.Collections.Generic;
using System.Text;

namespace Compositon.entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DtBirth { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, DateTime dtBirth)
        {
            Name = name;
            Email = email;
            DtBirth = dtBirth;
        }
    }
}
