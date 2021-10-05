using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public interface IExporterCreator
    {
        IExportable Create();
    }
}
