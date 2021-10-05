using FactoryMethod.ConcreteCreator;
using FactoryMethod.Product;
using FactoryMethod.Type;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var txt = new ExporterCreator(FileType.TXT).Create();
            var pdf = new ExporterCreator(FileType.PDF).Create();
            var xls = new ExporterCreator(FileType.XLS).Create();

            Export(txt);
            Export(pdf);
            Export(xls);

            foreach (var type in Enum.GetValues(typeof(FileType)))
            {
                var exportable = new ExporterCreator((FileType)type).Create();
                exportable.Export();
            }
        }

        static void Export(IExportable exporter)
        {
            exporter.Export();
        }
    }
}
