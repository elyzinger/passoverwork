using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover2
{
    class Suppliers
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }

        public override string ToString()
        {
            return $"Suppliers: id: {Id}UserName: {UserName}  Password: {Password} CompanyName: {CompanyName}";
        }
    }
}
