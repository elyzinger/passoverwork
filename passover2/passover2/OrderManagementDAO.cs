using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover2
{
    class OrderManagementDAO : IOrderManagementDAO
    {
        public void AddAmount(string productname, int amount)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("ADD_AMOUNT_TO_PRODUCTS", conn);
                cmd.Parameters.Add(new SqlParameter("@PRODUCT_NAME", productname));
                cmd.Parameters.Add(new SqlParameter("@AMOUNT", amount));



                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();
            }
        }

        public void AddNewCustomer(string newusername, string newpassword,string firstname,string lastname,int cc)
        {
            
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("CREATE_NEW_CUSTOMER", conn);
                cmd.Parameters.Add(new SqlParameter("@USERNAME", newusername));
                cmd.Parameters.Add(new SqlParameter("@PASS", newpassword));
                cmd.Parameters.Add(new SqlParameter("@FIRST_NAME", firstname));
                cmd.Parameters.Add(new SqlParameter("@LAST_NAME", lastname));
                cmd.Parameters.Add(new SqlParameter("@CC", cc));

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();
               

            }
        }

        public void AddProduct(string productname, int supplierid, int price, int quantity)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("ADD_PRODUCT", conn);
                cmd.Parameters.Add(new SqlParameter("@PRODUCT_NAME", productname));
                cmd.Parameters.Add(new SqlParameter("@SUPPLIER_ID", supplierid));
                cmd.Parameters.Add(new SqlParameter("@PRICE", price));
                cmd.Parameters.Add(new SqlParameter("@quantity", quantity));

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();
            }
        }

        public void AddSupplier(string supplierusername, string supplierpassword, string suppliercompany)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("CREATE_NEW_SUPPLIER", conn);
                cmd.Parameters.Add(new SqlParameter("@USERNAME", supplierusername));
                cmd.Parameters.Add(new SqlParameter("@PASS", supplierpassword));
                cmd.Parameters.Add(new SqlParameter("@COMPANY_NAME", suppliercompany));


                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();
            }
        }

        public void BuyProduct(string productname, int amount, string user)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("BUY_PRODUCT", conn);
                cmd.Parameters.Add(new SqlParameter("@PRODUCT_NAME", productname));
                cmd.Parameters.Add(new SqlParameter("@QUANTITY", amount));
                cmd.Parameters.Add(new SqlParameter("@USER_NAME", user));
                

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();


            }
        }

        public int CheckIdInProduct(string productname)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("CHECK_ID_IN_PRODUCT", conn);
                cmd.Parameters.Add(new SqlParameter("@PRODUCT_NAME", productname));
                

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();
                result = (int)cmd.ExecuteScalar();

            }
            return result;
        }

        public int GetSupplierIdByProduct(string productname)
        {
            int result = 1;
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("GET_SUPPLIERID_FROM_PRODUCTS", conn);
                cmd.Parameters.Add(new SqlParameter("@PRODUCT_NAME", productname));
                

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();
                result = (int)cmd.ExecuteScalar();

            }
            return result;
        }

        public int GetSupplierIdBySupplier(string suppliername, string supplierpass)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("GET_SUPPLIERID_BY_NAME_PASS", conn);
                cmd.Parameters.Add(new SqlParameter("@SUPPLIER_NAME", suppliername));
                cmd.Parameters.Add(new SqlParameter("@PASS", supplierpass));

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();
                result = (int)cmd.ExecuteScalar();

            }
            return result;
        }

        public int CheckStuck(string productname, int amount)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("CHECK_STUCK", conn);
                cmd.Parameters.Add(new SqlParameter("@PRODUCT_NAME", productname));
                cmd.Parameters.Add(new SqlParameter("@QUANTITY", amount));


                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();
                result = (int)cmd.ExecuteScalar();

            }
            return result;
        }

        public int CheckSupplierNameAndPassword(string suppliername, string supplierpass)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("CHECKPASSWORD_USERNAME_SUPPLIER", conn);
                cmd.Parameters.Add(new SqlParameter("@USERNAME", suppliername));
                cmd.Parameters.Add(new SqlParameter("@PASS", supplierpass));

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();
                result = (int)cmd.ExecuteScalar();

            }
            return result;
        }

        public int CheckUserNameAndPassword(string user, string pass)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("CHECKPASSWORD_USERNAME_CUSTOMER", conn);
                cmd.Parameters.Add(new SqlParameter("@USERNAME",user));
                cmd.Parameters.Add(new SqlParameter("@PASS", pass));

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();
                result = (int)cmd.ExecuteScalar();
                
            }
            return result;
        }

        public void MyShopingHistory(string user)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("MY_SHOPING_HISTORY", conn);
                cmd.Parameters.Add(new SqlParameter("@custmoer_name", user));

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);

                while (reader.Read() == true)
                {
                    Console.WriteLine($" firstname: {reader["firstname"]}  productname: {reader["productname"]}  amount: {reader["amount"]} totalprice: {reader["totalprice"]} ");
                }

                cmd.Connection.Close();
            }
        }

        public int ProductExist(string productname)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("CHECKIF_PRODUCTEXIST", conn);
                cmd.Parameters.Add(new SqlParameter("@PRODUCT_NAME", productname));
               

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();
                result = (int)cmd.ExecuteScalar();

            }
            return result;
        }

        public void ShowAllActions()
        {
            throw new NotImplementedException();
        }

        public void ShowAllMyProductsBySupplier(string suppliername, string supplierpass)
        {
            
            //Command and Data Reader
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SHOW_SUPPLIER_PRODUCTS", conn);
                cmd.Parameters.Add(new SqlParameter("@SUPPLIER_ID", GetSupplierIdBySupplier(suppliername, supplierpass)));

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);

                while (reader.Read() == true)
                {
                    Console.WriteLine($" product id: {reader["id"]}  productname: {reader["productname"]}  supplier id: {reader["supplierid"]}  price: {reader["price"]}  quantity: {reader["quantity"]}");
                }

                cmd.Connection.Close();
            }
        }

        public void ShowAllProducts()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SHOW_ALL_PRODUCTS", conn);
               

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);

                while (reader.Read() == true)
                {
                    Console.WriteLine($" product id: {reader["id"]}  productname: {reader["productname"]}  supplier id: {reader["supplierid"]}  price: {reader["price"]}  quantity: {reader["quantity"]}");
                }

                cmd.Connection.Close();
            }
        }

        public void TakeOfQuantity(int amount, string productname)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("TAKE_OF_QUANTITY", conn);
                cmd.Parameters.Add(new SqlParameter("@PRODUCT_NAME", productname));
                cmd.Parameters.Add(new SqlParameter("@QUANTITY", amount));
     


                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();


            }
        }

        public void SetTotalPrice()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SET_TOTAL_PRICE", conn);


                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

            }
        }
    }
}
