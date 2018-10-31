using System.Collections.Generic;
using System.Linq;
using CampanhaInfopharma.EFContext;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using Microsoft.EntityFrameworkCore;

namespace CampanhaInfopharma.Repository
{
    public class DrogariaRepository : IDrogariaRepository
    {
        private readonly Context _ctx;
        public DrogariaRepository(Context ctx)
        {
            _ctx = ctx;
        }
        public void Add(Drogaria drogaria)
        {
            var drog = _ctx.Drogarias.Find(drogaria.CNPJ);

            if (drog == null)
            {
                _ctx.Drogarias.Add(drogaria);
                _ctx.SaveChanges();
            }
            
        }

        public Drogaria Find(int id)
        {
            return _ctx.Drogarias.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Drogaria> GetAll()
        {
            return _ctx.Drogarias.ToList();
        }

        public void Remove(int id)
        {
            var drog = _ctx.Drogarias.FirstOrDefault(c => c.Id == id);

            if (drog != null)
            {
                _ctx.Drogarias.Remove(drog);
                _ctx.SaveChanges();
            }
        }

        public void Update(Drogaria drogaria)
        {
            _ctx.Drogarias.Update(drogaria);
            _ctx.SaveChanges();
        }
    }
}