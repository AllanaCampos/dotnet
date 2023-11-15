using System;
public class Program
{
    public static void Main(string[] args)
    {
        double b = 24.55;
        int a  = Convert.ToInt32(b); //dado x.y, caso de y > 5 valor inteiro = x+1, caso contrario valor inteiro = x
        int c = (int) b; //dado x.y sempre seu valor em inteiro será x
        Console.WriteLine (a + " " + c);
    }
}