#region Culture
using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");
#endregion

#region Exemplo
var tuple = (id: 1, name: "Allana", born: new DateTime(1999, 3, 10));
Console.WriteLine($"Tuple: {tuple.id}, {tuple.name}, {tuple.born}");

List<(int id, string name, DateTime born)> list = new();
list.Add(tuple);
list.Add((2, "Alexsandra", new DateTime(1997, 7, 12)));
list.ForEach(x => Console.WriteLine($"Tuple: {x.id}, {x.name}, {x.born.ToShortDateString()}"));
#endregion