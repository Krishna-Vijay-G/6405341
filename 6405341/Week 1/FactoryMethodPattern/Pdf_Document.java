package FactoryMethodPattern;

public class Pdf_Document implements Document {
    public void open() {
        System.out.println("Opening PDF Document.");
    }
}

