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

        public KeyValuePair<int, IEnumerable<Drogaria>> GetWithParams(string search, bool semFuncVinculado, int page)
        {
            int numeroItens = 0;
            string select = "SELECT * FROM dbo.Drogaria ";
            string where = string.Format("where (RazaoSocial like '%{0}%' or NomeFantasia like '%{0}%' or CNPJ like '%{0}%' or NomeContato like '%{0}%' or Cidade like '%{0}%' or Estado like '%{0}%') ", search);
            string and = "and funcionarioIdFk is null";

            if (semFuncVinculado)
            {
                if(string.IsNullOrEmpty(search))
                {
                    numeroItens = _ctx.Drogarias.Include(x => x.Funcionario).Where(x => x.FuncionarioIdFk == null).Count();
                    return new KeyValuePair<int, IEnumerable<Drogaria>>(numeroItens, _ctx.Drogarias.Include(x => x.Funcionario).Where(x => x.FuncionarioIdFk == null).Skip(15*(page)).Take(15).ToList());
                }
                else {
                    numeroItens = _ctx.Drogarias.Include(x => x.Funcionario).FromSql(select + where + and).Count();
                    return new KeyValuePair<int, IEnumerable<Drogaria>>(numeroItens, _ctx.Drogarias.FromSql(select + where + and).Include(x => x.Funcionario).Skip(15*(page)).Take(15).ToList());
                } 
            }
            else {
                if (string.IsNullOrEmpty(search))
                {
                    numeroItens = _ctx.Drogarias.Include(x => x.Funcionario).Count();
                    return new KeyValuePair<int, IEnumerable<Drogaria>>(numeroItens, _ctx.Drogarias.Include(x => x.Funcionario).Skip(15*(page)).Take(15).ToList());
                }
                else {
                    numeroItens = _ctx.Drogarias.Include(x => x.Funcionario).FromSql(select + where).Count();
                    return new KeyValuePair<int, IEnumerable<Drogaria>>(numeroItens, _ctx.Drogarias.FromSql(select + where).Include(x => x.Funcionario).Skip(15*(page)).Take(15).ToList());
                }
            }
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