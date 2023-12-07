namespace Namespace;

class Program{
    static void Main(string[] args){
        Agenda agenda = new Agenda();
        agenda.addContato();
        Contato contato = agenda.Contatos;
        Console.WriteLine("Nome: " + contato.Nome + "\tNúmero: " + contato.Numero);
    }
}