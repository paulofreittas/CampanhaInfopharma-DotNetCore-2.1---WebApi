using System.Collections.Generic;
using CampanhaInfopharma.Models;
using CampanhaInfopharma.Models.dbGestao;

namespace CampanhaInfopharma.IRepository
{
    public interface IContatoDrogariaRepository
    {
        void Add(Contatousuariocampanha contatoDrogaria);
        // ContatoDrogaria Find(int id);
        // IEnumerable<ContatoDrogaria> FindByDrogariaId(int drogariaId);
        // KeyValuePair<int, IEnumerable<ContatoDrogaria>> FindByFuncionarioId(int funcionarioId, string search, int page);
        // IEnumerable<ContatoDrogaria> GetAll();
        // void Remove (int id);
        // void DeleteAllByFuncionarioId(int id);
        // void Update (ContatoDrogaria contatoDrogaria);
    }
}