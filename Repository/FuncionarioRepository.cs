using System.Collections.Generic;
using System.Linq;
using CampanhaInfopharma.EFContext;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using CampanhaInfopharma.Models.dbGestao;
using Microsoft.EntityFrameworkCore;

namespace CampanhaInfopharma.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly dbGestaoContext _ctx;
        public FuncionarioRepository(dbGestaoContext ctx)
        {
            _ctx = ctx;
        }

        // public void Add(Funcionario funcionario)
        // {
        //     _ctx.Funcionarios.Add(funcionario);
        //     _ctx.SaveChanges();
        // }

        public Usuario Find(int id)
        {
            return _ctx.Usuario.FirstOrDefault(c => c.IdPk == id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _ctx.Usuario.Where(x => x.Inativo == false).ToList();
        }

        public IEnumerable<Usuario> GetWithParams(string search)
        {
            return _ctx.Usuario.Where(x => x.Nome.Contains(search) ||
                                           x.Username.Contains(search))
                               .Where(x => x.Inativo == false).ToList();
        }

        // public void Remove(int id)
        // {
        //     var func = _ctx.Funcionarios.FirstOrDefault(c => c.Id == id);
        //     if (func != null)
        //     {
        //         _ctx.Funcionarios.Remove(func);
        //         func = null;
        //         _ctx.SaveChanges();
        //     }
        // }

        public void Update(Usuario funcionario)
        {
            var user = _ctx.Usuario.Find(funcionario.IdPk);

            user.Username = funcionario.Username;
            user.Nome = funcionario.Nome;
            user.Password = funcionario.Password;
            user.Cor = funcionario.Cor;

            _ctx.Usuario.Update(user);
            _ctx.SaveChanges();
        }
    }
}