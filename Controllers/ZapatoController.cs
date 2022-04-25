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

        public ZapatoController(ILogger<ZapatoController> logger,
            RioTenisDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IList<Zapato> ObtenerListadoZapatos()
        {
            return _context.Zapatos.ToList();
        }

        [HttpGet("{id}")]
        public Zapato ObtenerZapatoPorId(int id)
        {
            return _context.Zapatos.Find(id);
        }

        [HttpPost]
        public Zapato GuardarZapato(Zapato zapato)
        {
            _context.Add(zapato);
            _context.SaveChanges();
            return zapato;
        }

        [HttpPut]
        public Zapato ActualizarZapato(Zapato zapato)
        {
            Zapato zapatoConsultado = _context.Zapatos.Find(zapato.Id);
            zapatoConsultado.Marca = zapato.Marca;
            zapatoConsultado.Modelo = zapato.Modelo;
            zapatoConsultado.Genero = zapato.Genero;
            zapatoConsultado.Talla = zapato.Talla;
            zapato.Referencia = zapato.Referencia;
            _context.Update(zapatoConsultado);
            _context.SaveChanges();
            return zapato;
        }
    }
}
