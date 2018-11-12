using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class ConfigReader : IConfigReader
    {
        public string AllowedFileType => ConfigurationManager.AppSettings["AllowedFileType"];
        public string Delimiter => ConfigurationManager.AppSettings["Delimiter"];
        public string SortedFileName => ConfigurationManager.AppSettings["SortedFileName"];
    }
}
