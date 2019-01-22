using System.Collections.Generic;
using CampanhaInfopharma.Models.dbGestao;

namespace CampanhaInfopharma.IRepository
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetAll();
        Cliente Find(int id);
        KeyValuePair<int, IEnumerable<Cliente>> GetWithParams(string search, bool semFuncVinculado, int page);

    }
}