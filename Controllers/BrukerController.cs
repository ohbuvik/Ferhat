using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class BrukerController : Controller
{
    private readonly AppDbContext _context;

    public BrukerController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Opprett()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Opprett(Bruker bruker)
    {
        if (ModelState.IsValid)
        {
            _context.Brukere.Add(bruker);
            await _context.SaveChangesAsync();
            return RedirectToAction("Confirm");
        }

        return View(bruker);
    }

    public IActionResult Bekreftelse()
    {
        return View();
    }
}
