using System.Collections.Generic;
using System.Linq;
using CampanhaInfopharma.EFContext;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using CampanhaInfopharma.Models.dbGestao;
using Microsoft.EntityFrameworkCore;

namespace CampanhaInfopharma.Repository
{
    public class ContatoDrogariaRepository : IContatoDrogariaRepository
    {
        private readonly dbGestaoContext _ctx;
        public ContatoDrogariaRepository(dbGestaoContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Contatousuariocampanha contatoDrogaria)
        {
            _ctx.Contatousuariocampanha.Add(contatoDrogaria);
            _ctx.SaveChanges();
        }

        public Contatousuariocampanha Find(int id)
        {
            return _ctx.Contatousuariocampanha.FirstOrDefault(c => c.IdPk == id);
        }

        public KeyValuePair<int, IEnumerable<Contatousuariocampanha>> FindByFuncionarioId(int funcionarioId, int status, string search, int page) {
            int numeroItens = 0;

            if (string.IsNullOrEmpty(search))
            {
                if (status == 0)
                {
                    var result = _ctx.Contatousuariocampanha.FromSql("select * from CONTATOUSUARIOCAMPANHA where id_pk in " +
                                                                "(select Max(cup.id_pk) from CONTATOUSUARIOCAMPANHA cup " +
		                                                        "inner join cliente c on cup.cliente_id_fk = c.Id_pk " +
		                                                        "inner join cidade cd on c.cidade_id_fk = cd.Id_pk " +
		                                                        "where cup.usuario_id_fk = {0} " + 
		                                                        "group by cup.cliente_id_fk)", funcionarioId).
                                                                OrderByDescending(x => x.DataAlteracao).
                                                                Include(x => x.ClienteIdFkNavigation).
                                                                ThenInclude(x => x.CidadeIdFkNavigation).
                                                                Include(x => x.UsuarioIdFkNavigation).
                                                                Skip(15 * (page)).Take(15).ToList();
                    numeroItens = result.Count();                             
                    return new KeyValuePair<int, IEnumerable<Contatousuariocampanha>>(numeroItens, result);
                } else {
                    var result = _ctx.Contatousuariocampanha.FromSql("select * from CONTATOUSUARIOCAMPANHA where id_pk in " +
                                                                "(select Max(cup.id_pk) from CONTATOUSUARIOCAMPANHA cup " +
		                                                        "inner join cliente c on cup.cliente_id_fk = c.Id_pk " +
		                                                        "inner join cidade cd on c.cidade_id_fk = cd.Id_pk " +
		                                                        "where cup.usuario_id_fk = {0} " + 
		                                                        "group by cup.cliente_id_fk) and status = {1} ", funcionarioId, status).
                                                                OrderBy(x => x.DataRetorno).
                                                                Include(x => x.ClienteIdFkNavigation).
                                                                ThenInclude(x => x.CidadeIdFkNavigation).
                                                                Include(x => x.UsuarioIdFkNavigation).
                                                                Skip(15 * (page)).Take(15).ToList();
                    numeroItens = result.Count();                             
                    return new KeyValuePair<int, IEnumerable<Contatousuariocampanha>>(numeroItens, result);
                }
            }
            else {
                if (status == 0)
                {
                    var result = _ctx.Contatousuariocampanha.FromSql(string.Format("select * from CONTATOUSUARIOCAMPANHA where id_pk in " +
                                                                "(select Max(cup.id_pk) from CONTATOUSUARIOCAMPANHA cup " +
		                                                        "inner join cliente c on cup.cliente_id_fk = c.Id_pk " +
		                                                        "inner join cidade cd on c.cidade_id_fk = cd.Id_pk " +
		                                                        "where cup.usuario_id_fk = {0} " + 
                                                                "and (c.razao_social like '%{1}%' or " + 
                                                                "c.nome_fantasia like '%{1}%' or " +
                                                                "c.cnpj like '%{1}%' or " + 
                                                                "c.nome_contato_drogaria like '%{1}%' or " +
                                                                "cd.nome_cidade like '%{1}%')" +
		                                                        "group by cup.cliente_id_fk) ", funcionarioId, search)).
                                                                OrderByDescending(x => x.DataAlteracao).
                                                                Include(x => x.ClienteIdFkNavigation).
                                                                ThenInclude(x => x.CidadeIdFkNavigation).
                                                                Include(x => x.UsuarioIdFkNavigation).
                                                                Skip(15 * (page)).Take(15).ToList();
                    numeroItens = result.Count();                             
                    return new KeyValuePair<int, IEnumerable<Contatousuariocampanha>>(numeroItens, result);
                }
                else {
                    var result = _ctx.Contatousuariocampanha.FromSql(string.Format("select * from CONTATOUSUARIOCAMPANHA where id_pk in " +
                                                                "(select Max(cup.id_pk) from CONTATOUSUARIOCAMPANHA cup " +
		                                                        "inner join cliente c on cup.cliente_id_fk = c.Id_pk " +
		                                                        "inner join cidade cd on c.cidade_id_fk = cd.Id_pk " +
		                                                        "where cup.usuario_id_fk = {0} " + 
                                                                "and (c.razao_social like '%{2}%' or " + 
                                                                "c.nome_fantasia like '%{2}%' or " +
                                                                "c.cnpj like '%{2}%' or " + 
                                                                "c.nome_contato_drogaria like '%{2}%' or " +
                                                                "cd.nome_cidade like '%{2}%')" +
		                                                        "group by cup.cliente_id_fk) and status = {1} ", funcionarioId, status, search)).
                                                                OrderBy(x => x.DataRetorno).
                                                                Include(x => x.ClienteIdFkNavigation).
                                                                ThenInclude(x => x.CidadeIdFkNavigation).
                                                                Include(x => x.UsuarioIdFkNavigation).
                                                                Skip(15 * (page)).Take(15).ToList();
                    numeroItens = result.Count();                             
                    return new KeyValuePair<int, IEnumerable<Contatousuariocampanha>>(numeroItens, result);
                }
                
            }
        }

