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

        public Cliente Find(int id)
        {
            return _ctx.Cliente.Find(id);
        }
        public IEnumerable<Cliente> GetAll()
        {
            return _ctx.Cliente.ToList();
        }

        public void Remove(int id)
        {
            var cliente = _ctx.Cliente.FirstOrDefault(c => c.IdPk == id);

            if (cliente != null)
            {
                _ctx.Cliente.Remove(cliente);
                _ctx.SaveChanges();
            }
        }

        public void Update(Cliente cliente)
        {
            _ctx.Update(cliente);
            _ctx.SaveChanges();
        }
    }
}