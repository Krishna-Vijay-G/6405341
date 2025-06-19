package FactoryMethodPattern;

public class Pdf_Factory extends Document_Factory {
    public Document createDocument() {
        return new Pdf_Document();
    }
}

