namespace Ex11
{
    internal class Program
    {
        public static string Concatenar(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }

        public static string Maiusculas(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}".ToUpper();
        }

        public static string RemoverEspacos(string nome, string sobrenome)
        {
            return $"{nome}{sobrenome}".Replace(" ", "");
        }

        static void Main(string[] args)
        {
            Func<string, string, string> transformar = Concatenar;

            transformar += Maiusculas;
            transformar += RemoverEspacos;

            string resultado = transformar("Marcos", "Badaró");

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
