#region List Example
List<int> numbers  = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3); 
numbers.Add(4);
numbers.Add(5);

Console.WriteLine("List of numbers: ");
foreach (int number in numbers){
    Console.WriteLine(number);
}
Console.WriteLine($"Tamanho, {numbers.Count}");
Console.WriteLine($"Contem 3: {numbers.Contains(3)}");

List<string> names = new List<string>();
names.Add("Alice");
names.Add("Bob");
names.Add("Dave");
names.Add("Eeve");

Console.WriteLine("List of strings:");
foreach(string name in names){
    Console.WriteLine(name);
}

List<List<string>> values = new List<List<string>>();
values.Add(new List<string>() {"Alberto", "Allana", "Álvaro"});
values.Add(new List<string>() {"Bianca", "Bruno"});
values.Add(new List<string>() {"Carlos"});

Console.WriteLine("List of List of strings:");
foreach(List<string> list in values){
    foreach(string nome in list){
        Console.WriteLine(nome);
    }
}

#endregion
