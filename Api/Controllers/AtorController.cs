using Microsoft.AspNetCore.Mvc;
using moviedb.Domain.Entidades;
using moviedb.Infra.Repositorios;

namespace moviedb.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtorController: Controller
    {

        public AtorRepositorio AtorRepositorio { get; set; }

        public AtorController(AtorRepositorio repositorio)
        {
            AtorRepositorio = repositorio;
        }

    [HttpGet]
    public ActionResult<IEnumerable<Ator>> BuscarTodosAtores()
    {
        return AtorRepositorio.BuscarTodosAtores();
    }

    [HttpGet("{nome}")]
    public ActionResult<Ator> BuscarAtorPorNome(string nome)
    {
        return AtorRepositorio.BuscarAtorPorNome(nome);
    }

    [HttpPost(Name = "CriarAtor")]
    public void CriarAtor([FromBody] Ator ator)
    {
        AtorRepositorio.Criar(ator);
    }
}
}


