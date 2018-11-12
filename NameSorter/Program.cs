using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace NameSorter
{
    public class Program
    {
        private static IContainer Container { get; set; }

        [STAThread]
        static void Main(string[] args)
        {
            Container = DependencyInjectionRegistry.Register();

            string filePath = string.Empty;
            if (args.Length > 0)
            {
                filePath = Convert.ToString(args[0]);
                Console.WriteLine("Input file is {0}",filePath);
            }

            using (var scope = Container.BeginLifetimeScope())
            {
                var fileReader = scope.Resolve<IFileReader>();
                var nameSorter = scope.Resolve<INameSorter>();
                var fileWriter = scope.Resolve<IFileWriter>();

                var fileOutput = fileReader.ReadFileData(filePath);
                var sortedList = nameSorter.SortByLastName(fileOutput);
                fileWriter.WriteFileData(sortedList);
            }
        }
    }
}
