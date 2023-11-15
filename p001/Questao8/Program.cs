using System;
public class Program
{
    public static void Main(string[] args)
    {
        int num1 = 7, num2 = 3, num3 = 10;
        if(num1 > num2)
            Console.WriteLine (num1 + " e maior que " + num2);
        else
            Console.WriteLine (num1 + " e menor que " + num2);
        
        if(num3 == (num1 + num2))
            Console.WriteLine (num3 + " e igual a soma de " + num1 + " com " + num2);
        else
            Console.WriteLine (num3 + " e diferente da soma de " + num1 + " com " + num2);
    }
}