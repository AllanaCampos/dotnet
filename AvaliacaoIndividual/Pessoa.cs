namespace Namespace;
public class Pessoa
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
    
}
