#region lambda
string[] people = { "Allana", "Alexsandra", "Marineide", "Orlando"};
char letter = 'O';
Console.WriteLine($"People with name started with '{letter}': {string.Join(", ", people.Where(x => x.StartsWith(letter)))}");
Console.WriteLine($"People: {people.Single(x => x.Contains("a"))}");
#endregion