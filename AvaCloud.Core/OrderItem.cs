using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaCloud.Core
{
    public class OrderItem : BaseEntity
    {
        public int ProductId { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public Decimal TotalPrice
        {
            get
            {
                if (Product == null)
                {
                    return 0;
                }

                return Product.Price * Quantity;
            }
        }

        public override bool Validate()
        {
            if (Quantity <= 0 || Id <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
