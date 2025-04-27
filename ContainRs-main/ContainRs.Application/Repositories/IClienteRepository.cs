using ContainRs.Domain.Models;
using System.Linq.Expressions;

namespace ContainRs.Application.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> AddASync(Cliente cliente);

        Task<IEnumerable<Cliente>> GetAsync(Expression<Func<Cliente, bool>>? filtro = default);
    }
}
