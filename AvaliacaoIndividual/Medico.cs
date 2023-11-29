namespace Namespace;
public class Medico
{
    public string Nome{get; set;}
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
    public string CRM{get; set;}

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
    
    public Medico(string nome, string cpf, string crm, DateTime nascimento){
        this.Nome = nome;
        this.CPF = cpf;
        this.CRM = crm;
        this.dataNascimento = nascimento;
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
