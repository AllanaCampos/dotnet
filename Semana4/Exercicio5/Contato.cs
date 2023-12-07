namespace Namespace;
public class Contato
{
    public static int qtd;
    public int Indice {get; private set;}
    public string Nome { get; set;}
    public string Numero{ get; set;}
    public Contato(string nome, string numero){
        this.Nome = nome;
        this.Numero = numero;
        this.Indice = qtd;
        qtd++;
    }
}
