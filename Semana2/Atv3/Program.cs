using System;
public class Program
{
    public static void Main(string[] args)
    {
        for(int i = 1; i < 9; i++){
            for(int j = i; j <= i * i; j += i){
                Console.Write(j + "\t");
            }
            Console.WriteLine();
        }
    }
}