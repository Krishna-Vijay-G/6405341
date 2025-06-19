namespace FactoryMethodPattern
{
    public class ExcelFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}
