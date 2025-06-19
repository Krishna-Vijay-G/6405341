package FactoryMethodPattern;

public class Excel_Factory extends Document_Factory {
    public Document createDocument() {
        return new Excel_Document();
    }
}

