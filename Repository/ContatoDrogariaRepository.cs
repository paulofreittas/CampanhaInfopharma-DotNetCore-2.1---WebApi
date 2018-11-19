using System.Collections.Generic;
using System.Linq;
using CampanhaInfopharma.EFContext;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using Microsoft.EntityFrameworkCore;

namespace CampanhaInfopharma.Repository
{
    public class ContatoDrogariaRepository : IContatoDrogariaRepository
    {
        private readonly Context _ctx;
        public ContatoDrogariaRepository(Context ctx)
        {
            _ctx = ctx;
        }

        public void Add(ContatoDrogaria contatoDrogaria)
        {
            _ctx.ContatoDrogarias.Add(contatoDrogaria);
            _ctx.SaveChanges();
        }

        public ContatoDrogaria Find(int id)
        {
            return _ctx.ContatoDrogarias.FirstOrDefault(c => c.DrogariaIdFk == id);
        }

        public IEnumerable<ContatoDrogaria> FindByDrogariaId(int drogariaId) {
            return _ctx.ContatoDrogarias.Where(c => c.DrogariaIdFk == drogariaId).Include(x => x.Drogaria).ThenInclude(x => x.Funcionario);
        }

        public IEnumerable<ContatoDrogaria> GetAll()
        {
            return _ctx.ContatoDrogarias.Include(c => c.Drogaria).ThenInclude(c => c.Funcionario).ToList();
        }

        public void Remove(int id)
        {
            var cDrogaria = _ctx.ContatoDrogarias.FirstOrDefault(c => c.DrogariaIdFk == id);

            if (cDrogaria != null)
            {
                _ctx.ContatoDrogarias.Remove(cDrogaria);
                _ctx.SaveChanges();
            }
        }

        public void Update(ContatoDrogaria contatoDrogaria)
        {
            _ctx.ContatoDrogarias.Update(contatoDrogaria);
            _ctx.SaveChanges();
        }
    }
}