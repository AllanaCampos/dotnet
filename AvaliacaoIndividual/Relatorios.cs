namespace Namespace;
public class Relatorios
{
    public static void medicosIdades(List<Medico> medicos){
        Console.WriteLine("Informe a idade mínima do intervalo que deseja observar");
        int idadeMin = Int32.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Informe a idade máxima do intervalo que deseja observar");
        int idadeMax = Int32.Parse(Console.ReadLine() ?? "100");
        var idadesEntre = medicos.Where(m => m.getIdade() > idadeMin && m.getIdade() < idadeMax).ToList();
        foreach ( var medico in idadesEntre){
            Console.WriteLine($"Nome: {medico.Nome} CPF: {medico.CPF} CRM: {medico.CRM} Idade: {medico.getIdade()}");
        }   
    }

    public static void pacientesIdades(List<Paciente> pacientes){
        Console.WriteLine("Informe a idade mínima do intervalo que deseja observar");
        int idadeMin = Int32.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Informe a idade máxima do intervalo que deseja observar");
        int idadeMax = Int32.Parse(Console.ReadLine() ?? "100");
        var idadesEntre = pacientes.Where(p => p.getIdade() > idadeMin && p.getIdade() < idadeMax).ToList();
        foreach ( var paciente in idadesEntre){
            Console.WriteLine($"Nome: {paciente.Nome} CPF: {paciente.CPF} Sexo: {paciente.Sexo} Idade: {paciente.getIdade()} Sintomas: {paciente.Sintomas}");
        }   
    }

    public static void pacientesSexo(List<Paciente> pacientes){
        Console.WriteLine("Informe o sexo dos pacientes que deseja observar");
        string sexo = Console.ReadLine() ?? "Feminino";
        var sexoPacientes = pacientes.Where(p => p.Sexo == sexo).ToList();
        foreach ( var paciente in sexoPacientes){
            Console.WriteLine($"Nome: {paciente.Nome} CPF: {paciente.CPF} Sexo: {paciente.Sexo} Idade: {paciente.getIdade()} Sintomas: {paciente.Sintomas}");
        }
    }

    public static void pacientesOrdenado(List<Paciente> pacientes){
        var pacientesOrdenados = pacientes.OrderBy(p => p.Nome).ToList();
        foreach ( var paciente in pacientesOrdenados){
            Console.WriteLine($"Nome: {paciente.Nome} CPF: {paciente.CPF} Sexo: {paciente.Sexo} Idade: {paciente.getIdade()} Sintomas: {paciente.Sintomas}");
        }
    }

    public static void pacientesSintoma(List<Paciente> pacientes){
        Console.WriteLine("Informe o sintoma dos pacientes que deseja observar");
        string sintoma = Console.ReadLine() ?? "dor";
        var pacientesSintomas = pacientes.Where(p => p.Sintomas.Contains(sintoma)).ToList();
        foreach ( var paciente in pacientesSintomas){
            Console.WriteLine($"Nome: {paciente.Nome} CPF: {paciente.CPF} Sexo: {paciente.Sexo} Idade: {paciente.getIdade()} Sintomas: {paciente.Sintomas}");
        }
    }

    public static void aniversariantes(List<Paciente> pacientes, List<Medico> medicos){
        Console.WriteLine("Informe qual mês dos aniversariantes que deseja observar (Indique o mês como número)");
        int mes = Int32.Parse(Console.ReadLine() ?? "0");
        var pacientesAniversariantes = pacientes.Where(p => p.dataNascimento.Month == (mes -1)).ToList();
        var medicosAniversariantes = medicos.Where(m => m.dataNascimento.Month == (mes -1)).ToList();
        Console.WriteLine("Pacientes Aniversariantes:");
        foreach ( var paciente in pacientesAniversariantes){
            Console.WriteLine($"Nome: {paciente.Nome} CPF: {paciente.CPF} Sexo: {paciente.Sexo} Idade: {paciente.getIdade()} Sintomas: {paciente.Sintomas}");
        }
        Console.WriteLine("Médicos Aniversariantes:");
        foreach ( var medico in medicosAniversariantes){
            Console.WriteLine($"Nome: {medico.Nome} CPF: {medico.CPF} CRM: {medico.CRM} Idade: {medico.getIdade()}");
        } 
    }
    
}
