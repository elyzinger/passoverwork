using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover2
{
    class Orders
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public int TotalPrice { get; set; }

        public override string ToString()
        {
            return $"orders: id: {Id} CustomerId: {CustomerId}  ProductId: {ProductId} Amount: {Amount} TotalPrice: {TotalPrice}";
        }
    }
    
}
