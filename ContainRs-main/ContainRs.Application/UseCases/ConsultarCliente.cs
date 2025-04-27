using ContainRs.Application.Repositories;
using ContainRs.Domain.Models;

namespace ContainRs.Application.UseCases
{
    public class ConsultarCliente
    {
        private readonly IClienteRepository repository;

        public ConsultarCliente(UnidadeFederativa? estado, IClienteRepository repository)
        {
            Estado = estado;
            this.repository = repository;
        }

        public UnidadeFederativa? Estado { get; }

        public Task<IEnumerable<Cliente>> ExecutarAsync()
        {
            if (Estado is not null)
            {
                return repository.GetAsync(c => c.Estado == Estado);
            }

            return repository.GetAsync();
        }

    }
}
