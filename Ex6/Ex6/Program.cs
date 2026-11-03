namespace Ex6
{
    internal class Program
    {
        public class Logger()
        {
            public static void LogToConsole(string mensagem)
            {
                Console.WriteLine($"{mensagem} – Console");
            }

            public static void LogToFile(string mensagem)
            {
                Console.WriteLine($"{mensagem} – Arquivo");
            }
            public static void LogToDatabase(string mensagem)
            {
                Console.WriteLine($"{mensagem} – Banco de dados");
            }
        }
        static void Main(string[] args)
        {
            Action<string> registrar = null;
            registrar?.Invoke("Primeiro teste sem metodos");
            registrar += Logger.LogToConsole;
            registrar += Logger.LogToFile;
            registrar += Logger.LogToDatabase;
            registrar?.Invoke("Registrado com sucesso");

        }
    }
}
