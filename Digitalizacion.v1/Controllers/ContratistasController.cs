using Digitalizacion.v1.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Digitalizacion.v1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratistasController : ControllerBase
    {
        private readonly IContratistaBusiness _contratistaBusiness;
        public ContratistasController(IContratistaBusiness contratistaBusiness)
        {
            _contratistaBusiness = contratistaBusiness;
        }

        [HttpGet]
        public IActionResult GetContratistas()
        {
            var response = _contratistaBusiness.ObtenerTodos();
            return Ok(response);
        }

        [HttpGet("{idcontratista}")]
        public IActionResult GetContratista([FromRoute]string idcontratista)
        {
            return Ok(idcontratista);
        }

    }
}