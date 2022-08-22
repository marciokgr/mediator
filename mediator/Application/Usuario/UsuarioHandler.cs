using MediatR;

namespace mediator.Application.Usuario
{
    public class UsuarioHandler : IRequestHandler<UsuarioRequestModel, UsuarioResponseModel>
    {
        public async Task<UsuarioResponseModel> Handle(UsuarioRequestModel request, CancellationToken cancellationToken)
        {    
            
            //implementar service


            return new UsuarioResponseModel
            {
                Nome = request.Nome
            };
        }
    }
}
