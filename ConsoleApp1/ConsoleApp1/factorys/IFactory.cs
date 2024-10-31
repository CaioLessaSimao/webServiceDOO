namespace ConsoleApp1.factorys;

public interface IFactory<out T>
{
	public T criar();
}