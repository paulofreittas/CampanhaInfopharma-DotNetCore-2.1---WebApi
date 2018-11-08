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

        public KeyValuePair<int, IEnumerable<Drogaria>> GetWithParams(string search, int page)
        {
            int numeroItens = 0;

            if (string.IsNullOrEmpty(search))
            {
                numeroItens = _ctx.Drogarias.Include(x => x.Funcionario).Count();
                return new KeyValuePair<int, IEnumerable<Drogaria>>(numeroItens, _ctx.Drogarias.Include(x => x.Funcionario).Skip(25*(page)).Take(25).ToList());
            }

            numeroItens = _ctx.Drogarias.Include(x => x.Funcionario).FromSql($"SELECT * FROM dbo.Drogaria where RazaoSocial like '%{search}%' or NomeFantasia like '%{search}%' or CNPJ like '%{search}%' or NomeContato like '%{search}%' or Cidade like '%{search}%' or Estado like '%{search}%'", search).Count();
            return new KeyValuePair<int, IEnumerable<Drogaria>>(numeroItens, _ctx.Drogarias.FromSql($"SELECT * FROM dbo.Drogaria where RazaoSocial like '%{search}%' or NomeFantasia like '%{search}%' or CNPJ like '%{search}%' or NomeContato like '%{search}%' or Cidade like '%{search}%' or Estado like '%{search}%'", search).Include(x => x.Funcionario).Skip(25*(page)).Take(25).ToList());
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