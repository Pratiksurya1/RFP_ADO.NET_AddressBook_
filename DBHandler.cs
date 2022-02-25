using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO.NET
{
    public class DBHandler : DBConnector
    {
        public override void Insert(AddressBookModel model)
        {
            SqlConnection connection = GetDBConnection();
            try
            {
                if (model != null)
                {
                    using (connection)
                    {
                        SqlCommand command = new SqlCommand("AddressBookProcedure", connection);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("stmnt", "Insert");
                        command.Parameters.AddWithValue("firstName", model.firstName);
                        command.Parameters.AddWithValue("lastName", model.lastName);
                        command.Parameters.AddWithValue("address", model.address);
                        command.Parameters.AddWithValue("city", model.city);
                        command.Parameters.AddWithValue("state", model.state);
                        command.Parameters.AddWithValue("zip", model.zip);
                        command.Parameters.AddWithValue("mobileNo", model.mobileNo);
                        command.Parameters.AddWithValue("email", model.email);
                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine("Data Inserted Successfully");
                    }
                }
                else
                {
                    Console.WriteLine("Data Not Inserted ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public override void Update(AddressBookModel model, String position)
        {
            SqlConnection connection = GetDBConnection();
            try
            {
                if (model != null)
                {
                    using (connection)
                    {
                        SqlCommand command = new SqlCommand("AddressBookProcedure", connection);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("stmnt", "Update");
                        command.Parameters.AddWithValue("position", position);
                        command.Parameters.AddWithValue("firstName", model.firstName);
                        command.Parameters.AddWithValue("lastName", model.lastName);
                        command.Parameters.AddWithValue("address", model.address);
                        command.Parameters.AddWithValue("city", model.city);
                        command.Parameters.AddWithValue("state", model.state);
                        command.Parameters.AddWithValue("zip", model.zip);
                        command.Parameters.AddWithValue("mobileNo", model.mobileNo);
                        command.Parameters.AddWithValue("email", model.email);

                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine("Data Update Successfully");
                    }
                }
                else
                {
                    Console.WriteLine("Data Not Inserted ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public override void Delete(string position)
        {
            SqlConnection connection = GetDBConnection();
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand("AddressBookProcedure", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("stmnt", "Delete");
                    command.Parameters.AddWithValue("position", position);
                    connection.Open();
                    Console.WriteLine("Data Delete Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public override void SelectByCityORState(String location)
        {
            SqlConnection connection = GetDBConnection();
            try
            {
                using (connection)
                {
                    AddressBookModel model = new AddressBookModel();
                    SqlCommand command = new SqlCommand("AddressBookProcedure", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("city", location);
                    command.Parameters.AddWithValue("state", location);
                    command.Parameters.AddWithValue("stmnt", "Select");
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int n = reader.GetInt32(0);
                            model.firstName = reader[1].ToString();
                            model.lastName = reader[2].ToString();
                            model.address = reader[3].ToString();
                            model.city = reader[4].ToString();
                            model.state = reader[5].ToString();
                            model.zip = reader[6].ToString();
                            model.mobileNo = reader[7].ToString();
                            model.email = reader[8].ToString();

                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Data Found..");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public override void SelectCountByCountryORState()
        {
            SqlConnection connection = GetDBConnection();
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand("AddressBookProcedure", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("stmnt", "count");
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["city"]+ "\t"+reader["citycount"] );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
