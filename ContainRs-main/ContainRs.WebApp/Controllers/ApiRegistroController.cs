using ContainRs.WebApp.Data;
using ContainRs.WebApp.Models;
using ContainRs.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using ContainRs.Domain.Models;

namespace ContainRs.WebApp.Controllers
{
    [ApiController]
    [Route("api/registros")]
    public class ApiRegistroController : ControllerBase
    {
        private readonly AppDbContext context;

        public ApiRegistroController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(RegistroViewModel request)
        {
            var useCase = new RegistrarCliente
                (
                    context, request.Nome, new Email(request.Email), request.CPF, request.Celular, request.CEP, request.Rua,
                    request.Numero, request.Complemento, request.Bairro, request.Municipio, UfStringConverter.From(request.Estado)
                );

            await useCase.ExecutarAsync();

            return Ok();
        }
    }
}
