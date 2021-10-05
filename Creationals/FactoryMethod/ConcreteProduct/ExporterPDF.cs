using FactoryMethod.Product;
using System;
using System.Threading.Tasks;

namespace FactoryMethod.ConcreteProduct
{
    public class ExporterPDF : IExportable
    {
        public async Task Export()
        {
            Console.WriteLine("Exporting PDF...");
            await Task.Delay(1000);
        }
    }
}
