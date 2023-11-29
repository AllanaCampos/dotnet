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
                    try{Paciente.addPaciente(pacientes);}
                    catch(Exception ex){Console.WriteLine(ex.Message);}
                    break;
                case 2:
                    try{Medico.addMedico(medicos);}
                    catch(Exception ex){Console.WriteLine(ex.Message);}
                    break;
            }
        }while(op != 0);        
    }
    static public void Relatorio(List<Paciente> pacientes, List<Medico> medicos){
        int op = -1;
        do{
            Console.WriteLine("1- Médicos com idade entre dois valores");
            Console.WriteLine("2- Pacientes com idade entre dois valores");
            Console.WriteLine("3- Pacientes com o mesmo sexo");
            Console.WriteLine("4- Pacientes em ordem alfabética");
            Console.WriteLine("5- Pacientes com o mesmo sintoma");
            Console.WriteLine("6- Aniversariantes do mês");
            Console.WriteLine("0- Sair");
            op = Int32.Parse(Console.ReadLine() ?? "-1");
            switch(op){
                case 1:
                    Relatorios.medicosIdades(medicos);
                    break;
                case 2:
                    Relatorios.pacientesIdades(pacientes);
                    break;
                case 3:
                    Relatorios.pacientesSexo(pacientes);
                    break;
                case 4:
                    Relatorios.pacientesOrdenado(pacientes);
                    break;
                case 5:
                    Relatorios.pacientesSintoma(pacientes);
                    break;
                case 6:
                    Relatorios.aniversariantes(pacientes, medicos);
                    break;
            }
        }while(op != 0);    
    }
}