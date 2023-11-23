#region expressoes lambda
Func<int, int, int> sum = (x, y) => x + y;
int a = sum(5,4);
int b = sum(a,8);
Console.WriteLine($"{a} {b}");
#endregion