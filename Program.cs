using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "César", sobrenome:"Guilherme");
Pessoa p2 = new Pessoa(nome: "Natália", sobrenome:"Aparecida de França Guilherme");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();