using System.Linq;
using CampanhaInfopharma.EFContext;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using Microsoft.EntityFrameworkCore;

namespace CampanhaInfopharma.Repository
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly Context _ctx;
        public DashboardRepository(Context ctx)
        {
            _ctx = ctx;
        }
        public DashboardDTO GetResults()
        {
            var result = new DashboardDTO();

            result.TotalDrogariasContactadas = _ctx.Drogarias.Include(x => x.Funcionario).Where(x => x.FuncionarioIdFk != null).Count();
            result.TotalDrogariasNaoContactadas = _ctx.Drogarias.Include(x => x.Funcionario).Where(x => x.FuncionarioIdFk == null).Count();
        }
    }
}