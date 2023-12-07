using System.Collections;

namespace Namespace;

public class Agenda
{
    
    public List<Contato> contatoList;
    public Contato Contatos { 
        get{
            foreach(var contato in contatoList){
                Console.WriteLine($"Contato: {contato.Indice}");
                Console.WriteLine($"Nome: {contato.Nome}\tNúmero: {contato.Numero}");
            }
            Console.WriteLine("Informe o índice do contato");
            int indice = Int32.Parse(Console.ReadLine() ?? "0");
            return contatoList.First(x => x.Indice == indice);
        } 
    }
    public Agenda(){
        Contato.qtd = 0;
        contatoList = new List<Contato>();
    }

    public void addContato(){
        Console.WriteLine("Informe o nome do contato:");
        string nome = Console.ReadLine();
        Console.WriteLine("Informe o numero do contato:");
        string numero = Console.ReadLine();
        Contato contato = new Contato(nome, numero);
        contatoList.Add(contato);
    }
}
