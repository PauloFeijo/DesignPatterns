using FactoryMethod.Product;
using System;
using System.Threading.Tasks;

namespace FactoryMethod.ConcreteProduct
{
    public class ExporterTXT : IExportable
    {
        public async Task Export()
        {
            Console.WriteLine("Exporting TXT...");
            await Task.Delay(1000);
        }
    }
}
