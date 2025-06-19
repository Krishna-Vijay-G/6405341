using System;

namespace FactoryMethodPattern
{
    class Test_Factory_Method
    {
        static void Main(string[] args)
        {
            DocumentFactory pdfFactory = new PdfFactory();
            Document pdfDoc = pdfFactory.CreateDocument();
            pdfDoc.Open();

            DocumentFactory wordFactory = new WordFactory();
            Document wordDoc = wordFactory.CreateDocument();
            wordDoc.Open();

            DocumentFactory excelFactory = new ExcelFactory();
            Document excelDoc = excelFactory.CreateDocument();
            excelDoc.Open();

            Console.WriteLine("\nDone by Superset ID: 6405341\n");
        }
    }
}
