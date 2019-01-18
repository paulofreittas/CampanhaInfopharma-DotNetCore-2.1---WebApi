using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Pops
    {
        public Pops()
        {
            Cliente = new HashSet<Cliente>();
            Itemservicospop = new HashSet<Itemservicospop>();
        }

        public int IdPk { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool? HigieneVestConduta { get; set; }
        public bool? Biosseguranca { get; set; }
        public bool? AfericaoPressao { get; set; }
        public bool? RecebimentoArmazenamento { get; set; }
        public bool? ConferenciaDispensacao { get; set; }
        public bool? ControleTempGeladeira { get; set; }
        public bool? LavagemMaos { get; set; }
        public bool? Limpeza { get; set; }
        public bool? AplicacaoInjetaveis { get; set; }
        public bool? MedProximoVencimento { get; set; }
        public bool? Treinamento { get; set; }
        public bool? MonitoramentoGlicemia { get; set; }
        public bool? LimpezaCaixaDagua { get; set; }
        public bool? TemperaturaCorporal { get; set; }
        public bool? PerfuracaoLobulo { get; set; }
        public bool? ControlePragas { get; set; }
        public bool? Fracionados { get; set; }
        public bool? ConfDispAntiMicrobianos { get; set; }
        public bool? ControleTempAmbiente { get; set; }
        public bool? AquisicaoProdsEMedcs { get; set; }
        public string HorarioGeladeira1 { get; set; }
        public string HorarioGeladeira2 { get; set; }
        public string HorarioLimpezaDrogaria1 { get; set; }
        public string HorarioLimpezaDrogaria2 { get; set; }
        public string HorarioVerificaTemp1 { get; set; }
        public string HorarioVerificaTemp2 { get; set; }
        public string HorarioLimpezaInjetaveis1 { get; set; }
        public string HorarioLimpezaInjetaveis2 { get; set; }
        public int? RetirarMesesAntesVencimento { get; set; }
        public int? AparelhoGlicemia { get; set; }
        public bool? ReceitaBranca { get; set; }
        public bool? ReceitaA { get; set; }
        public bool? ReceitaB1 { get; set; }
        public bool? ReceitaB2 { get; set; }
        public bool? Climatizador { get; set; }
        public bool? DesabilitarOpcoesPop { get; set; }
        public string ArmazenamentoInternoInfectante { get; set; }
        public string ArmazenamentoInternoQuimico { get; set; }
        public int? ClienteIdFk { get; set; }
        public string FrequenciaColetaComum { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Itemservicospop> Itemservicospop { get; set; }
    }
}
