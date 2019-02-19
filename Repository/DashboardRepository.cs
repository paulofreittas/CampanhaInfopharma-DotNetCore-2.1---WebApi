using System;
using System.Collections.Generic;
using System.Linq;
using CampanhaInfopharma.EFContext;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using Microsoft.EntityFrameworkCore;

namespace CampanhaInfopharma.Repository
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly dbGestaoContext _ctx;
        public DashboardRepository(dbGestaoContext ctx)
        {
            _ctx = ctx;
        }
        public DashboardDTO GetResults()
        {
            var dataAtual = DateTime.Now.Date;
            var inicioCampanha = new DateTime(2018, 8, 1);
            var finalCampanha = new DateTime(2019, 1, 30);
            var result = new DashboardDTO();

            result.DadosUsuarios = new List<ResultadosUsuario>();

            result.TotalDrogariasContactadas = _ctx.Cliente.Include(x => x.Contatousuariocampanha)
                                           .ThenInclude(x => x.UsuarioIdFkNavigation)
                                           .Where(x => x.Inativo == false)
                                           .Where(x => x.Contatousuariocampanha.Any()).Count();
            result.TotalDrogariasNaoContactadas = _ctx.Cliente.Include(x => x.Contatousuariocampanha)
                                           .ThenInclude(x => x.UsuarioIdFkNavigation)
                                           .Where(x => x.Inativo == false)
                                           .Where(x => !x.Contatousuariocampanha.Any()).Count();

            var users = _ctx.Usuario.Where(x => x.Inativo == false).ToList();

            foreach (var user in users)
            {
                var dadosUser = new ResultadosUsuario();

                dadosUser.Usuario = user;

                dadosUser.DrogariasContactadas = _ctx.Contatousuariocampanha.Include(x => x.ClienteIdFkNavigation)
                                                 .Where(x => x.UsuarioIdFkNavigation.IdPk == user.IdPk)
                                                 .GroupBy(x => x.ClienteIdFk).Count();

                dadosUser.DrogariasContactadasNoDia = _ctx.Contatousuariocampanha.Include(x => x.ClienteIdFkNavigation)
                                                 .Where(x => x.UsuarioIdFkNavigation.IdPk == user.IdPk)
                                                 .Where(x => x.DataInclusao >= dataAtual)
                                                 .GroupBy(x => x.ClienteIdFk).Count();

                dadosUser.ContratosFechados = _ctx.Contrato.Include(x => x.PropostaIdFkNavigation)
                                                           .ThenInclude(x => x.UsuarioIdFkNavigation)
                                                           .Where(x => x.TipoFechamentoContrato == 3 || x.EntrouNaCampanha == true)
                                                           .Where(x => x.PropostaIdFkNavigation.UsuarioIdFkNavigation.IdPk == user.IdPk)
                                                           .Where(x => x.DataInclusao >= inicioCampanha && x.DataInclusao <= finalCampanha).Count();

                result.DadosUsuarios.Add(dadosUser);

                result.TotalContratosFechados = result.TotalContratosFechados + dadosUser.ContratosFechados;
            }

            result.DadosUsuarios = result.DadosUsuarios.OrderByDescending(x => x.ContratosFechados).ToList();

            return result;
        }
    }
}