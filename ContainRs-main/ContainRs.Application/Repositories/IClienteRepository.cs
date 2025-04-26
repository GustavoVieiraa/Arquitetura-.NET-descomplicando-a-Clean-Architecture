using ContainRs.Domain.Models;

namespace ContainRs.Application.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> AddASync(Cliente cliente);
    }
}
