namespace ConsoleApp1.factorys
{

	public class fabricaFactory 
	{
		public IFactory<T> instanciar<T>(string fabrica)
		{
			return fabrica switch
			{
				"alunos" => (IFactory<T>)new alunosFactory(),
				"disciplinas" => (IFactory<T>)new disciplinasFactory(),
				"professores" => (IFactory<T>)new professoresFactory(),
			};
		}
	}
}