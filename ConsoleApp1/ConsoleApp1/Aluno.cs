namespace ConsoleApp1;

public class Aluno : ICloneable
{
    public string nome { get; set; }
    public string endereco { get; set; }
    public List<Disciplina> disciplinas { get; set; }

    public object Clone()
    {
        Aluno alunoClone = (Aluno) MemberwiseClone();
        alunoClone.disciplinas = new List<Disciplina>();
        foreach (Disciplina disc in this.disciplinas)
        {
            alunoClone.disciplinas.Add( (Disciplina)disc.Clone() );
        }
            
        return alunoClone;
    }
}