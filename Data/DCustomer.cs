using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DCustomer
    {
        private string connectionString = "Data Source=LAB1504-11\\SQLEXPRESS;Initial Catalog=Facturas;User ID=tecsup;Password=123456";

        public List<Customer> GetCustomer()
        {
            List<Customer> customer = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                string query = "listar_customer";

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
                                customer.Add(new Customer
                                {
                                    Customer_Id = Convert.ToInt32(reader["customer_id"]),
                                    Name = Convert.ToString(reader["name"]),
                                    Address = Convert.ToString(reader["address"]),
                                    Phone = Convert.ToString(reader["phone"])
                                });

                            }
                        }
                    }
                }

                // Cerrar la conexión
                connection.Close();


            }
            return customer;

        }

        public List<Customer> InsertCustomer()
        {
            List<Customer> customer = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                string query = "insert_customer";

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
                                customer.Add(new Customer
                                {
                                    Customer_Id = Convert.ToInt32(reader["customer_id"]),
                                    Name = Convert.ToString(reader["name"]),
                                    Address = Convert.ToString(reader["address"]),
                                    Phone = Convert.ToString(reader["phone"])
                                });

                            }
                        }
                    }
                }

                // Cerrar la conexión
                connection.Close();


            }
            return customer;

        }

        public List<Customer> DeleteCustomer()
        {
            List<Customer> customer = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                string query = "delete_customer";

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
                                customer.Add(new Customer
                                {
                                    Customer_Id = Convert.ToInt32(reader["customer_id"]),
                                    Name = Convert.ToString(reader["name"]),
                                    Address = Convert.ToString(reader["address"]),
                                    Phone = Convert.ToString(reader["phone"])
                                });

                            }
                        }
                    }
                }

                // Cerrar la conexión
                connection.Close();


            }
            return customer;

        }
    }
}
