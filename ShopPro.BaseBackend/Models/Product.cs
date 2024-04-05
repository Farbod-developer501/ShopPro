using ShopPro.BaseBackend.Contracts;

using System.Globalization;


namespace ShopPro.BaseBackend.Models;

public class Product : IBaseEntity<int>
{
    //public Product() 
    //{
    //    EntryDate = DateTime.Now;
    //    IsActive = true;
    //}
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specificaion { get; set; } // infromation
    public byte[] Image { get; set; }
    public decimal Price { get; set; }
    public string Brand { get; set; }
    public short Count { get; set; }
    // One-to-many relationship with Category
    public DateTime EntryDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public bool IsActive { get; set; }
    public string PersionDate
    {
        get
        {
            string persionD = EntryDate.ToString("yyyy/mm/dd", new CultureInfo("fa-IR"));
            return persionD;
        }
    }
}
