namespace ConsoleApp1;

public class apiRequsition
{
    private static HttpClient instance;

    private apiRequsition(){}

    public static HttpClient getInstance()
    {
        if (instance == null)
        {
            instance = new HttpClient();
            instance.BaseAddress = new Uri("http://localhost:3000");
        }
        return instance;
    }
}