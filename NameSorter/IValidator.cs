using System.Collections.Generic;

namespace NameSorter
{
    public interface IValidator
    {
        bool ValidateDataRow(string dataRow, string delimiter);
        bool ValidateFileExistence(string fileName);
        bool ValidateFileExtension(string fileName, string allowedFileType);
        bool ValidateIfEmptyFile(IList<string> dataRows);
    }
}