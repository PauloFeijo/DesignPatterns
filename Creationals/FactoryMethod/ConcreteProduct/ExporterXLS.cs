using FactoryMethod.Product;
using System;
using System.Threading.Tasks;

namespace FactoryMethod.ConcreteProduct
{
    public class ExporterXLS : IExportable
    {
        public async Task Export()
        {
            Console.WriteLine("Exporting XLS...");
            await Task.Delay(1000);
        }
    }
}
