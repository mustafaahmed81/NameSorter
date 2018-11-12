using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NameSorter : INameSorter
    {
        private readonly INameFileParser _nameFileParser;

        public NameSorter(INameFileParser nameFileParser)
        {
            _nameFileParser = nameFileParser;
        }
        public IList<IName> SortByLastName(FileOutput fileOutput)
        {
            var unsortedNames = _nameFileParser.RetrieveNamesList(fileOutput.DataRows);
            var sortedNames = GetSortedNamesByLastName(unsortedNames);

            return sortedNames;
        }

        private static List<IName> GetSortedNamesByLastName(IList<IName> unsortedNames)
        {
            return unsortedNames.OrderBy(name => name.LastName).ToList();
        }
    }
}
