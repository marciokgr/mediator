using MediatR;

namespace mediator.Application.Usuario
{
    public class UsuarioRequestModel : IRequest<UsuarioResponseModel>
    {
        public int Number { get; set; }
    }
}
