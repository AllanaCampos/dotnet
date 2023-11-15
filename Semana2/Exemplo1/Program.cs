using System;
public class Program
{
    public static void Main(string[] args)
    {
        string[] colecao = {"Item1", "Item2", "Item3", "Item4"};

        foreach(string item in colecao){
            Console.WriteLine(item);
        }

        string? ex = Console.ReadLine();
        Console.WriteLine(ex);
    }
}