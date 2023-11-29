namespace Namespace;
public class App
{
    public static void addPaciente(List<Paciente>pacientes){
        string nome, cpf, sexo, sintomas;
        DateTime nascimento;
        Console.WriteLine("Informe o nome do paciente");
        nome = Console.ReadLine();
        Console.WriteLine("Infome o CPF do paciente");
        cpf = Console.ReadLine();
        if(pacientes.Exists(p => p.CPF == cpf)){
            throw new Exception("CPF já existe");
        }
        Console.WriteLine("Infome a data de aniversario do paciente");
        nascimento = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Informe o sexo do paciente");
        sexo = Console.ReadLine();
        Console.WriteLine("Informe os sintomas do paciente");
        sintomas = Console.ReadLine();
        //Paciente paciente = new Paciente();

    }

}
