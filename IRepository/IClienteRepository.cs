using System.Collections.Generic;
using CampanhaInfopharma.Models.dbGestao;

namespace CampanhaInfopharma.IRepository
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetAll();
    }
}