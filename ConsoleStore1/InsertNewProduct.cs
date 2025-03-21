﻿using System;
using MySql.Data.MySqlClient;

namespace ConsoleStore1

{
    class ManageProduct
    {
        public class InsertNewProduct
        {
            private string server = "localhost";
            private string database = "deanapp";
            private string username = "root";
            private string password = "";
            private string connString;

            public InsertNewProduct()
            {
                connString = $"Server={server};Database={database};User ID={username};Password={password};";
            }

            public void InsertData(string productName, string productDescription, int productPrice)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        Console.WriteLine("Connected to MySQL!");

                        string query = "INSERT INTO products (productName,productDescription, productPrice) VALUES (@name,@description, @price)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", productName);
                            cmd.Parameters.AddWithValue("@description", productDescription);
                            cmd.Parameters.AddWithValue("@price", productPrice);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            Console.WriteLine(rowsAffected > 0 ? "Data inserted successfully!" : "Failed to insert data.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}