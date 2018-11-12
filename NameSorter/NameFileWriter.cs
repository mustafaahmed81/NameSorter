using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NameFileWriter : IFileWriter
    {
        private readonly IConfigReader _configReader;

        public NameFileWriter(IConfigReader configReader)
        {
            _configReader = configReader;
        }

        public void WriteFileData(IList<IName> fileContent)
        {
            using (var writer = new StreamWriter(_configReader.SortedFileName, false))
            {
                foreach (var name in fileContent)
                {
                    writer.WriteLine(name.ToString());
                }
            }
        }
    }
}
