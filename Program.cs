using ExemploExplorando.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));


// Pessoa p1 = new Pessoa(nome: "César", sobrenome:"Guilherme");
// Pessoa p2 = new Pessoa(nome: "Natália", sobrenome:"Aparecida de França Guilherme");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();