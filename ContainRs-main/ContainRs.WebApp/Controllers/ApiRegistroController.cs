using ContainRs.WebApp.Data;
using ContainRs.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

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
            var cliente = new Cliente(request.Nome, new Email(request.Email), request.CPF)
            {
                Celular = request.Celular,
                CEP = request.CEP,
                Rua = request.Rua,
                Numero = request.Numero,
                Complemento = request.Complemento,
                Bairro = request.Bairro,
                Municipio = request.Municipio,
                Estado = request.Estado
            };
            context.Clientes.Add(cliente);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