        public IEnumerable<Contatousuariocampanha> FindByDrogariaId(int drogariaId) {
            return _ctx.Contatousuariocampanha.Where(c => c.ClienteIdFk == drogariaId).Include(x => x.ClienteIdFkNavigation).Include(x => x.UsuarioIdFkNavigation);
        }

        // public IEnumerable<ContatoDrogaria> GetAll()
        // {
        //     return _ctx.ContatoDrogarias.Include(c => c.Drogaria).ThenInclude(c => c.Funcionario).ToList();
        // }

        public void Remove(int id)
        {
            var contatoDrog = _ctx.Contatousuariocampanha.FirstOrDefault(c => c.IdPk == id);

            if (contatoDrog != null)
            {
                _ctx.Contatousuariocampanha.Remove(contatoDrog);
                _ctx.SaveChanges();
            }
        }

        // public void DeleteAllByFuncionarioId(int id)
        // {
        //     var drogs = _ctx.Drogarias.Where(x => x.FuncionarioIdFk == id);
        //     var contatoDrogs = _ctx.ContatoDrogarias.FromSql("SELECT * FROM ContatoDrogaria WHERE DrogariaIdFk in (SELECT id FROM Drogaria WHERE FuncionarioIdFk = {0})", id).ToList();

        //     foreach (var cd in contatoDrogs)
        //     {
        //         _ctx.ContatoDrogarias.Remove(cd);
        //     }

        //     foreach (var drog in drogs)
        //     {
        //         drog.FuncionarioIdFk = null;
        //         _ctx.Drogarias.Update(drog);  
        //     }

        //     _ctx.SaveChanges();
        // }

        // public void Update(ContatoDrogaria contatoDrogaria)
        // {
        //     _ctx.ContatoDrogarias.Update(contatoDrogaria);
        //     _ctx.SaveChanges();
        // }
    }
}