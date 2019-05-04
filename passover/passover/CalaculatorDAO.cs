using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover
{

    class CalaculatorDAO : ICalculatorDAO
    {
        public void InsertValuesXAndY(int X, int Y)
        {
            //Command and Data Reader
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("INSERT_X_Y", conn);
                cmd.Parameters.Add(new SqlParameter("@X_VALUE", X));
                cmd.Parameters.Add(new SqlParameter("@Y_VALUE", Y));

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

            }
        }
        //public List<int> GetResult()
        //{
        //    List<int> results = new List<int>();
        //    int result = 0;
        //    using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
        //    {
        //        SqlCommand cmd = new SqlCommand($"select x.xvalue, operation.operation, y.yvalue from x cross join operation join y on x.id=y.id ", conn);


        //        cmd.Connection.Open();
        //        //cmd.CommandType = CommandType.StoredProcedure;
        //        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
        //        while (reader.Read())
        //        {
        //            Xtable xtable = new Xtable
        //            {
        //                //ID = (int)reader["ID"],
        //                xValue = (int)reader["xvalue"]

        //            };

        //            Ytable ytable = new Ytable
        //            {


        //                //ID = (int)reader["ID"],
        //                yValue = (int)reader["yvalue"]

        //            };
        //            Operation operation = new Operation
        //            {

        //                //ID = (int)reader["id"],
        //                calcoperation = reader["operation"].ToString()

        //            };

        //            switch (operation.calcoperation)
        //            {
        //                case "+":
        //                    result = xtable.xValue + ytable.yValue;
        //                    break;
        //                case "-":
        //                    result = xtable.xValue - ytable.yValue;
        //                    break;
        //                case "*":
        //                    result = xtable.xValue * ytable.yValue;
        //                    break;
        //                case "/":
        //                    result = xtable.xValue / ytable.yValue;
        //                    break;
        //                default:
        //                    Console.WriteLine("Invalid");
        //                    break;

        //                    //if (operation.calcoperation =="+")
        //                    //{
        //                    //    result = xtable.xValue + ytable.yValue;
        //                    //}
        //                    //if (operation.calcoperation == "-")
        //                    //{
        //                    //    result = xtable.xValue - ytable.yValue;
        //                    //}
        //                    //if (operation.calcoperation == "*")
        //                    //{
        //                    //    result = xtable.xValue * ytable.yValue;
        //                    //}
        //                    //if (operation.calcoperation == "/")
        //                    //{
        //                    //    result = xtable.xValue / ytable.yValue;
        //                    //}
        //                    //}

        //                    //cmd.Connection.Close();
        //            }

        //        }
        //        results.Add(result);



        //        return results;

        //    }


       // }
    }
}
