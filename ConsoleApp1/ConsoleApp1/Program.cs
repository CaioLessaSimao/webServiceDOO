using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Data;
using ConsoleApp1.factorys;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1
{
	public class Program
	{
		static async Task Main(string[] args)
		{

			HttpClient client = apiRequsition.getInstance();
			
			HttpResponseMessage response = await client.GetAsync("alunos");

			if (response.IsSuccessStatusCode)
			{
				List<Aluno> alunos = new List<Aluno>();
			
				var jsonString = await response.Content.ReadAsStringAsync();
				JArray alunosJson = JArray.Parse(jsonString);
				
				foreach (var alunoJson in alunosJson)
				{
					alunos.Add(alunosFactory.criar(alunoJson));
					
				}
				
				IArquivoFactory arquivoFactory = new FabricaArquivoXml(); // Fábrica Abstrata para XML
				ICriaArquivo criaArquivo = arquivoFactory.CriarArquivo();
				
				criaArquivo.SalvarTodosAlunos(alunos);
				Console.WriteLine("Todos os alunos foram salvos em um único arquivo XML.");
			
			}
		}
	}
}

