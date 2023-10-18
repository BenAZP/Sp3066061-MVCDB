namespace Aula29MVCDB.Models;

public class Livro
{
    public int LivroId { get; set; }
    public string ISBN { get; set; }
    public string Titulo { get; set; }
    public string Preco { get; set; }
    public string Categoria { get; set; }
    public int IdEditora { get; set; }


    public Livro() { }

    public Livro(int livroid, string isbn, string titulo, string preco, string categoria, int ideditora )
    {
        LivroId  = livroid;
        ISBN = isbn;
        Titulo = titulo;
        Preco = preco;
        Categoria = categoria;
        IdEditora= ideditora;
    }
}