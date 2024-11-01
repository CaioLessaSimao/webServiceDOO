using System.Data;

namespace ConsoleApp1.factorys;

public class alunosFactory
{
	public static Aluno criar(dynamic data)
	{
		Aluno aluno = new Aluno
		{
			nome = data.nome,
			endereco = data.endereco,
			disciplinas = new List<Disciplina>()
		};

		foreach (var disciplina in data.disciplinas)
		{
			aluno.disciplinas.Add(new Disciplina
			{
				nome = disciplina.nome,
				nota = disciplina.nota
			});
		}
		return aluno;
	}
}
