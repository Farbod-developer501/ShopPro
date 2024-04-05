using ShopPro.BaseBackend.Contracts;
using ShopPro.BaseBackend.Models;
using System.Data.SqlClient;
using System.Configuration;
using ShopPro.BaseBackend.Enums;
using System.Data;

namespace ShopPro.BaseBackend.Repositories;

public class CustomerRepository : IBaseGenericRepository<Customer>
{
    private readonly string connection = ConfigurationManager.ConnectionStrings["ShopPro"].ConnectionString;
    static string tableName = "dbo.Customer";
    public bool Delete(int id)
    {
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();
                string StoredProcedureName = $"DeleteCustomerRecord";
                SqlCommand cmd = new SqlCommand(StoredProcedureName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                int rowAffected = cmd.ExecuteNonQuery();
                return rowAffected > 0;
            }
            catch (SqlException ex) when (ex.Number == 547) //
            {
                Console.WriteLine("Foreign key constraint violation occurred.");
                throw; // 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The error is {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
    public List<Customer> GetAll()
    {
        List<Customer> customers = new List<Customer>();
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAllCustomers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Customer customer = new Customer()
                        {
                            Id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Birthdate = (DateTime)reader["Birthdate"],
                            GenderId = (GenderEnum)Enum.Parse(typeof(GenderEnum), reader["GenderId"].ToString()),
                            UserName = reader["UserName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            EntryDate = (DateTime)reader["EntryDate"],
                            IsActive = (bool)reader["IsActive"],
                            IsAdmin = (bool)reader["IsAdmin"]
                        };
                        customers.Add(customer);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The Error Is {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return customers;
        }
    }
    public Customer GetById(object id)
    {
        Customer customer = null;
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetCustomerById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        customer = new Customer
                        {
                            Id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Birthdate = (DateTime)reader["Birthdate"],
                            GenderId = (GenderEnum)Enum.Parse(typeof(GenderEnum), reader["GenderId"].ToString()),
                            UserName = reader["UserName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            EntryDate = (DateTime)reader["EntryDate"],
                            IsActive = (bool)reader["IsActive"],
                            IsAdmin = (bool)reader["IsAdmin"]
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return customer;
        }
    }

    public bool Insert(Customer item)
    {
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("InsertCustomer", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", item.Name);
                    cmd.Parameters.AddWithValue("@LastName", item.LastName);
                    cmd.Parameters.AddWithValue("@Birthdate", item.Birthdate);
                    cmd.Parameters.AddWithValue("@GenderId", item.GenderId);
                    cmd.Parameters.AddWithValue("@UserName", item.UserName);
                    cmd.Parameters.AddWithValue("@Email", item.Email);
                    cmd.Parameters.AddWithValue("@Password", item.Password);
                    cmd.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
                    cmd.Parameters.AddWithValue("@IsAdmin", item.IsAdmin);
                    cmd.Parameters.AddWithValue("@IsActive", item.IsActive);

                    int rowAffected = cmd.ExecuteNonQuery();
                    return rowAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The Error Is {ex.Message}");
                return false;
            }
        }
    }
    public bool Update(Customer item)
    {
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@Name", item.Name);
                cmd.Parameters.AddWithValue("@LastName", item.LastName);
                cmd.Parameters.AddWithValue("@UserName", item.UserName);
                cmd.Parameters.AddWithValue("@GenderId", item.GenderId);
                cmd.Parameters.AddWithValue("@Birthdate", item.Birthdate);
                cmd.Parameters.AddWithValue("@Email", item.Email);
                cmd.Parameters.AddWithValue("@Password", item.Password);
                cmd.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
                cmd.Parameters.AddWithValue("@IsAdmin", item.IsAdmin);
                cmd.Parameters.AddWithValue("@IsActive", item.IsActive);

                int RowAffected = cmd.ExecuteNonQuery();
                return RowAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The error is {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
