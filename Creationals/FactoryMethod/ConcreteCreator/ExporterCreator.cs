using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;
using FactoryMethod.Type;
using System;

namespace FactoryMethod.ConcreteCreator
{
    public class ExporterCreator : IExporterCreator
    {
        private readonly FileType _fileType;

        public ExporterCreator(FileType fileType)
        {
            _fileType = fileType;
        }

        public IExportable Create()
        {
            if (_fileType == FileType.TXT)
            {
                return new ExporterTXT();
            }
            if (_fileType == FileType.PDF)
            {
                return new ExporterPDF();
            }
            if (_fileType == FileType.XLS)
            {
                return new ExporterXLS();
            }
            throw new Exception("Invalid FileType");
        }
    }
}
