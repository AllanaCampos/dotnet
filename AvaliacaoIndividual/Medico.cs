namespace Namespace;
public class Medico : Pessoa
{
    public string CRM{get; set;}
    public static void addMedico(List<Medico>medicos){
        Medico medico = new Medico();
        string nome, cpf, crm;
        DateTime nascimento;
        Console.WriteLine("Informe o nome do medico");
        nome = Console.ReadLine() ?? "";
        medico.Nome = nome;
        Console.WriteLine("Infome o CPF do medico");
        cpf = Console.ReadLine()?? "";
        if(medicos.Exists(m => m.CPF == cpf)){
            throw new Exception("CPF já existe");
        }
        else{
            medico.CPF = cpf;
        }
        Console.WriteLine("Infome o CRM do medico");
        crm = Console.ReadLine() ?? "";
        if(medicos.Exists(m => m.CRM == crm)){
            throw new Exception("CRM já existe");
        }
        else{
            medico.CRM = crm;
        }
        Console.WriteLine("Infome a data de nascimento do médico");
        nascimento = DateTime.Parse(Console.ReadLine() ?? "01/01/2001");
        medico.dataNascimento = nascimento;
        medicos.Add(medico);

    }
}
