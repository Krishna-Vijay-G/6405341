package FactoryMethodPattern;

public class Word_Factory extends Document_Factory {
    public Document createDocument() {
        return new Word_Document();
    }
}
