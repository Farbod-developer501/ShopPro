using ShopPro.BaseBackend.Contracts;
using ShopPro.BaseBackend.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace ShopPro.BaseBackend.Repositories;

public class ProductRepository : IBaseGenericRepository<Product>
{
    private readonly string connection = ConfigurationManager.ConnectionStrings["ShopPro"].ConnectionString;
    static string tableName = "dbo.Product";

    public bool Delete(int id)
    {
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();
                string StoredProcedureName = $"DeleteProduct";
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
    public List<Product> GetAll()
    {
        List<Product> products = new List<Product>();
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("GetAllProducts", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Specificaion = reader["Specificaion"].ToString(),
                        Image = (byte[])reader["Image"],
                        Price = (decimal)reader["Price"],
                        Brand = reader["Brand"].ToString(),
                        Count = short.Parse(reader["Count"].ToString()),
                        EntryDate = (DateTime)reader["EntryDate"],
                        UpdateDate = (DateTime)reader["UpdateDate"],
                        IsActive = (bool)reader["IsActive"],
                    };
                    products.Add(product);
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
            return products;
        }
    }
    public Product GetById(object id)
    {
        Product product = null;
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("GetProductById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    product = new Product
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Specificaion = reader["Specificaion"].ToString(),
                        Image = (byte[])reader["Image"],
                        Price = (decimal)reader["Price"],
                        Brand = reader["Brand"].ToString(),
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
            return product;
        }
    }
    public bool Insert(Product item)
    {
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", item.Name);
                cmd.Parameters.AddWithValue("@Specificaion", item.Specificaion);
                cmd.Parameters.AddWithValue("@Image", item.Image);
                cmd.Parameters.AddWithValue("@Price", item.Price);
                cmd.Parameters.AddWithValue("@Brand", item.Brand);
                cmd.Parameters.AddWithValue("@Count", item.Count);
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
    public bool Update(Product item)
    {
        using (SqlConnection con = new SqlConnection(connection))
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@Name", item.Name);
                cmd.Parameters.AddWithValue("@Specificaion", item.Specificaion);
                cmd.Parameters.AddWithValue("@Image", item.Image);
                cmd.Parameters.AddWithValue("@Price", item.Price);
                cmd.Parameters.AddWithValue("@Brand", item.Brand);
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
