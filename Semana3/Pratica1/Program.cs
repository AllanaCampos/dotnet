#region trycatch
try{
    Console.WriteLine("Digite um numero");
    int num = Int32.Parse(Console.ReadLine());
}
catch(Exception e){
    Console.WriteLine("Ocorreu um erro");
    Console.WriteLine(e.Message);
}

#endregion