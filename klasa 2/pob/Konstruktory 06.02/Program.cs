class Program
{
    static void Main(string[] args)
    {
        Example example = new Example("Hello World");
        example.PrintMessage(example.Message);
    }
}

//Przykład
class Example
{
    public string Message { get; set; }
    
    //przykład konstruktora
    public Example(string message)
    {
        Message = message;
    }
    
    //przykład metody
   public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}
