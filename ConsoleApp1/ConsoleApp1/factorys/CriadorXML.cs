using System.Xml.Serialization;

namespace ConsoleApp1.factorys;

public class CriadorXml : ICriaArquivo
{
    // Método individual ainda presente, mas não será utilizado aqui
    public void Salvar(Aluno aluno)
    {
        var xmlSerializer = new XmlSerializer(typeof(Aluno));
        using (var writer = new StreamWriter($"{aluno.nome}.xml"))
        {
            xmlSerializer.Serialize(writer, aluno);
        }
    }

    public void SalvarTodosAlunos(List<Aluno> alunos)
    {
        var xmlSerializer = new XmlSerializer(typeof(List<Aluno>));
        using (var writer = new StreamWriter("Alunos.xml"))
        {
            xmlSerializer.Serialize(writer, alunos);
        }
    }
}