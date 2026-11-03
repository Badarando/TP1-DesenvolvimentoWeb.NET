using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ex10.Pages
{
    public class AddProductModel : PageModel
    {
        public string Nome { get; set; } = "";
        public decimal Preco { get; set; }
        public void OnGet()
        {
        }

        public void OnPost(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
