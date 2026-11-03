namespace Ex2
{
    internal class Program
    {

        public static void Portugues(string nome)
        {
            Console.WriteLine($"Bem-vindo, {nome}");
        }

        public static void Ingles(string nome)
        {
            Console.WriteLine($"Welcome, {nome}");
        }

        public static void Espanhol(string nome)
        {
            Console.WriteLine($"Bienvenido, {nome}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Escolha um idioma: ");
            Console.WriteLine("1 – Português");
            Console.WriteLine("2 – Inglês");
            Console.WriteLine("3 – Espanhol");
            int opcao = int.Parse(Console.ReadLine());

            Action<string> apresentar;

            switch (opcao)
            {
                case 1:
                    apresentar = Portugues;
                    apresentar(nome);
                    break;

                case 2:
                    apresentar = Ingles;
                    apresentar(nome);
                    break;
                case 3:
                    apresentar = Espanhol;
                    apresentar(nome);
                    break;

            }
        }
    }
}
