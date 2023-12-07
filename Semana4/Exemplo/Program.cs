#region heranca
using System.ComponentModel.DataAnnotations;

try
{
    ContaCorrente contaAllana = new ContaCorrente();
    contaAllana.setNumero(-100);
    ContaPoupanca contaExtra = new ContaPoupanca();
    contaExtra.setNumero(171);
    contaAllana.sacar(1000);
    contaExtra.sacar(1000);
}
catch(Exception e){
    Console.WriteLine(e.Message);
}

abstract class Conta{
    public int Numero{get; private set;}
    protected double saldo;

    public string NumeroDescricao => $"{this.Numero} - {this.Descricao}";

    public string Descricao{get; set;}

    public void setNumero(int numero) {
        if(numero > 0) {
            this.Numero = numero;
        }
        else{
            throw new Exception("Número inválido");
        }
    }
    public int getNumero() {
        return this.Numero;
    }

    public virtual double sacar(double valor){
        if(valor > 0 && valor <= this.saldo){
            this.saldo -= valor;
            return valor;
        }
        else{
            throw new Exception("Valor inválido");
        }
    }

}

class ContaCorrente : Conta{
    double limite;
    public ContaCorrente(){
        limite = 1000;
    }

    public override double sacar(double valor)
    {
        if(valor > 0 && valor <= this.saldo + limite){
            this.saldo -= valor;
            return valor;
        }
        else{
            throw new Exception("Valor inválido");
        }
    }
}

class ContaPoupanca : Conta{
    double rendimento;
}
#endregion