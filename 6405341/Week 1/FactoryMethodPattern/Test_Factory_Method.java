package FactoryMethodPattern;

public class Test_Factory_Method {
    public static void main(String[] args) {
        Document_Factory pdfFactory = new Pdf_Factory();
        Document pdfDoc = pdfFactory.createDocument();
        pdfDoc.open();

        Document_Factory wordFactory = new Word_Factory();
        Document wordDoc = wordFactory.createDocument();
        wordDoc.open();

        Document_Factory excelFactory = new Excel_Factory();
        Document excelDoc = excelFactory.createDocument();
        excelDoc.open();

        System.out.println("\nDone by Superset ID: 6405341\n");
    }
}
