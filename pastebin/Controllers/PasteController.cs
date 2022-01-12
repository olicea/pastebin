using Microsoft.AspNetCore.Mvc;
using pastebin.Models;

namespace pastebin.Controllers;

[ApiController]
[Route("[controller]")]
public class PasteController : ControllerBase
{
    private readonly ILogger<PasteController> _logger;
    private readonly PasteDbContext _context;

    public PasteController(ILogger<PasteController> logger, PasteDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpPost(Name = "AddPaste")]
    public async Task<string> AddPasteAsync(Paste paste)
    {
        // create the paste on the database
        _context.Add(paste);
        await _context.SaveChangesAsync();

        //return paste name
        return paste.ShortUrl;
    }

    [HttpGet("{name}")]
    public ActionResult<Paste> GetPasteAsync(string name)
    {
        //retrieve paste from database
        Paste paste = _context.Pastes
            .FirstOrDefault(p => p.Name == name);

        // if paste is not found, fail
        if (paste == null)
        {
            return NotFound();
        }

        return Content(paste.Content);
    }

    [HttpDelete(Name = "DeletePaste")]
    public ActionResult DeletePasteAsync()
    {
        // delete paste from database
        return Ok();
    }
}
