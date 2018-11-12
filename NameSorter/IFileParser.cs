using System.Collections.Generic;

namespace NameSorter
{
    public interface INameFileParser
    {
        IList<IName> RetrieveNamesList(IList<string> fileData);
    }
}