using ShopPro.BaseBackend.Contracts;
using System.Diagnostics;

namespace ShopPro.BaseBackend.Models;
[DebuggerDisplay("")]
public class Address : IBaseEntity<int>
{
    public int Id { get; set; }
    public string Country { get; set; }
    public string CountryCode { get; set; }
    public short PostalCode { get; set; }
    public string City { get; set; }
    public string State { get; set; }   
    public string Description { get; set; }
    public string Street { get; set; }
    public short StreetLine { get; set; }
    public int CustomerId { get; set; }
    public DateTime EntryDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public bool IsActive { get; set; }
    public string FullAddress 
    {
        get 
            {
            return $"The {Country}  and{CountryCode} and postal code {PostalCode} and {City} and {State}" +
                $"{Street} and {StreetLine} are these FullAddress.";
            } 
    }
}
