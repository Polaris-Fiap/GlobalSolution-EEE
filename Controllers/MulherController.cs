using GlobalSolution_Polaris.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlobalSolution_Polaris.Controllers
{
    [ApiController]
    [Route("/api/mulher")]
    public class MulherController : ControllerBase
    {
        private readonly ILogger<MulherController> _logger;
        private readonly IMulherRepository _repository;


        public MulherController(IMulherRepository mulherRepostitory, ILogger<MulherController> logger)
        {
            _repository = mulherRepostitory;
            _logger = logger;
        }

        [HttpGet]
        public List<Mulher> ListarMulheres()
        {
            return _repository.Listar();
        }

        [HttpGet("{id}")]
        public ActionResult<Mulher> ObterMulher(int id)
        {
            Mulher mulher = _repository.ObterPorId(id);

            if (mulher == null)
            {
                _logger.LogInformation($"Mulher não encontrada [{id}]");
                return NotFound();
            }

            return Ok(mulher);
        }

        [HttpPost]
        public ActionResult<Mulher> Cadastrar(Mulher mulher)
        {
            _repository.Cadastrar(mulher);

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<Mulher> Atualizar(int id, Mulher mulher)
        {
            Mulher mulherExists = _repository.ObterPorId(id);

            if (mulherExists == null)
            {
                return NotFound();
            }

            mulher.MulherID = id;

            _repository.Atualizar(mulher);

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Mulher> Remover(int id)
        {
            Mulher mulher = _repository.ObterPorId(id);

            if (mulher == null)
            {
                return NotFound();
            }

            _repository.Remover(mulher);

            return NoContent();
        }

    }
}
