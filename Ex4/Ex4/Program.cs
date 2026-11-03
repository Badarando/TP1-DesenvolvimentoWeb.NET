namespace Ex4
{
    internal class Program
    {
        public class TemperatureSensor()
        {
            public event Action TemperatureExceeded;

            public void Teste(int leitura)
            {
                if (leitura > 100){
                    TemperatureExceeded?.Invoke();
                }
            }
            
        }
        public static void ExibirAlerta()
        {
            Console.WriteLine("Alerta! Temperatura acima de 100ºC");
        }
        static void Main(string[] args)
        {
            TemperatureSensor temperatura = new TemperatureSensor();
            temperatura.TemperatureExceeded += ExibirAlerta;


            while (true)
            {
                Console.WriteLine("Digite a leitura de temperatura: ");
                int leitura = int.Parse(Console.ReadLine());

                if(leitura != -1)
                {
                    temperatura.Teste(leitura);

                } else
                {
                    break;
                }
                
            }
        }
    }
}
