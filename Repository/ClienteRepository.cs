using System.Collections.Generic;
using System.Linq;
using CampanhaInfopharma.EFContext;
using CampanhaInfopharma.IRepository;
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
            return _ctx.Cliente.Find(id);
        }
        public IEnumerable<Cliente> GetAll()
        {
            return _ctx.Cliente.ToList();
        }

        public KeyValuePair<int, IEnumerable<Cliente>> GetWithParams(string search, bool semFuncVinculado, int page)
        {
            int numeroItens = 0;

            if (semFuncVinculado)
            {
                if (string.IsNullOrEmpty(search))
                {
                    var script = "SELECT * FROM CLIENTE WHERE Id_pk NOT IN (SELECT cliente_id_fk FROM CONTATOUSUARIOCAMPANHA)";

                    numeroItens = _ctx.Cliente.FromSql(script).Count();
                    return new KeyValuePair<int, IEnumerable<Cliente>>(numeroItens, _ctx.Cliente.FromSql(script).Skip(15*(page)).Take(15).ToList());
                }
                else {
                    var script = string.Format("SELECT * FROM CLIENTE WHERE Id_pk NOT IN (SELECT cliente_id_fk FROM CONTATOUSUARIOCAMPANHA) and razao_social like '%{0}%' or nome_fantasia like '%{0}%' or nome_contato_drogaria like '%{0}%'", search);

                    numeroItens = _ctx.Cliente.FromSql(script).Count();
                    return new KeyValuePair<int, IEnumerable<Cliente>>(numeroItens, _ctx.Cliente.FromSql(script).Skip(15*(page)).Take(15).ToList());
                }
            }
            else {
                return new KeyValuePair<int, IEnumerable<Cliente>>(numeroItens, _ctx.Cliente.Skip(15*(page)).Take(15).ToList());
            }
        }
    }
}