namespace Ex3
{
    internal class Program
    {
        public delegate void ExibirResultados(double area);

        public static double Area(double a, double b)
        {
            double area = a * b;
            return area;
        }

        public static void Exibir(double area)
        {
            Console.WriteLine($"O retângulo tem a área de: {area}cm²");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("insira a base do retangulo: ");
            double retanguloBase = double.Parse(Console.ReadLine());


            Console.WriteLine("insira a altura do retangulo: ");
            double retanguloAltura = double.Parse(Console.ReadLine());

            Func<double, double, double> calculo = Area;
            ExibirResultados resultado = Exibir;
            resultado(calculo(retanguloAltura, retanguloBase));

        }
    }
}
