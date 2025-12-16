using System.Collections.Generic;
using System.Linq;

namespace CS.grupo2Servicos
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Diretor { get; set; } = string.Empty;
        public int AnoLancamento { get; set; }
        public double Avaliacao { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public List<string> Genero { get; set; } = new();
        public string PosterUrl { get; set; } = string.Empty;
        public List<string> Atores { get; set; } = new();
    }

    public class ServicosFilmes
    {
        private readonly List<Filme> _filmes;

        public ServicosFilmes()
        {
            _filmes = new List<Filme>
            {
                new Filme {
                    Id = 1,
                    Titulo = "A Origem",
                    Diretor = "Christopher Nolan",
                    AnoLancamento = 2010,
                    Avaliacao = 8.8,
                    Descricao = "Um ladrão que rouba segredos corporativos...",
                    Genero = new List<string> { "Sci-Fi", "Ação", "Aventura" },
                    PosterUrl = "https://m.media-amazon.com/images/I/81yWgqCuSyL.jpg",
                    Atores = new List<string> { "Leonardo DiCaprio", "Joseph Gordon-Levitt", "Elliot Page" }
                },
                new Filme {
                    Id = 2,
                    Titulo = "Interestelar",
                    Diretor = "Christopher Nolan",
                    AnoLancamento = 2014,
                    Avaliacao = 8.6,
                    Descricao = "Uma equipe de exploradores viaja através de um buraco de minhoca...",
                    Genero = new List<string> { "Sci-Fi", "Drama", "Aventura" },
                    PosterUrl = "https://m.media-amazon.com/images/I/71D0Y7t8zSL.jpg",
                    Atores = new List<string> { "Matthew McConaughey", "Anne Hathaway", "Jessica Chastain" }
                }
            };
        }

        public List<Filme> Search(string termo)
        {
            if (string.IsNullOrWhiteSpace(termo))
                return _filmes;

            termo = termo.ToLower();

            return _filmes
                .Where(f =>
                    f.Titulo.ToLower().Contains(termo) ||
                    f.Diretor.ToLower().Contains(termo) ||
                    f.Atores.Any(a => a.ToLower().Contains(termo)) ||
                    f.Genero.Any(g => g.ToLower().Contains(termo)))
                .ToList();
        }

        public List<Filme> GetAll() => _filmes;
    }
}
