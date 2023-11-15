using System;
public class Program
{
    public static void Main(string[] args)
    {
        for(var i = 0; i < 30; i++){
            if((i % 3 == 0) || (i % 4 == 0)){
                Console.WriteLine(i);
            }
        }
    }
}