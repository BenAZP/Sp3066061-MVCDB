namespace Aula29MVCDB.Models;

public class Editora
{
    public int EditoraId { get; set; }
    public string NomeFantasia { get; set; }
    public string RazaoSocial { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
  


    public Editora() { }

    public Editora(int editoraid, string nomefantasia, string razaosocial, string endereco, string telefone )
    {
        EditoraId  = editoraid;
        NomeFantasia = nomefantasia;
        RazaoSocial = razaosocial;
        Endereco = endereco;
        Telefone = telefone;
    }
}