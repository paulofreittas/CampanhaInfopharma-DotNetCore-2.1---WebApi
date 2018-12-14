using System.Collections.Generic;
using CampanhaInfopharma.Models;

namespace CampanhaInfopharma.IRepository
{
    public interface IFuncionarioRepository
    {
         void Add(Funcionario funcionario);
         IEnumerable<Funcionario> GetAll();
         IEnumerable<Funcionario> GetWithParams(string search);
         Funcionario Find(int id);
         void Remove(int id);
         void Update(Funcionario funcionario);
    }
}