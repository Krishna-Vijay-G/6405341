namespace FactoryMethodPattern
{
    public class WordFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new WordDocument();
        }
    }
}
