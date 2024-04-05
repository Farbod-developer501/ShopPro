using ShopPro.BaseBackend.Contracts;
using ShopPro.BaseBackend.Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ShopPro.BaseBackend.Repositories;

public class AddressRepository : IBaseGenericRepository<Address>
{
    private readonly string connection = ConfigurationManager.ConnectionStrings["ShopPro"].ConnectionString;
    static string tableName = "dbo.Address";
  
    public bool Delete(int id)
    {
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();
                string StoredProcedureName = $"DeleteAddressRecord";
                SqlCommand cmd = new SqlCommand(StoredProcedureName, con);
                cmd.CommandType =  CommandType.StoredProcedure;
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

    public List<Address> GetAll()
    {
        List<Address> addresses = new List<Address>();
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAllAddresses", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Address address = new Address()
                        {
                            Id = (int)reader["Id"],
                            Country = reader["Country"].ToString(),
                            CountryCode = reader["CountryCode"].ToString(),
                            PostalCode = (short)reader["PostalCode"],
                            City = reader["City"].ToString(),
                            State = reader["State"].ToString(),
                            Description = reader["Description"].ToString(),
                            Street = reader["Street"].ToString(),
                            StreetLine = (short)reader["StreetLine"],
                            CustomerId = (int)reader["CustomerId"],
                            EntryDate = (DateTime)reader["EntryDate"],
                            IsActive = (bool)reader["IsActive"],
                        };
                        addresses.Add(address);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The Error is {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return addresses;
        }
    }


    public Address GetById(object id)
    {
        Address address = null;
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAddressById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        address = new Address
                        {
                            Id = (int)reader["Id"],
                            Country = reader["Country"].ToString(),
                            CountryCode = reader["CountryCode"].ToString(),
                            PostalCode = (short)reader["PostalCode"],
                            City = reader["City"].ToString(),
                            State = reader["State"].ToString(),
                            Description = reader["Description"].ToString(),
                            Street = reader["Street"].ToString(),
                            StreetLine = (short)reader["StreetLine"],
                            CustomerId = (int)reader["CustomerId"],
                            EntryDate = (DateTime)reader["EntryDate"],
                            IsActive = (bool)reader["IsActive"],
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
            return address;
        }
    }

    public bool Insert(Address item)
    {
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("InsertAddress", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Country", item.Country);
                    cmd.Parameters.AddWithValue("@CountryCode", item.CountryCode);
                    cmd.Parameters.AddWithValue("@PostalCode", item.PostalCode);
                    cmd.Parameters.AddWithValue("@City", item.City);
                    cmd.Parameters.AddWithValue("@State", item.State);
                    cmd.Parameters.AddWithValue("@Description", item.Description);
                    cmd.Parameters.AddWithValue("@Street", item.Street);
                    cmd.Parameters.AddWithValue("@StreetLine", item.StreetLine);
                    cmd.Parameters.AddWithValue("@CustomerId", item.CustomerId);
                    cmd.Parameters.AddWithValue("@IsActive", item.IsActive);

                    int rowAffected = cmd.ExecuteNonQuery();
                    return rowAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The Error Is {ex.Message} ");
                return false;
            }
        }
    }

    public bool Update(Address item)
    {
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UpdateAddress", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Country", item.Country);
                    cmd.Parameters.AddWithValue("@CountryCode", item.CountryCode);
                    cmd.Parameters.AddWithValue("@PostalCode", item.PostalCode);
                    cmd.Parameters.AddWithValue("@City", item.City);
                    cmd.Parameters.AddWithValue("@State", item.State);
                    cmd.Parameters.AddWithValue("@Description", item.Description);
                    cmd.Parameters.AddWithValue("@Street", item.Street);
                    cmd.Parameters.AddWithValue("@StreetLine", item.StreetLine);
                    cmd.Parameters.AddWithValue("@CustomerId", item.CustomerId);
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
}
