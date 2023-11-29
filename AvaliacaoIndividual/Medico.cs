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
    

}
