using System.Reflection;

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
        Paciente paciente = new Paciente(nome, cpf, nascimento, sexo, sintomas);
        pacientes.Add(paciente);

    }

    public static void addMedico(List<Medico>medicos){
        string nome, cpf, crm;
        DateTime nascimento;
        Console.WriteLine("Informe o nome do medico");
        nome = Console.ReadLine();
        Console.WriteLine("Infome o CPF do medico");
        cpf = Console.ReadLine();
        if(medicos.Exists(m => m.CPF == cpf)){
            throw new Exception("CPF já existe");
        }
        Console.WriteLine("Infome o CRM do medico");
        crm = Console.ReadLine();
        if(medicos.Exists(m => m.CRM == crm)){
            throw new Exception("CRM já existe");
        }
        Console.WriteLine("Infome a data de aniversario do médico");
        nascimento = DateTime.Parse(Console.ReadLine());
        
        Medico medico = new Medico(nome, cpf, crm, nascimento);
        medicos.Add(medico);

    }

}
