using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class Validator : IValidator
    {
        public bool ValidateFileExistence(string fileName)
        {
            if (File.Exists(fileName))
                return true;

            throw new FileNotFoundException(fileName + " does not exist.");
        }

        public bool ValidateFileExtension(string fileName, string allowedFileType)
        {
            if (Path.GetExtension(fileName) == allowedFileType)
                return true;

            throw new ApplicationException(fileName + " This file type is not accepted");
        }

        public bool ValidateIfEmptyFile(IList<string> dataRows)
        {
            if (dataRows.Count > 0)
                return true;

            throw new ApplicationException(" There is no data to sort.");
        }

        public bool ValidateDataRow(string dataRow, string delimiter)
        {
            List<string> dataRowValues = dataRow.Trim().Split(delimiter.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            if (dataRowValues.Count < 2)
                return false;

            return true;
        }
    }
}
