using System.Collections.Generic;
using System.Linq;
using CampanhaInfopharma.EFContext;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using CampanhaInfopharma.Models.dbGestao;
using Microsoft.EntityFrameworkCore;

namespace CampanhaInfopharma.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly dbGestaoContext _ctx;
        public ClienteRepository(dbGestaoContext ctx)
        {
            _ctx = ctx;
        }

        public Cliente Find(int id)
        {
            return _ctx.Cliente.Where(x => x.IdPk == id).Include(x => x.Contatousuariocampanha).ThenInclude(x => x.UsuarioIdFkNavigation).Include(x => x.CidadeIdFkNavigation).FirstOrDefault();
        }

        public DrogariaDTO GetWithParams(string search, bool semFuncVinculado, int page)
        {
            int numeroItens = 0;
            var clientes = new List<Cliente>();

            if (semFuncVinculado)
            {
                if (string.IsNullOrEmpty(search))
                {
                    clientes = _ctx.Cliente.Include(x => x.Contatousuariocampanha)
                                           .ThenInclude(x => x.UsuarioIdFkNavigation)
                                           .Include(x => x.CidadeIdFkNavigation)
                                           .Where(x => x.Inativo == false)
                                           .Where(x => !x.Contatousuariocampanha.Any())
                                           .Skip(15 * (page)).Take(15).ToList();

                    numeroItens = _ctx.Cliente.Include(x => x.Contatousuariocampanha)
                                           .ThenInclude(x => x.UsuarioIdFkNavigation)
                                           .Include(x => x.CidadeIdFkNavigation)
                                           .Where(x => x.Inativo == false)
                                           .Where(x => !x.Contatousuariocampanha.Any())
                                           .Count();
                }
                else
                {
                    clientes = _ctx.Cliente.Include(x => x.Contatousuariocampanha)
                                           .ThenInclude(x => x.UsuarioIdFkNavigation)
                                           .Include(x => x.CidadeIdFkNavigation)
                                           .Where(x => x.Inativo == false)
                                           .Where(x => !x.Contatousuariocampanha.Any())
                                           .Where(x => x.NomeFantasia.Contains(search) ||
                                                  x.RazaoSocial.Contains(search) ||
                                                  x.NomeContatoDrogaria.Contains(search) ||
                                                  x.CidadeIdFkNavigation.NomeCidade.Contains(search) ||
                                                  x.Cnpj.Contains(search))
                                           .Skip(15 * (page)).Take(15).ToList();

                    numeroItens = _ctx.Cliente.Include(x => x.Contatousuariocampanha)
                                           .ThenInclude(x => x.UsuarioIdFkNavigation)
                                           .Include(x => x.CidadeIdFkNavigation)
                                           .Where(x => x.Inativo == false)
                                           .Where(x => !x.Contatousuariocampanha.Any())
                                           .Where(x => x.NomeFantasia.Contains(search) ||
                                                  x.RazaoSocial.Contains(search) ||
                                                  x.NomeContatoDrogaria.Contains(search) ||
                                                  x.CidadeIdFkNavigation.NomeCidade.Contains(search) ||
                                                  x.Cnpj.Contains(search))
                                           .Count();
                }

                var result = new DrogariaDTO()
                {
                    NumeroResultados = numeroItens,
                    Pagina = page,
                    Resultado = clientes
                };

                return result;
            }
            else
            {
                if (string.IsNullOrEmpty(search))
                {
                    clientes = _ctx.Cliente.Include(x => x.Contatousuariocampanha)
                                           .ThenInclude(x => x.UsuarioIdFkNavigation)
                                           .Include(x => x.CidadeIdFkNavigation)
                                           .Where(x => x.Inativo == false)
                                           .Skip(15 * (page)).Take(15).ToList();

                    numeroItens = _ctx.Cliente.Include(x => x.Contatousuariocampanha)
                                           .ThenInclude(x => x.UsuarioIdFkNavigation)
                                           .Include(x => x.CidadeIdFkNavigation)
                                           .Where(x => x.Inativo == false)
                                           .Count();
                }
                else
                {
                    clientes = _ctx.Cliente.Include(x => x.Contatousuariocampanha)
                                           .ThenInclude(x => x.UsuarioIdFkNavigation)
                                           .Include(x => x.CidadeIdFkNavigation)
                                           .Where(x => x.Inativo == false)
                                           .Where(x => x.NomeFantasia.Contains(search) ||
                                                  x.RazaoSocial.Contains(search) ||
                                                  x.NomeContatoDrogaria.Contains(search) ||
                                                  x.CidadeIdFkNavigation.NomeCidade.Contains(search) ||
                                                  x.Cnpj.Contains(search))
                                           .Skip(15 * (page)).Take(15).ToList();

                    numeroItens = _ctx.Cliente.Include(x => x.Contatousuariocampanha)
                                           .ThenInclude(x => x.UsuarioIdFkNavigation)
                                           .Include(x => x.CidadeIdFkNavigation)
                                           .Where(x => x.Inativo == false)
                                           .Where(x => x.NomeFantasia.Contains(search) ||
                                                  x.RazaoSocial.Contains(search) ||
                                                  x.NomeContatoDrogaria.Contains(search) ||
                                                  x.CidadeIdFkNavigation.NomeCidade.Contains(search) ||
                                                  x.Cnpj.Contains(search))
                                           .Count();
                }

                var result = new DrogariaDTO()
                {
                    NumeroResultados = numeroItens,
                    Pagina = page,
                    Resultado = clientes
                };

                return result;
            }
        }
    }
}