namespace Namespace;
public class ContaBancaria
{
    public double Saldo{
        get{
            return this.Saldo;
        }
        set{
            if(value > 0){
                this.Saldo = value;
            }
            else{
                throw new ArgumentException("Saldo não pode ser negativo");
            }
        }
    }
}
