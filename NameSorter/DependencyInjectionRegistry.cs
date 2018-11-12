using Autofac;

namespace NameSorter
{
    public class DependencyInjectionRegistry
    {
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConfigReader>().As<IConfigReader>();
            builder.RegisterType<NamesFileReader>().As<IFileReader>();
            builder.RegisterType<NameSorter>().As<INameSorter>();
            builder.RegisterType<NameFileParser>().As<INameFileParser>();
            builder.RegisterType<NameFileWriter>().As<IFileWriter>();
            builder.RegisterType<Validator>().As<IValidator>();
            builder.RegisterType<Name>().As<IName>();
            
            var container = builder.Build();
            return container;
        }
    }
}
