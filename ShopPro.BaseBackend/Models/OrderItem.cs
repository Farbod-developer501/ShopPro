using ShopPro.BaseBackend.Contracts;

namespace ShopPro.BaseBackend.Models;

public class OrderItem : IBaseEntity<int>
{
    public int Id { get ; set; }
    public int ProductId { get; set; }
    public byte Quantity { get; set; }
    public decimal PurchasePrice { get; set; }
    public DateTime EntryDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public bool IsActive { get; set; }
}
