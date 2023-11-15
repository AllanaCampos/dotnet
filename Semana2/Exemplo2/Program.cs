using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Write yout name: ");
        string? name = Console.ReadLine();
        Console.WriteLine(string.IsNullOrWhiteSpace(name));
        Console.WriteLine($"Hello, {name.ToUpper()}!");
        Console.WriteLine($"Size: {name.Length}");
        string[] nameSplitted = name.Split(' ');
        foreach (string part in nameSplitted){
            Console.WriteLine(part);
        }
        
    }
}