using p003;

public class Program{
    public static void Main(string[] args){
        int op = 7;
        Estoque e = new Estoque();
        do{
            Console.WriteLine("<----------MENU---------->");
            Console.WriteLine("1- Novo Produto");
            Console.WriteLine("2- Buscar Produto");
            Console.WriteLine("3- Atualizar o Estoque");
            Console.WriteLine("4- Relatórios");
            Console.WriteLine("0- Sair");
            try{op = Int32.Parse(Console.ReadLine() ?? "0");}
            catch{Console.WriteLine("Escreva apenas o número da opção que deseja");}
            switch (op){
                case 1:
                    try{App.novoProduto(e);}
                    catch (Exception ex){Console.WriteLine(ex.Message);}
                    break;
                case 2:
                    App.busca(e);
                    break;
                case 3:
                    try{App.atualiza(e);}
                    catch (Exception ex){Console.WriteLine(ex.Message);}
                    break;
                case 4:
                    Program.relatorios(e);
                    break;
            }
        }while(op != 0);
        
    }

    public static void relatorios(Estoque e){
        int op = 7;
        do{
            Console.WriteLine("<----------RELATÓRIOS---------->");
            Console.WriteLine("1- Relatório Total");
            Console.WriteLine("2- Relatório Parcial");
            Console.WriteLine("3- Relatório Selecionado");
            Console.WriteLine("0- Voltar");
            try{op = Int32.Parse(Console.ReadLine() ?? "0");}
            catch{Console.WriteLine("Escreva apenas o número da opção que deseja");}
            switch (op){
                case 1:
                    App.relatorioTotal(e);
                    break;
                case 2:
                    App.relatorioParcial(e);
                    break;
                case 3:
                    App.relatorioSeletivo(e);
                    break;
            }
        }while(op != 0);
    }
}

