using ExemploExplorando.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Pedro");
estados.Add("MG", "Minas Gerais");
estados.Add("RJ","Rio de Janeiro");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

Console.WriteLine("-------------------------");

estados.Add("BA","Bahia");
estados.Remove("RJ");
estados["SP"] = "São Paulo";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

string chave = "Be";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}


// Stack<int> pilha = new Stack<int>();

// pilha.Push(0);
// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(5);
// pilha.Push(7);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(11);
// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// fila.Enqueue(10);
// fila.Enqueue(12);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// new ExemploExcecao().Metodo1();

// try
// {
//     string [] linhas = File.ReadAllLines ("Arquivos/arquivo_Leitura.txt");

// foreach(string linha in linhas)
// {
//     Console.WriteLine (linha);
// }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui!");
// }


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