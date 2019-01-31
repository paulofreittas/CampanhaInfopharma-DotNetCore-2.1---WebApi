using System.Collections.Generic;
using CampanhaInfopharma.Models;
using CampanhaInfopharma.Models.dbGestao;

namespace CampanhaInfopharma.IRepository
{
    public interface IFuncionarioRepository
    {
         //void Add(Funcionario funcionario);
         IEnumerable<Usuario> GetAll();
         IEnumerable<Usuario> GetWithParams(string search);
         Usuario Find(int id);
         void Remove(int id);
         void Update(Usuario funcionario);
    }
}