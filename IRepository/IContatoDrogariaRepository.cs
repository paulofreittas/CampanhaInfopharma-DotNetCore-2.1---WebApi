using System.Collections.Generic;
using CampanhaInfopharma.Models;
using CampanhaInfopharma.Models.dbGestao;

namespace CampanhaInfopharma.IRepository
{
    public interface IContatoDrogariaRepository
    {
        void Add(Contatousuariocampanha contatoDrogaria);
        Contatousuariocampanha Find(int id);
        IEnumerable<Contatousuariocampanha> FindByDrogariaId(int drogariaId);
        KeyValuePair<int, IEnumerable<Contatousuariocampanha>> FindByFuncionarioId(int funcionarioId, int status, string search, int page);
        // IEnumerable<ContatoDrogaria> GetAll();
        void Remove (int id);
        // void DeleteAllByFuncionarioId(int id);
        // void Update (ContatoDrogaria contatoDrogaria);
    }
}