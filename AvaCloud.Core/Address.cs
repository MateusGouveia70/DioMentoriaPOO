using AvaCloud.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaCloud.Core
{
    public class Address : BaseEntity
    {
        public AdressEnum AddressType { get; private set; }
        public string City { get; private set; }
        public string PostCode { get; private set; }
        public string StreetName { get; private set; }
        public string State { get; set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }

     
        public override bool Validate()
        {
            if (!string.IsNullOrWhiteSpace(PostCode))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
 