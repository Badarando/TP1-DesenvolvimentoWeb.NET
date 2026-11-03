namespace Ex5
{
    internal class Program
    {
        public class DownloadManager()
        {
            public event Action DownloadCompleted;

            public void download()
            {
                Thread.Sleep(3000);
                DownloadCompleted?.Invoke();
            }
        }
        public static void ExibirAlerta()
        {
            Console.WriteLine("Donwload concluido!");
        }

        static void Main(string[] args)
        {
            DownloadManager download = new DownloadManager();

            download.DownloadCompleted += ExibirAlerta;
            Console.WriteLine("Baixando arquivo...");
            download.download();

        }
    }
}
