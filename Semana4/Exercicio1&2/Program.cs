namespace Namespace;
public class Class
{
    public static void Main(string[] args){
        Veiculo veiculo= new Veiculo();
        veiculo.Cor = "Branco";
        veiculo.Modelo = "Tracker";
        veiculo.Ano = 2022;
        Console.WriteLine($"Cor: {veiculo.Cor} Modelo: {veiculo.Modelo} Ano: {veiculo.Ano} Idade: {veiculo.IdadeVeiculo}");
    }
}
