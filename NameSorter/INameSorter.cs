using System.Collections.Generic;

namespace NameSorter
{
    public interface INameSorter
    {
        IList<IName> SortByLastName(FileOutput fileOutput);
    }
}