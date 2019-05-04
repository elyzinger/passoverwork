using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover2
{
    interface IOrderManagementDAO
    {
        int CheckUserNameAndPassword(string user,string pass);
        void MyShopingHistory(string user);
        void ShowAllProducts();
        int ProductExist(string productname);
        int CheckStuck(string productname, int amount);
        void BuyProduct(string productname,int amount,string user);
        void AddNewCustomer(string newusername, string newpassword, string firstname, string lastname, int cc);
        int CheckSupplierNameAndPassword(string suppliername, string supplierpass);
        int GetSupplierIdByProduct(string productname);
        int GetSupplierIdBySupplier(string suppliername, string supplierpass);
        int CheckIdInProduct(string productname);
        void AddAmount(string productname, int amount);
        void AddProduct(string productname,int supplierid, int price, int quantity);
        void ShowAllMyProductsBySupplier(string suppliername,string supplierpass);
        void AddSupplier(string supplierusername, string supplierpassword, string suppliercompany);
        void ShowAllActions();
        void TakeOfQuantity(int amount,string productname);
        void SetTotalPrice();
    }
}
