using System.Collections.Generic;
using CampanhaInfopharma.Models.dbGestao;

namespace CampanhaInfopharma.Models
{
    public class DashboardDTO
    {
        public List<ResultadosUsuario> DadosUsuarios { get; set; }
        public int TotalDrogariasContactadas { get; set; }
        public int TotalDrogariasNaoContactadas { get; set; }
        public int TotalContratosFechados { get; set; }
    }

    public class ResultadosUsuario
    {
        public Usuario Usuario { get; set; }
        public int DrogariasContactadas { get; set; }
        public int DrogariasContactadasNoDia { get; set; }
        public int ContratosFechados { get; set; }
    }
}