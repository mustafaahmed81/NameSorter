using System.Collections.Generic;

namespace NameSorter
{
    public interface IFileWriter
    {
        void WriteFileData(IList<IName> fileContent);
    }
}