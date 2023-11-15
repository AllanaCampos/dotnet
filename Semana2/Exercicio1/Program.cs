#region ex1

string d = "25/10/2023";
DateTime date = new DateTime();
date = DateTime.Parse(d);
Console.WriteLine($"Dia: {date.Day}\tMês: {date.Month}\tAno: {date.Year}");

List<int> list = new List<int>();
for (int i = 1; i < 11; i++){
    list.Add(i);
}

foreach (int i in list){
    if(i % 2 == 0){
        Console.WriteLine(i);
    }
}

List<string> city = new List<string>() {"Mutuípe", "Jiquiriçá", "Ubaíra", "Santo Antônio de Jesus", "Laje", "Salvador"};
city.Add("Ilhéus");
city.Add("Itabuna");
list<string> city2 = city.Where()
Console.WriteLine("");
#endregion

