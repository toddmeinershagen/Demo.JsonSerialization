namespace Demo.JsonSerialization.Contracts
{
    public interface IAddress
    {
        string Line1 { get; set; }
        string Line2 { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
    }
}
