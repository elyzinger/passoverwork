using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover2
{
    class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public int Price { get; set; }
        public int Quantitiy { get; set; }

        public override string ToString()
        {
            return $"Products: id: {Id} ProductName: {ProductName}  SupplierId: {SupplierId} Price: {Price} Quantitiy: {Quantitiy}";
        }

    }
}
