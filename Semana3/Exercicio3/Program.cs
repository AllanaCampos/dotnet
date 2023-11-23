List<(String, int)> pessoa = new List<(string, int)>();
pessoa.Add(("Allana", 24));
pessoa.Add(("Alexsandra", 26));
pessoa.Add(("Marineide", 51));
pessoa.Add(("Orlando", 59));
var maior30 = pessoa.Where(x => x.Item2 >= 30).ToList();
Console.WriteLine($"Lista de pessoas com mais que 30 anos: {string.Join(", ", maior30)}");
