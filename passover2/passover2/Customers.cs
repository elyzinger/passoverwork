using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover2
{
    class Customers
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public int CC { get; set; }

        public override string ToString()
        {
            return $"customers: id: {Id}UserName: {UserName}  Password: {Password} FirstName: {FirstName} LastName: {LastName} creditcard: {CC}";
        }
    }
}
