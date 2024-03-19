using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public decimal Price { get; set; }
        public int quantities { get; set; }
    }
}
