using ContainRs.Domain.Models;
using ContainRs.Application.Repositories;

namespace ContainRs.Application.UseCases
{
    public class RegistrarCliente
    {
        private readonly IClienteRepository repository;

        public RegistrarCliente(IClienteRepository repository, string nome, Email email, string cPF, string? celular,
            string? cEP, string? rua, string? numero, string? complemento, string? bairro,
            string? municipio, UnidadeFederativa? estado)
        {
            this.repository = repository;
            Nome = nome;
            Email = email;
            CPF = cPF;
            Celular = celular;
            CEP = cEP;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Municipio = municipio;
            Estado = estado;
        }

        public string Nome { get; private set; }
        public Email Email { get; private set; }
        public string CPF { get; private set; }
        public string? Celular { get; set; }
        public string? CEP { get; set; }
        public string? Rua { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Municipio { get; set; }
        public UnidadeFederativa? Estado { get; set; }

        public async Task<Cliente> ExecutarAsync()
        {
            var cliente = new Cliente(Nome, Email, CPF)
            {
                Celular = Celular,
                CEP = CEP,
                Rua = Rua,
                Numero = Numero,
                Complemento = Complemento,
                Bairro = Bairro,
                Municipio = Municipio,
                Estado = Estado
            };
            await repository.AddASync(cliente);
            return cliente;
        }
    }
}
