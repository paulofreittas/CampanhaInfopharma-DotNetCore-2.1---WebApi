using System.Collections.Generic;
using System.Linq;
using CampanhaInfopharma.EFContext;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using Microsoft.EntityFrameworkCore;

namespace CampanhaInfopharma.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly Context _ctx;
        public FuncionarioRepository(Context ctx)
        {
            _ctx = ctx;
        }

        public void Add(Funcionario funcionario)
        {
            _ctx.Funcionarios.Add(funcionario);
            _ctx.SaveChanges();
        }

        public Funcionario Find(int id)
        {
            return _ctx.Funcionarios.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Funcionario> GetAll()
        {
            return _ctx.Funcionarios.ToList();
        }

        public IEnumerable<Funcionario> GetWithParams(string search)
        {
            return _ctx.Funcionarios.Where(x => x.Nome.Contains(search)).ToList();
        }

        public void Remove(int id)
        {
            var func = _ctx.Funcionarios.FirstOrDefault(c => c.Id == id);
            if (func != null)
            {
                _ctx.Funcionarios.Remove(func);
                _ctx.SaveChanges();
            }
        }

        public void Update(Funcionario funcionario)
        {
            _ctx.Funcionarios.Update(funcionario);
            _ctx.SaveChanges();
        }
    }
}