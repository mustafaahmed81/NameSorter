using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NameFileParser : INameFileParser
    {
        private readonly IConfigReader _configReader;
        private readonly IValidator _validator;

        public NameFileParser(IConfigReader configReader, IValidator validator)
        {
            _configReader = configReader;
            _validator = validator;
        }
        public IList<IName> RetrieveNamesList(IList<string> fileData)
        {
            _validator.ValidateIfEmptyFile(fileData);
            
            var names = new List<IName>();

            foreach (var dataRow in fileData)
            {
                if(!_validator.ValidateDataRow(dataRow, _configReader.Delimiter))
                    continue;

                var name = new Name
                {
                    GivenName = RetrieveGivenName(dataRow),
                    LastName = RetrieveLastName(dataRow)
                };
                names.Add(name);
            }

            return names;
        }

        private string RetrieveLastName(string dataRow)
        {
            int indexOfDelimiter = dataRow.LastIndexOf(_configReader.Delimiter, StringComparison.Ordinal);
            return dataRow.Substring(indexOfDelimiter+1);
        }

        private string RetrieveGivenName(string dataRow)
        {
            int indexOfDelimiter = dataRow.LastIndexOf(_configReader.Delimiter, StringComparison.Ordinal);
            return dataRow.Substring(0,indexOfDelimiter);
        }
    }
}
