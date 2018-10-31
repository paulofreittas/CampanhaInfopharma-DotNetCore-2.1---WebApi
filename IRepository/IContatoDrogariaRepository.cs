using System.Collections.Generic;
using CampanhaInfopharma.Models;

namespace CampanhaInfopharma.IRepository
{
    public interface IContatoDrogariaRepository
    {
        void Add(ContatoDrogaria contatoDrogaria);
        ContatoDrogaria Find(int id);
        IEnumerable<ContatoDrogaria> GetAll();
        void Remove (int id);
        void Update (ContatoDrogaria contatoDrogaria);
    }
}