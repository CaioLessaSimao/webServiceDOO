namespace ConsoleApp1.factorys;

public class FabricaArquivoXml : IArquivoFactory
{
    public ICriaArquivo CriarArquivo()
    {
        return new CriadorXml();
    }
}