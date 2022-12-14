using MediatR;

namespace mediator.Application.Usuario
{
    public class UsuarioRequestModel : IRequest<UsuarioResponseModel>
    {
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Sexo { get; set; }
    }
}
