using Microsoft.AspNetCore.Mvc;
using mediator.Application.Usuario;

namespace mediator.Controllers
{
    public class HomeController : UsuarioControllerBase
    {
        public HomeController()
        {

        }

        [HttpGet]
        public async Task<ActionResult<UsuarioResponseModel>> ApiController(string nome, string endereco, string sexo)
        {
            try
            {
                var request = new UsuarioRequestModel { Nome = nome, Endereco = endereco, Sexo = sexo };
                return await Mediator.Send(request);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}