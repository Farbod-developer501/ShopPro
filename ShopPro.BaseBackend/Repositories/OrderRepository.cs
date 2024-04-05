using ShopPro.BaseBackend.Contracts;
using ShopPro.BaseBackend.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace ShopPro.BaseBackend.Repositories;

public class OrderRepository : IBaseGenericRepository<Order>
{
    private readonly string connection = ConfigurationManager.ConnectionStrings["ShopPro"].ConnectionString;
    static string tableName = "[dbo].[Order]";
    public bool Delete(int id)
    {
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                int RowAffected = cmd.ExecuteNonQuery();
                return RowAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The Error is {ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
    public List<Order> GetAll()
    {
        List<Order> orders = new List<Order>();
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("GetAllOrders", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Order order = new Order()
                    {
                        Id = (int)reader["Id"],
                        OrderCode = reader["OrderCode"].ToString(),
                        Date = (DateTime)reader["Date"],
                        AddressDescription = reader["AddressDescription"].ToString(),
                        OrderDescription = reader["OrderDescription"].ToString(),
                        CustomerId = (int)reader["CustomerId"],
                        AddressId = (int)reader["AddressId"],
                        ProductId = (int)reader["ProductId"],
                        EntryDate = (DateTime)reader["EntryDate"],
                        UpdateDate = (DateTime)reader["UpdateDate"],
                        IsActive = (bool)reader["IsActive"],
                    };
                    orders.Add(order);
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
            return orders;
        }
    }
    public Order GetById(object id)
    {
        Order order = null;
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("GetOrderById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    order = new Order
                    {
                        Id = (int)reader["Id"],
                        OrderCode = reader["OrderCode"].ToString(),
                        Date = (DateTime)reader["Date"],
                        AddressDescription = reader["AddressDescription"].ToString(),
                        OrderDescription = reader["OrderDescription"].ToString(),
                        CustomerId = (int)reader["CustomerId"],
                        AddressId = (int)reader["AddressId"],
                        ProductId = (int)reader["ProductId"],
                        EntryDate = (DateTime)reader["EntryDate"],
                        UpdateDate = (DateTime)reader["UpdateDate"],
                        IsActive = (bool)reader["IsActive"],
                    };
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
            return order;
        }
    }
    public bool Insert(Order item)
    {
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@OrderCode", item.OrderCode);
                cmd.Parameters.AddWithValue("@Date", item.Date);
                cmd.Parameters.AddWithValue("@AddressDescription", item.AddressDescription);
                cmd.Parameters.AddWithValue("@OrderDescription", item.OrderDescription);
                cmd.Parameters.AddWithValue("@CustomerId", item.CustomerId);
                cmd.Parameters.AddWithValue("@AddressId", item.AddressId);
                cmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                cmd.Parameters.AddWithValue("@IsActive", item.IsActive);

                int rowAffected = cmd.ExecuteNonQuery();
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
    public bool Update(Order item)
    {
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@AddressDescription", item.AddressDescription);
                cmd.Parameters.AddWithValue("@OrderDescription", item.OrderDescription);
                cmd.Parameters.AddWithValue("@CustomerId", item.CustomerId);
                cmd.Parameters.AddWithValue("@AddressId", item.AddressId);
                cmd.Parameters.AddWithValue("@ProductId", item.ProductId);
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
