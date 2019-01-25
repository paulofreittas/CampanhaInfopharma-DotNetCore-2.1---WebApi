using System.Collections.Generic;
using CampanhaInfopharma.Models;
using CampanhaInfopharma.Models.dbGestao;

namespace CampanhaInfopharma.IRepository
{
    public interface IClienteRepository
    {
        Cliente Find(int id);
        DrogariaDTO GetWithParams(string search, bool semFuncVinculado, int page);

    }
}