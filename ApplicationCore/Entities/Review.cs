using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public float Score { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string ReviewContent { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
