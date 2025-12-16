using Microsoft.AspNetCore.Mvc.RazorPages;
using CineScroll.GRUPO2.Servicos;
using CineScroll.GRUPO2.Modelos;

public class IndexModelos : PageModel
{
    private readonly ServicoFilmes _servico;

    public List<Filme> Filmes { get; set; }

    public IndexModelos(ServicoFilmes servico)
    {
        _servico = servico;
    }

    public void OnGet()
    {
        Filmes = _servico.GetAll();
    }
}
