using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace mediator.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioControllerBase : ControllerBase
    {
        private ISender _mediator;

        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();

    }
}