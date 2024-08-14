using ExemploExplorando.Models;
using System.Globalization;

try
{
    string [] linhas = File.ReadAllLines ("Arquivos/arquivo_Leitura.txt");

foreach(string linha in linhas)
{
    Console.WriteLine (linha);
}
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui!");
}


// string dataString = "2022-04-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Convertido com sucesso: {data}");
// }
// else
// {
//     Console.WriteLine($"{data}. Não é uma data válida!");
// }

// Console.WriteLine(data);

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine($"{valorMonetario:C}");
// Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));


// Pessoa p1 = new Pessoa(nome: "César", sobrenome:"Guilherme");
// Pessoa p2 = new Pessoa(nome: "Natália", sobrenome:"Aparecida de França Guilherme");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();