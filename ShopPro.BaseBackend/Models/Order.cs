using ShopPro.BaseBackend.Contracts;

namespace ShopPro.BaseBackend.Models;

public class Order : IBaseEntity<int>
{
    public int Id { get; set; }
    public string OrderCode { get; set; }
    public DateTime Date { get; set; }
    public string AddressDescription { get; set; }
    public string OrderDescription { get; set; }
    public List<OrderItem> OrderItems { get; set;}
    // Many-to-one relationship with Customer
    public int CustomerId { get; set; }
    public int AddressId { get; set; }
    public int ProductId { get; set; }
    public DateTime EntryDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public bool IsActive { get; set; }
}
