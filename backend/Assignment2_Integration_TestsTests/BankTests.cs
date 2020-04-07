using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2_Integration_Tests;
using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using MySql.Data.MySqlClient;

namespace Assignment2_Integration_Tests.Tests
{
    [TestClass()]
    public class BankTests
    {
        

        [TestMethod()]
        public void CreateTablesTest()
        {
        
            Bank bank = new Bank("123", "danskebank");
            bank.CreateTables();

            string cs = "Server=127.0.0.1;Database=db_bank;Uid=bank;Pwd=abc123";
            int count = 0;
            MySql.Data.MySqlClient.MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select count(*) from information_schema.tables where table_name = 'banktable'";
                count = int.Parse(cmd.ExecuteScalar().ToString());
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
            Assert.IsTrue(count > 0);
        }
    }
    
}