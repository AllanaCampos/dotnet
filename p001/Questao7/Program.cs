using System;
public class Program
{
    public static void Main(string[] args)
    {
        bool condicao1  = true, condicao2 = false;
        if(condicao1 == condicao2 == true)
            Console.WriteLine ("Ambas as condicoes sao verdadeiras");
        else
            Console.WriteLine ("Pelo menos uma condicao e falsa");
        
    }
}