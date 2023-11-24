using System.Linq.Expressions;

namespace p003;

public class App
{
    public static void novoProduto(Estoque e){
        int codigo, quantidade;
        string nome;
        float preco;
        Console.WriteLine("Informe o codigo do produto: ");
        codigo = Int32.Parse(Console.ReadLine() ?? "-1");
        if(e.existeProduto(codigo))
            throw new Exception("Código do produto já cadastrado!");
        Console.WriteLine("Informe o nome do produto: ");
        nome = Console.ReadLine() ?? "";
        Console.WriteLine("Informe a quantidade de produto disponível em estoque: ");
        quantidade = Int32.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Informe o preço do produto: ");
        preco = float.Parse(Console.ReadLine() ?? "10000000000");
        e.cadastroProduto((codigo, nome, quantidade, preco));
    }
    public static void busca(Estoque e){
        int codigo = -1;
        Console.WriteLine("Informe o codigo do produto: ");
        try{codigo = Int32.Parse(Console.ReadLine() ?? "-1");}
        catch{Console.WriteLine("O código deve ser um número inteiro");}
        try{e.encontraProduto(codigo);}
        catch(Exception ex){Console.WriteLine(ex.Message);}
    }

    public static void atualiza(Estoque e){
        int codigo, op, qtd = 0;
        Console.WriteLine("Informe o codigo do produto: ");
        codigo = Int32.Parse(Console.ReadLine() ?? "-1");
        if(!e.existeProduto(codigo))
            throw new Exception("Produto não existente");
        Console.WriteLine("1- Retirar produto");
        Console.WriteLine("2- Repor produto");
        op = Int32.Parse(Console.ReadLine() ?? "0");
        if(op == 1){
            Console.WriteLine("Informe a quantidade que deseja retirar: ");
            qtd = -Int32.Parse(Console.ReadLine() ?? "0");
        }
        else if(op == 2){
            Console.WriteLine("Informe a quantidade que deseja repor: ");
            qtd = Int32.Parse(Console.ReadLine() ?? "0");
        }
        try{ e.atualizaProduto(codigo, qtd);}
        catch(Exception ex){Console.WriteLine(ex.Message);}
    }

    public static void relatorioTotal(Estoque e){
        var produtos = e.getProdutos();
        Console.WriteLine("<----------ESTOQUE---------->");
        produtos.ForEach(p => Console.WriteLine($"Codigo: {p.Item1}\tNome: {p.Item2}\tQuantidade: {p.Item3}\tPreço: {p.Item4}"));
    }

    public static void relatorioParcial(Estoque e) {
        int lim = -1;
        Console.WriteLine("Informe o limite de quantidade de produtos do estoque: ");
        try{lim = Int32.Parse(Console.ReadLine() ?? "0");}
        catch{Console.WriteLine("O limite deve ser um inteiro");}
        var produtos = e.getProdutos().Where(p => p.Item3 < lim).ToList();
        produtos.ForEach(p => Console.WriteLine($"Codigo: {p.Item1}\tNome: {p.Item2}\tQuantidade: {p.Item3}\tPreço: {p.Item4}"));
    }  

    public static void relatorioSeletivo(Estoque e) {
        int limin = -1, limax = -1;
        Console.WriteLine("Informe o limite minimo de quantidade de produtos do estoque: ");
        try{limin = Int32.Parse(Console.ReadLine() ?? "0");}
        catch{Console.WriteLine("O limite deve ser um inteiro");}
        Console.WriteLine("Informe o limite máximo de quantidade de produtos do estoque: ");
        try{limax = Int32.Parse(Console.ReadLine() ?? "0");}
        catch{Console.WriteLine("O limite deve ser um inteiro");}
        var produtos = e.getProdutos().Where(p => (p.Item3 > limin) && (p.Item3 < limax)).ToList();
        produtos.ForEach(p => Console.WriteLine($"Codigo: {p.Item1}\tNome: {p.Item2}\tQuantidade: {p.Item3}\tPreço: {p.Item4}"));
    }
}
