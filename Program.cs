using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();


// string conteudoArquivo = File.ReadAllText(Path.Combine("Arquivos/vendas.json"));

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
// }

// //site para validação Json: https://codebeautify.org/jsonviewer

// //Serializando em Json

// //ISO 8601
// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json",serializado);

// Console.WriteLine(serializado);

// //--------------

// int numero = 20;
// bool ehPar = false;

// //IF ternário
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

// //IF Não ternário
// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }

// //contrutor
// Pessoa p1 = new Pessoa("César", "Guilherme");

// //desconstrutor
// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

// LeituraArquivo arquivo = new LeituraArquivo();
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     //Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
//     foreach (var linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }
// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "César", "Guilherme", 1.82M);

// Console.WriteLine($"Id: {tupla.Id} - Nome: {tupla.Nome} {tupla.Sobrenome} - altura {tupla.Altura}");

// ValueTuple<int, string, string, decimal> outraTupla = (2, "Giovanna", "Guilherme", 1.70M);
// Console.WriteLine($"Id: {outraTupla.Item1} - Nome: {outraTupla.Item2} {outraTupla.Item3} - altura {outraTupla.Item4}");

// var outroExemploDeTupla = Tuple.Create(3, "Gustavo", "Guilherme", 1.64M);
// Console.WriteLine($"Id: {outroExemploDeTupla.Item1} - Nome: {outroExemploDeTupla.Item2} {outroExemploDeTupla.Item3} - altura {outroExemploDeTupla.Item4}");

// Dictionary<string, string> estados = new Dictionary<string, string>();
// estados.Add("SP", "São Pedro");
// estados.Add("MG", "Minas Gerais");
// estados.Add("RJ","Rio de Janeiro");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// Console.WriteLine("-------------------------");

// estados.Add("BA","Bahia");
// estados.Remove("RJ");
// estados["SP"] = "São Paulo";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// string chave = "Be";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }


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