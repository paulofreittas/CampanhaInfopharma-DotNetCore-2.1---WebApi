using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Tecnico
    {
        public Tecnico()
        {
            Horario = new HashSet<Horario>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool? Socio { get; set; }
        public int? DataPrimeiroRegistro { get; set; }
        public int? ClienteIdFk { get; set; }
        public int? ResponsavelIdFk { get; set; }
        public bool? CadastradoNoPbm { get; set; }
        public bool? TecnicoPop { get; set; }
        public string HorarioSegundaManha { get; set; }
        public string HorarioSegundaTarde { get; set; }
        public string HorarioTercaManha { get; set; }
        public string HorarioTecaTarde { get; set; }
        public string HorarioQuartaManha { get; set; }
        public string HorarioQuartaTarde { get; set; }
        public string HorarioQuintaManha { get; set; }
        public string HorarioQuintaTarde { get; set; }
        public string HorarioSextaManha { get; set; }
        public string HorarioSextaTarde { get; set; }
        public string HorarioSabadoManha { get; set; }
        public string HorarioSabadoTarde { get; set; }
        public string HorarioDomingoManha { get; set; }
        public string HorarioDomingoTarde { get; set; }
        public decimal? Salario { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Responsavel ResponsavelIdFkNavigation { get; set; }
        public ICollection<Horario> Horario { get; set; }
    }
}
