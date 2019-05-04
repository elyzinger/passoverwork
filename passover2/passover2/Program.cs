using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover2
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrderManagementDAO dao = new OrderManagementDAO();

            int x = 0;
            do {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine()
                Console.WriteLine("1: existing customer");
                Console.WriteLine("2: new customer");
                Console.WriteLine("3: existing supplier");
                Console.WriteLine("4: new supplier");
                Console.WriteLine("5: show all actions");
                Console.WriteLine("6: exit");
                Console.WriteLine();
                x = Convert.ToInt32(Console.ReadLine());


                switch (x)
                {
                    case 1:
                        Console.WriteLine("user name:");
                        string user = Console.ReadLine();
                        Console.WriteLine("user password:");
                        string pass = Console.ReadLine();
                        if (dao.CheckUserNameAndPassword(user, pass) == 1)
                        {
                            int y = 0;
                            Console.WriteLine("EXISTING CUSTOMER MENU");
                            Console.WriteLine();
                            Console.WriteLine("1: my shoping history");
                            Console.WriteLine("2: show all products");
                            Console.WriteLine("3: buy product");
                            Console.WriteLine("other: number back to manu");
                            y = Convert.ToInt32(Console.ReadLine());
                            if (y == 1)
                            {
                                Console.WriteLine($"{user} shoping history: ");
                                Console.WriteLine();
                                 dao.MyShopingHistory(user);
                                    Console.ReadLine();
                            }
                            if (y == 2)
                            {
                                dao.ShowAllProducts();
                            }
                            if (y == 3)
                            {
                                Console.WriteLine("enter product name:");
                                string productname = Console.ReadLine();
                                if (dao.ProductExist(productname) == 1)
                                {
                                    Console.WriteLine("enter amount:");
                                    int amount = Convert.ToInt32(Console.ReadLine());
                                    if (dao.CheckStuck(productname, amount) == 1)
                                    {
                                        dao.BuyProduct(productname, amount, user);
                                        dao.TakeOfQuantity(amount, productname);
                                        dao.SetTotalPrice();
                                    }
                                    else
                                    {
                                        Console.WriteLine("out of stuck");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("product not found");
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("password and user name problem");
                        }
                      
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("user name: ");
                        string newusername = Console.ReadLine();
                        Console.WriteLine("create password: ");
                        string newpassword = Console.ReadLine();
                        Console.WriteLine("first name: ");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("last name: ");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("credit card number: ");
                        int cc = Convert.ToInt32 (Console.ReadLine());

                        dao.AddNewCustomer(newusername, newpassword,firstname,lastname,cc);                        
                        break;
                    case 3:
                        Console.WriteLine("SUPPLIER MENU");
                        Console.WriteLine();
                        Console.WriteLine("supplier user name:");
                        string suppliername = Console.ReadLine();
                        Console.WriteLine("supplier password:");
                        string supplierpass = Console.ReadLine();
                        if(dao.CheckSupplierNameAndPassword(suppliername, supplierpass)== 1)
                        {
                            int y = 0;
                            Console.WriteLine("EXISTING SUPPLIER MENU");
                            Console.WriteLine();
                            Console.WriteLine("1: add product to stuck");
                            Console.WriteLine("2: show all my products in stuck");
                            y = Convert.ToInt32(Console.ReadLine());
                            if (y == 1)
                            {
                                Console.WriteLine("enter product name: ");
                                string productname = Console.ReadLine();
                                   if (dao.CheckIdInProduct(productname) == 1 && dao.GetSupplierIdByProduct(productname) != dao.GetSupplierIdBySupplier(suppliername, supplierpass))
                                {
                                    Console.WriteLine("there is another supplier!");
                                    break;
                                }
                                if (dao.CheckIdInProduct(productname) == 1 && dao.GetSupplierIdByProduct(productname) == dao.GetSupplierIdBySupplier(suppliername, supplierpass))
                                {
                                    Console.WriteLine($"how many {productname} do you want to add:");
                                    int amount = Convert.ToInt32(Console.ReadLine());
                                    dao.AddAmount(productname, amount);
                                }
                                else
                                {
                                    Console.WriteLine("enter supplier id: ");
                                    int supplierid = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("enter price: ");
                                    int price = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("enter quantity: ");
                                    int quantity = Convert.ToInt32(Console.ReadLine());
                                    dao.AddProduct(productname, supplierid, price, quantity);
                                }
                            }
                            if (y == 2)
                            {
                                dao.ShowAllMyProductsBySupplier(suppliername, supplierpass);
                                Console.ReadLine();
                            }
                            
                        }
                        break;
                    case 4:
                        Console.WriteLine("ADDING SUPPLIER");
                        Console.WriteLine();
                        Console.WriteLine("enter user name: ");
                        string supplierusername = Console.ReadLine();
                        Console.WriteLine("enter new password: ");
                        string supplierpassword = Console.ReadLine();
                        Console.WriteLine("enter company name: ");                     
                        string suppliercompany = Console.ReadLine();
                        dao.AddSupplier(supplierusername, supplierpassword, suppliercompany);
                        break;
                    case 5:
                        Console.WriteLine("ALL ACTIONS MADE");
                      //  ShowAllActions();
                        break;
                } 
            } while (x != 6);
            Console.ReadLine();
            
        }

       
    }
}
