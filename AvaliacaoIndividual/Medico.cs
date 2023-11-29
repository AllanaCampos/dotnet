namespace Namespace;
public class Medico
{
    public string Nome{get; set;}
    public DateTime dataNascimento{get; set;}
    private string _cpf;
    public string CPF{
        get{
            return this._cpf;
        } 
        set{
            if(value.Length != 11){
                throw new Exception("CPF possui apenas com 11 dígitos");
            }
            else{
                this._cpf = value;
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
