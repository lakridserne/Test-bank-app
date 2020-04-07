using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2_Integration_Tests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Assignment2_Integration_Tests.Tests
{
    [TestClass()]
    public class BankDBTests
    {
        [TestMethod()]
        public void createTablesTest()
        {

            string cs = "Server=127.0.0.1;Database=BankDb;Uid=bank;Pwd=abc123";

            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(cs);
               conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select 1 from information_schema.tables where table_name = 'banktable";
                cmd.ExecuteNonQuery();
              

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}