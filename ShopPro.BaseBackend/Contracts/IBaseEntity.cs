

namespace ShopPro.BaseBackend.Contracts;

public interface IBaseEntity<T>
{
    public T Id { get; set; }
    public DateTime EntryDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public bool IsActive { get; set; }

}
