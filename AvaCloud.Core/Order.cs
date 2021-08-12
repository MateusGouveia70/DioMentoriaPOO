using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaCloud.Core
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; private set; }
        public List<OrderItem> OrderItem { get; private set; }
        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; }


        public override bool Validate()
        {
           return OrderItem.Count > 0;
        }
    }
}
 