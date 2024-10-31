using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Data;
using ConsoleApp1.factorys;

namespace ConsoleApp1
{
	public class Program
	{
		static void Main(string[] args)
		{
			
			List<Turma> turmas = new List<Turma>();
			
			string arquivo = File.ReadAllText("db.json");
			
			DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(arquivo);
			
			foreach (DataTable table in dataSet.Tables)
			{
				fabricaFactory fabrica = new fabricaFactory();
				IFactory<T> = (IFactory<T>) fabrica.instanciar<T>();
			}
		}
	}
}

