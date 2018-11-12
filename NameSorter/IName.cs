namespace NameSorter
{
    public interface IName
    {
        string GivenName { get; set; }
        string LastName { get; set; }

        string ToString();
    }
}