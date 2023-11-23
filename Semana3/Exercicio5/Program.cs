using System;
int op = 0;
App a = new App();
List<Pessoa> pessoaList = new List<Pessoa>();
do{
    Console.WriteLine("<----------MENU---------->");
    Console.WriteLine("1- Adicionar Pessoa");
    Console.WriteLine("2- Calcular Média das Alturas");
    Console.WriteLine("0- Sair");
    op = Int32.Parse(Console.ReadLine() ?? "0");
    switch (op){
        case 1:
            pessoaList.Add(App.novaPessoa());
            break;
        case 2:
            Console.WriteLine($"A média da altura das pessoas é: {App.alturaMedia(pessoaList)}");
            break;
    }
}while(op != 0);