using MediatR;

namespace mediator.Application.Usuario
{
    public class UsuarioHandler : IRequestHandler<UsuarioRequestModel, UsuarioResponseModel>
    {
        public async Task<UsuarioResponseModel> Handle(UsuarioRequestModel request, CancellationToken cancellationToken)
        {
            var response = $"Number :- {request.Number}";
                        
            return new UsuarioResponseModel
            {
                Response = response
            };
        }
    }
}
