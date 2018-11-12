using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NamesFileReader : IFileReader
    {
        private readonly IConfigReader _configReader;
        private readonly IValidator _validator;
        private string _filePath = string.Empty;

        public NamesFileReader(IConfigReader configReader, IValidator validator)
        {
            _configReader = configReader;
            _validator = validator;

        }
        public FileOutput ReadFileData(string filePath)
        {
            _validator.ValidateFileExtension(filePath, _configReader.AllowedFileType);
            _validator.ValidateFileExistence(filePath);

            _filePath = filePath;

            return new FileOutput { DataRows = ReadFileContent()};

            throw new NotImplementedException();
        }

        private IList<string> ReadFileContent()
        {
            List<string> dataRows = new List<string>();

            using (var reader = new StreamReader(_filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    dataRows.Add(line);
                }
            }

            return dataRows;
        }
    }
}
