namespace FactoryMethodPattern
{
    public class PdfFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new PdfDocument();
        }
    }
}
