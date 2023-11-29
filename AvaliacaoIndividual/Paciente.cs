namespace Namespace;
public class Paciente : Pessoa
{
    private string _sexo;
    public string Sexo{
        get{
            return this._sexo;
        }
        set{
            if(value != "FEMININO" && value != "MASCULINO"){
                throw new Exception("Valor inválido");
            }
            else{
                this._sexo = value;
            }
        }
    }
    public string Sintomas {get; set;}
    public static void addPaciente(List<Paciente>pacientes){
        Paciente paciente = new Paciente();
        string nome, cpf, sexo, sintomas;
        DateTime nascimento;
        Console.WriteLine("Informe o nome do paciente");
        nome = Console.ReadLine() ?? "";
        paciente.Nome = nome;
        Console.WriteLine("Infome o CPF do paciente");
        cpf = Console.ReadLine()?? "";
        if(pacientes.Exists(p => p.CPF == cpf)){
            throw new Exception("CPF já existe");
        }
        else{
            paciente.CPF = cpf;
        }
        Console.WriteLine("Infome a data de aniversario do paciente");
        nascimento = DateTime.Parse(Console.ReadLine()?? "01/01/2001");
        paciente.dataNascimento = nascimento;
        Console.WriteLine("Informe o sexo do paciente: (Feminino / Masculino)");
        sexo = (Console.ReadLine() ?? "Feminino").ToUpper();
        paciente.Sexo = sexo;
        Console.WriteLine("Informe os sintomas do paciente");
        sintomas = Console.ReadLine() ?? "";
        paciente.Sintomas = sintomas;
        pacientes.Add(paciente);

    }
}
