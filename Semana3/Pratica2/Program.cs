#region trycatch
try{
    int a = Divide(2, 0);
}
catch (DivideByZeroException e){
    Console.WriteLine(e.Message);
}

int Divide(int a, int b){
    if(b == 0){
        throw new DivideByZeroException("Divisao por zero");
    }
    return a / b;

}
#endregion