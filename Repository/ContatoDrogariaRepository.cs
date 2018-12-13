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
            return _ctx.ContatoDrogarias.Include(c => c.Drogaria).FirstOrDefault(c => c.Id == id);
        }

        public KeyValuePair<int, IEnumerable<ContatoDrogaria>> FindByFuncionarioId(int funcionarioId, string search, int page) {
            int numeroItens = 0;

            if (string.IsNullOrEmpty(search))
            {
                numeroItens = _ctx.ContatoDrogarias.FromSql("select * from dbo.ContatoDrogaria where Id in (select MAX(cd.Id) from dbo.ContatoDrogaria cd inner join dbo.Drogaria d on d.Id = DrogariaIdFk where FuncionarioIdFk = {0} group by DrogariaIdFk)", funcionarioId).Count();
                return new KeyValuePair<int, IEnumerable<ContatoDrogaria>>(numeroItens, _ctx.ContatoDrogarias.FromSql("select * from dbo.ContatoDrogaria where Id in (select MAX(cd.Id) from dbo.ContatoDrogaria cd inner join dbo.Drogaria d on d.Id = DrogariaIdFk where FuncionarioIdFk = {0} group by DrogariaIdFk)", funcionarioId).Include(x => x.Drogaria).OrderByDescending(x => x.DataAlteracao).Skip(15*(page)).Take(15).ToList());
            }
            else {
                numeroItens = _ctx.ContatoDrogarias.FromSql(string.Format("select * from dbo.ContatoDrogaria where Id in (select MAX(cd.Id) from dbo.ContatoDrogaria cd inner join dbo.Drogaria d on d.Id = DrogariaIdFk where FuncionarioIdFk = {0} and (d.RazaoSocial like '%{1}%' or d.NomeFantasia like '%{1}%' or d.CNPJ like '%{1}%' or d.NomeContato like '%{1}%' or d.Cidade like '%{1}%' or d.Estado like '%{1}%')  group by DrogariaIdFk)", funcionarioId, search)).Include(x => x.Drogaria).OrderByDescending(x => x.DataAlteracao).Count();
                return new KeyValuePair<int, IEnumerable<ContatoDrogaria>>(numeroItens, _ctx.ContatoDrogarias.FromSql(string.Format("select * from dbo.ContatoDrogaria where Id in (select MAX(cd.Id) from dbo.ContatoDrogaria cd inner join dbo.Drogaria d on d.Id = DrogariaIdFk where FuncionarioIdFk = {0} and (d.RazaoSocial like '%{1}%' or d.NomeFantasia like '%{1}%' or d.CNPJ like '%{1}%' or d.NomeContato like '%{1}%' or d.Cidade like '%{1}%' or d.Estado like '%{1}%')  group by DrogariaIdFk)", funcionarioId, search)).Include(x => x.Drogaria).OrderByDescending(x => x.DataAlteracao).ToList());
            }
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
            var contatoDrog = _ctx.ContatoDrogarias.FirstOrDefault(c => c.Id == id);

            if (contatoDrog != null)
            {
                _ctx.ContatoDrogarias.Remove(contatoDrog);
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