namespace Namespace;
public class Relatorios
{
    public static void medicosIdades(List<Medico> medicos){
        Console.WriteLine("Informe a idade mínima do intervalo que deseja observar");
        int idadeMin = Int32.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Informe a idade máxima do intervalo que deseja observar");
        int idadeMax = Int32.Parse(Console.ReadLine() ?? "100");
        var idadesEntre = medicos.Where(m => m.getIdade() > idadeMin && m.getIdade() < idadeMax).ToList();
        foreach ( var medico in idadesEntre){
            Console.WriteLine($"Nome: {medico.Nome} CPF: {medico.CPF} CRM: {medico.CRM} Idade: {medico.getIdade()}");
        }   
    }
}
