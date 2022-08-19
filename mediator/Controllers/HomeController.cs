using Microsoft.AspNetCore.Mvc;
using mediator.Application.Usuario;

namespace mediator.Controllers
{
    public class HomeController : UsuarioControllerBase
    {
        public HomeController()
        {

        }

        [HttpGet(nameof(ApiController))]
        public async Task<ActionResult<UsuarioResponseModel>> ApiController(int number)
        {
            try
            {
                var request = new UsuarioRequestModel { Number = number };
                return await Mediator.Send(request);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}