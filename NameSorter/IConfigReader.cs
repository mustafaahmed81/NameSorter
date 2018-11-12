namespace NameSorter
{
    public interface IConfigReader
    {
        string AllowedFileType { get; }
        string Delimiter { get; }
        string SortedFileName { get; }
    }
}