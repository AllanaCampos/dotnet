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
}
