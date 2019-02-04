using System.Collections.Generic;

namespace CampanhaInfopharma.Models
{
    public class DashboardDTO
    {
        public List<ResultadosUsuario> DadosUsuarios { get; set; }
        public int TotalDrogariasContactadas { get; set; }
        public int TotalDrogariasNaoContactadas { get; set; }
    }

    public class ResultadosUsuario
    {
        public int DrogariasContactadas { get; set; }   
        public int DrogariasContactadasNoDia { get; set; }
        public int ContratosFechados { get; set; }
    }
}