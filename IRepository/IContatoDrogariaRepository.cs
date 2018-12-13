using System.Collections.Generic;
using CampanhaInfopharma.Models;

namespace CampanhaInfopharma.IRepository
{
    public interface IContatoDrogariaRepository
    {
        void Add(ContatoDrogaria contatoDrogaria);
        ContatoDrogaria Find(int id);
        IEnumerable<ContatoDrogaria> FindByDrogariaId(int drogariaId);
        KeyValuePair<int, IEnumerable<ContatoDrogaria>> FindByFuncionarioId(int funcionarioId, string search, int page);
        IEnumerable<ContatoDrogaria> GetAll();
        void Remove (int id);
        void Update (ContatoDrogaria contatoDrogaria);
    }
}