using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Agendamentoemail
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string TituloEmail { get; set; }
        public string ImagemEmailUrl { get; set; }
        public string ImagemEmailLink { get; set; }
        public string ArquivoEmailsPath { get; set; }
        public DateTime? DataEnvioEmail { get; set; }
        public int? DiaSemanaEnvioEmail { get; set; }
        public int? NumeroSemanaEnvioEmail { get; set; }
        public int? IntervaloEntreEnvios { get; set; }
        public DateTime? DataUltimoEnvioFeito { get; set; }
        public int? ServicoIdFk { get; set; }
        public string TextoEmail { get; set; }

        public Servico ServicoIdFkNavigation { get; set; }
    }
}
