namespace Namespace;

class Program{
    
    static void Main(string[] args){
        List<Paciente> pacientes = new List<Paciente>();
        List<Medico> medicos = new List<Medico>();
        int op = -1;
        do{
            Console.WriteLine("1- Adicionar Paciente");
            Console.WriteLine("2- Adicionar Médico");
            Console.WriteLine("3- Relatórios");
            Console.WriteLine("0- Sair");
            op = Int32.Parse(Console.ReadLine() ?? "-1");
            switch(op){
                case 1:
                    break;
            }
        }while(op != 0);        
    }
}