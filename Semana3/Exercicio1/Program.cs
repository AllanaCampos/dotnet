#region tuplas
(string, int) Person(string name, DateTime birthDate){
    int age = DateTime.Today.Year - birthDate.Year;
    if(DateTime.Today.DayOfYear < birthDate.DayOfYear)
        age--;
    Console.WriteLine("Age: " + age);
    return (name, age);
}
var tupla = Person("Allana", new DateTime(1999, 3, 10));
#endregion