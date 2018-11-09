using System.Collections.Generic;
using CampanhaInfopharma.Models;

namespace CampanhaInfopharma.IRepository
{
    public interface IDrogariaRepository
    {
         void Add(Drogaria drogaria);
         IEnumerable<Drogaria> GetAll();
         KeyValuePair<int, IEnumerable<Drogaria>> GetWithParams(string search, bool funcVinculado, int page);
         Drogaria Find(int id);
         void Remove(int id);
         void Update(Drogaria drogaria);
    }
}