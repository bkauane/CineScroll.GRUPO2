using Microsoft.AspNetCore.Mvc.RazorPages;
using CineScroll.GRUPO2.Servico;
using CineScroll.GRUPO2.Modelo;

public class IndexModelos : PageModel
{
    private readonly ServicosFilmes _servico;

    public List<Filme> Filmes { get; set; }

    public IndexModelos(ServicosFilmes servicos)
    {
        _servico = servicos;
    }

    public void OnGet()
    {
        Filmes = _servico.GetAll();
    }
}
