using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaCloud.Core
{
    public class Customer : BaseEntity
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public Int64 Document { get; set; }
        public string Email { get; private set; }
        public List<Address> Andress { get; set; }
        public DateTime BirthDate { get; set; } 

        public string FullName 
        {
            get
            {
                string fullName = FistName;
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    fullName += string.Concat(" ",LastName);
                }
                return fullName;
            }
        }

        public override string ToString()
        {
            return $"Nome Completo: {FullName} Email: {Email} Data de Nascimento: {BirthDate}";
        }

        public override bool Validate()
        {
            return !string.IsNullOrWhiteSpace(FistName);
        }
    }
}
 