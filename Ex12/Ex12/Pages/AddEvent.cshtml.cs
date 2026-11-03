using Ex12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ex12.Pages
{
    public class AddEventModel : PageModel
    {
        public string Titulo { get; set; } = "";
        public DateTime Data { get; set; }
        public string Local { get; set; } = "";

        public bool Cadastrado { get; set; }

        public void OnPost(string titulo, DateTime data, string local)
        {
            Event novoEvento = new Event
            {
                Titulo = titulo,
                Data = data,
                Local = local
            };

            Action<Event> registrar = RegistrarEvento;

            registrar(novoEvento);

            Titulo = novoEvento.Titulo;
            Data = novoEvento.Data;
            Local = novoEvento.Local;

            Cadastrado = true;
        }

        public static void RegistrarEvento(Event evento)
        {
            Console.WriteLine(
                $"Evento criado: {evento.Titulo} | " +
                $"Data: {evento.Data:dd/MM/yyyy} | " +
                $"Local: {evento.Local}"
            );
        }
    }
}