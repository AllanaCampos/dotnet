using System;
public class Program
{
    public static int Fibonacci(int n){
        if ( n < 1){
            return 0;
        }
        if ( n == 2){
            return 1;
        }
        return Fibonacci(n - 2) + Fibonacci(n - 1);
    }
    public static void Main(string[] args)
    {
        int i = 1, fib = 0;
        while(fib < 100){
            fib = Program.Fibonacci(i);
            Console.WriteLine(fib);
            i++;
        }
    }
}