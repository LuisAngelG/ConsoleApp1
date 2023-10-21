using Entity;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DProduct
    {
        private string connectionString = "Data Source=LAB1504-11\\SQLEXPRESS;Initial Catalog=Facturas;User ID=tecsup;Password=123456";

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                string query = "listar_products";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verificar si hay filas
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Leer los datos de cada fila
                                products.Add(new Product
                                {
                                    Product_Id = Convert.ToInt32(reader["product_id"]),
                                    Name = Convert.ToString(reader["name"]),
                                    Price = Convert.ToDouble(reader["price"]),
                                    Stock = Convert.ToInt32(reader["stock"])
                                });

                            }
                        }
                    }
                }

                // Cerrar la conexión
                connection.Close();


            }
            return products;

        }
    }
}
