namespace ConsoleApp1;

public class Disciplina : ICloneable
{
    public string nome { get; set; }
    public int nota { get; set; }

    public object Clone()
    {
        return MemberwiseClone();
    }
}
