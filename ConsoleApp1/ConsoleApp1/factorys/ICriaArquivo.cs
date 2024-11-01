namespace ConsoleApp1.factorys;

public interface ICriaArquivo
{
    void Salvar(Aluno aluno);
    void SalvarTodosAlunos(List<Aluno> alunos);
}