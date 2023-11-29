namespace Namespace;
public class Paciente
{
    public string Nome{get;set;}
    public DateTime dataNascimento{get; set;}
    public string CPF{
        get{
            return CPF;
        } 
        set{
            if(value.Length != 11){
                throw new Exception("CPF possui apenas com 11 dígitos");
            }
            else{
                this.CPF = value;
            }
        }
    }
    public string Sexo{
        get{
            return this.Sexo;
        }
        set{
            if(value != "Feminino" && value != "Masculino"){
                throw new Exception("Valor inválido");
            }
            else{
                this.Sexo = value;
            }
        }
    }
    public string Sintomas {get; set;}
    public int getIdade(){
        int idade =  DateTime.Now.Year - dataNascimento.Year;
        if(dataNascimento.Month < DateTime.Now.Month)
            idade--;
        else if( dataNascimento.Month == DateTime.Now.Month){
            if(dataNascimento.Day < DateTime.Now.Day)
                idade--;
        }
        return idade;
    }
    public Paciente(string nome, string cpf, DateTime nascimento, string sexo, string sintomas){
        this.Nome = nome;
        this.CPF = cpf;
        this.dataNascimento = nascimento;
        this.Sintomas = sintomas;
        this.Sexo = sexo;
    }

    public static void addPaciente(List<Paciente>pacientes){
        string nome, cpf, sexo, sintomas;
        DateTime nascimento;
        Console.WriteLine("Informe o nome do paciente");
        nome = Console.ReadLine() ?? "";
        Console.WriteLine("Infome o CPF do paciente");
        cpf = Console.ReadLine()?? "";
        if(pacientes.Exists(p => p.CPF == cpf)){
            throw new Exception("CPF já existe");
        }
        Console.WriteLine("Infome a data de aniversario do paciente");
        nascimento = DateTime.Parse(Console.ReadLine()?? "01/01/2001");
        Console.WriteLine("Informe o sexo do paciente: (Feminino / Masculino)");
        sexo = (Console.ReadLine() ?? "Feminino").ToUpper();
        Console.WriteLine("Informe os sintomas do paciente");
        sintomas = Console.ReadLine() ?? "";
        Paciente paciente = new Paciente(nome, cpf, nascimento, sexo, sintomas);
        pacientes.Add(paciente);

    }
}
