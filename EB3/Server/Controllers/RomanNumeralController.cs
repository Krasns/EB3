using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EB3.Shared;
using EB3.Server.Data;

namespace EB3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RomanNumeralController : ControllerBase
    {
        private DataContext _context;

        public RomanNumeralController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<RomanNumeral>> GetAllRomanNumerals()
        {
            return Ok(_context.RomanNumerals);
        }
        [HttpPost]
        public async Task<ActionResult<RomanNumeral>> PostConvertNumber(RomanNumeral request)
        {
            _context.Add(request);
            await _context.SaveChangesAsync();

            return request;
        }
    }
}
