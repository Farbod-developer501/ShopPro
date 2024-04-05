using ShopPro.BaseBackend.Contracts;
using ShopPro.BaseBackend.Enums;


namespace ShopPro.BaseBackend.Models;

public class User : IBaseEntity<int>
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime Birthdate { get; set; }
    public GenderEnum GenderId { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsAdmin { get; set; }
    public int AddressId { get; set; }
    public DateTime EntryDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public bool IsActive { get; set; }
}
