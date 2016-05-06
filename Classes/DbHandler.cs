using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CoffeeShopApp.Classes
{
    class DbHandler
    {
        private const string CONNSTR = "CoffeeShopDbConnectionString";
        private SqlConnection conn;

        public DbHandler()
        {
            //initialise
            conn = 
                new SqlConnection(
                    ConfigurationManager.ConnectionStrings[CONNSTR].ConnectionString);
        }

        /// <summary>
        /// Returns a DataTable of your query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                //open the connection
                conn.Open();

                //create an instance of sqldataadapter
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                //create an instance of dataset
                DataSet ds = new DataSet();

                //fill in the dataset
                adapter.Fill(ds);

                //fill datatable
                dt = ds.Tables[0];
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                //close the connection
                conn.Close();
            }

            return dt;
        }

        public int ExecuteQuery(string query)
        {
            int result = 0;

            try
            {
                //open the connection
                conn.Open();

                //create an instance of SqlCommand
                SqlCommand cmd = new SqlCommand(query, conn);

                result = cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {

                throw;
            }
            finally
            {
                //close the connection
                conn.Close();
            }

            return result;
        }
    }
}
