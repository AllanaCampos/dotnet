namespace System;
public class App
{
    public static Pessoa novaPessoa(){
        string nome;
        int altura;
        Console.WriteLine("Digite o nome da pessoa");
        nome = Console.ReadLine() ?? "Fulano";
        Console.WriteLine("Digite a altura da pessoa");
        altura = Int32.Parse(Console.ReadLine()?? "150");
        return new Pessoa(nome, altura);
    }
    public static int alturaMedia(List<Pessoa> pessoas){
        int s = 0;
        pessoas.ForEach(x => s = x.getAltura() + s);
        s = s / pessoas.Count;
        return s;
    }
    
}
