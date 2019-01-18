using System.Collections.Generic;
using System.Linq;
using CampanhaInfopharma.EFContext;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models.dbGestao;

namespace CampanhaInfopharma.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly dbGestaoContext _ctx;
        public ClienteRepository(dbGestaoContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Cliente> GetAll()
        {
            return _ctx.Cliente.Skip(100).Take(10).ToList();
        }
    }
}