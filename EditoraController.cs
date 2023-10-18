using Microsoft.AspNetCore.Mvc;
using Aula29MVCDB.Models;
namespace Aula29MVCDB.Controllers;
public class EditoraController : Controller
{
    private readonly MvcDBContext _context;

    public EditoraController(MvcDBContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Editoras);
    }
    
}