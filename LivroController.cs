using Microsoft.AspNetCore.Mvc;
using Aula29MVCDB.Models;
namespace Aula29MVCDB.Controllers;
public class LivroController : Controller
{
    private readonly MvcDBContext _context;

    public LivroController(MvcDBContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Livros);
    }
    
}