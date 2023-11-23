using System.Collections;

int[] lista = {1, 2, 3, 4, 5, 6};

var par = lista.Where(x  => x % 2 == 0).ToList();
par.Order();
Console.WriteLine($"Lista de pares: {string.Join(", ", par)}");