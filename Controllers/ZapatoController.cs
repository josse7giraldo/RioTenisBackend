using Microsoft.AspNetCore.Mvc;
using Rio.Tenis.Backend.DBContexts;
using Rio.Tenis.Backend.Models;

namespace Rio.Tenis.Backend.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ZapatoController : ControllerBase
    { 
        private RioTenisDBContext _context;

        private readonly ILogger<ZapatoController> _logger;

        public ZapatoController(ILogger<ZapatoController> logger, RioTenisDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IList<Zapato> Get()
        {
            return _context.Zapatos.ToList();
        }
    }
}
