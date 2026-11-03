namespace ConsoleApp1
{
    internal class Program
    {
        public delegate decimal CalculateDiscount(decimal valor);

        public static decimal Calcular(decimal valor)
        {
            decimal valorFinal;
            valorFinal = valor;
            valorFinal -= valor * 0.10m;
            return valorFinal;
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o preço original do produto: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            CalculateDiscount resultado = Calcular;

            Console.WriteLine(resultado(valor));

        }
    }
}
