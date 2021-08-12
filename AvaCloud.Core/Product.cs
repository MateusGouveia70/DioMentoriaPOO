using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaCloud.Core
{
    public class Product : BaseEntity
    {
        public string Description { get; private set; }
        public Decimal Price { get; private set; }
        public string ProductName { get; private set; }
        public string Seller { get; private set; }

        public override bool Validate()
        {
            return !string.IsNullOrWhiteSpace(ProductName);
        }
    }
}
