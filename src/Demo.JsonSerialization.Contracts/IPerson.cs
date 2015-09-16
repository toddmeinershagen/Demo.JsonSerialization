namespace Demo.JsonSerialization.Contracts
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAddress Address { get; set; }
    }
}
