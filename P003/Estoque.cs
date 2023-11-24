using System.Net.Quic;

namespace p003;

public class Estoque
{
    private List<(int codigo, string nome, int quantidade, float preco)> produtos;
    public Estoque(){
        produtos = new List<(int, string, int, float)>();
    }

    public List<(int, string, int, float)> getProdutos(){
        return produtos;
    }

    public void setProdutos(List<(int, string, int, float)> produtos){
        this.produtos = produtos;
    }
    public void cadastroProduto((int, string, int, float) produto){
        produtos.Add(produto);
    }

    public bool existeProduto(int codigo){
        return produtos.Exists(p => p.codigo == codigo);
    }
    public void encontraProduto(int codigo){
        bool find = false;
        foreach(var p in produtos){
            if (p.codigo == codigo){
                find = true;
                Console.WriteLine($"Código: {p.codigo}");
                Console.WriteLine($"Nome: {p.nome}");
                Console.WriteLine($"Quantidade: {p.quantidade}");
                Console.WriteLine($"Preço: {p.preco}");
            }
        }
        if(!find){
            throw new Exception("Produto não encontrado");
        }
    }

    public void atualizaProduto(int codigo, int quantidade){
        for(int i = 0; i < produtos.Count; i++){
            if(produtos[i].codigo == codigo){
                var p = produtos[i];
                p.quantidade += quantidade;
                if(p.quantidade < 0)
                    throw new Exception("Quantidade menor que existente no estoque!");
                produtos[i] = p;
            }
        }
    }

}
