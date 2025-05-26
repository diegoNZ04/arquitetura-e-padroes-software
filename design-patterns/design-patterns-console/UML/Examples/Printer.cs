namespace design_patterns_console.UML.Examples;

public class Printer
{
    public void Print(Document document)
    {
        Console.WriteLine($"Printing document: {document}");
    }
}

public class Document
{
    // código omitido
}
