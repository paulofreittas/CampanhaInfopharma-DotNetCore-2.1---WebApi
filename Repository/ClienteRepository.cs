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
        public IEnumerable<Cliente> GetAll()
        {
            return _ctx.Cliente.ToList();
        }

        public DrogariaDTO GetWithParams(string search, bool semFuncVinculado, int page)
        {
            int numeroItens = 0;
            string script = "";
            var clientesFunc = new List<ClienteFuncionario>();
            var clientes = new List<Cliente>();

            if (semFuncVinculado)
            {
                if (string.IsNullOrEmpty(search))
                {
                    script = "SELECT * FROM CLIENTE WHERE Id_pk NOT IN (SELECT cliente_id_fk FROM CONTATOUSUARIOCAMPANHA)";

                    numeroItens = _ctx.Cliente.FromSql(script).Count();
                }
                else
                {
                    script = string.Format("SELECT * FROM CLIENTE WHERE Id_pk NOT IN (SELECT cliente_id_fk FROM CONTATOUSUARIOCAMPANHA) and razao_social like '%{0}%' or nome_fantasia like '%{0}%' or nome_contato_drogaria like '%{0}%'", search);

                    numeroItens = _ctx.Cliente.FromSql(script).Count();
                }

                clientes = _ctx.Cliente.FromSql(script).Skip(15 * (page)).Take(15).ToList();

                foreach (var cliente in clientes)
                {
                    clientesFunc.Add(new ClienteFuncionario()
                    {
                        Cliente = cliente,
                        Usuario = null
                    });
                }

                var result = new DrogariaDTO()
                {
                    NumeroResultados = numeroItens,
                    Pagina = page,
                    Resultado = clientesFunc
                };

                return result;
            }
            else
            {
                if (string.IsNullOrEmpty(search))
                {
                    clientes = _ctx.Cliente.Skip(15 * (page)).Take(15).ToList();

                    numeroItens = clientes.Count();
                }
                else {
                    clientes = _ctx.Cliente.Include(p => p.CidadeIdFkNavigation.NomeCidade).Where(x => x.RazaoSocial.Contains(search)    || 
                                                                                                      x.NomeFantasia.Contains(search)        || 
                                                                                                      x.NomeContatoDrogaria.Contains(search) || 
                                                                                                      x.CidadeIdFkNavigation.NomeCidade.Contains(search))
                                    .Skip(15 * (page)).Take(15).ToList();
                    
                    numeroItens = clientes.Count();
                }

                 foreach (var cliente in clientes)
                    {
                        var func = new Usuario();
                        var funcId = _ctx.Contatousuariocampanha.Where(x => x.ClienteIdFk == cliente.IdPk).FirstOrDefault()?.UsuarioIdFk;

                        if (funcId > 0)
                            func = _ctx.Usuario.Find(funcId);

                        clientesFunc.Add(new ClienteFuncionario()
                        {
                            Cliente = cliente,
                            Usuario = func
                        });
                    }

                    var result = new DrogariaDTO()
                    {
                        NumeroResultados = numeroItens,
                        Pagina = page,
                        Resultado = clientesFunc
                    };

                    return result;
            }
        }
    }
}