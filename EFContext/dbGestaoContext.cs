using CampanhaInfopharma.Models.dbGestao;
using Microsoft.EntityFrameworkCore;

namespace CampanhaInfopharma.EFContext
{
    public partial class dbGestaoContext : DbContext
    {
        public dbGestaoContext()
        {
        }

        public dbGestaoContext(DbContextOptions<dbGestaoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abrangenciaservico> Abrangenciaservico { get; set; }
        public virtual DbSet<Agendamentoemail> Agendamentoemail { get; set; }
        public virtual DbSet<Agendamentoenviopropostas> Agendamentoenviopropostas { get; set; }
        public virtual DbSet<Agendamentoligacao> Agendamentoligacao { get; set; }
        public virtual DbSet<Anexodocumento> Anexodocumento { get; set; }
        public virtual DbSet<Anotacaoos> Anotacaoos { get; set; }
        public virtual DbSet<Anotacaoproposta> Anotacaoproposta { get; set; }
        public virtual DbSet<Apresentacao> Apresentacao { get; set; }
        public virtual DbSet<Apresentacaodocumentos> Apresentacaodocumentos { get; set; }
        public virtual DbSet<Areaservico> Areaservico { get; set; }
        public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }
        public virtual DbSet<Bairro> Bairro { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<Campanharenovacao> CampanhaRenovacao { get; set; }
        public virtual DbSet<Cedente> Cedente { get; set; }
        public virtual DbSet<Cheque> Cheque { get; set; }
        public virtual DbSet<Cidade> Cidade { get; set; }
        public virtual DbSet<Cidadeabrangencia> Cidadeabrangencia { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Clienteservicosexistentes> Clienteservicosexistentes { get; set; }
        public virtual DbSet<Clientesimmeds> Clientesimmeds { get; set; }
        public virtual DbSet<Codigodistribuidora> Codigodistribuidora { get; set; }
        public virtual DbSet<Colaboradoreslanche> Colaboradoreslanche { get; set; }
        public virtual DbSet<Coleta> Coleta { get; set; }
        public virtual DbSet<Comissaousuario> Comissaousuario { get; set; }
        public virtual DbSet<Configuracaodescontocliente> Configuracaodescontocliente { get; set; }
        public virtual DbSet<Configuracoes> Configuracoes { get; set; }
        public virtual DbSet<Configuracoesdinamicas> Configuracoesdinamicas { get; set; }
        public virtual DbSet<Configuracoesweb> Configuracoesweb { get; set; }
        public virtual DbSet<Conta> Conta { get; set; }
        public virtual DbSet<Contato> Contato { get; set; }
        public virtual DbSet<Contatousuariocampanha> Contatousuariocampanha { get; set; }
        public virtual DbSet<Contrato> Contrato { get; set; }
        public virtual DbSet<Contratoparcelas> Contratoparcelas { get; set; }
        public virtual DbSet<Dadopesquisa> Dadopesquisa { get; set; }
        public virtual DbSet<Dadoprocesso> Dadoprocesso { get; set; }
        public virtual DbSet<Distribuidora> Distribuidora { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<Documentoservico> Documentoservico { get; set; }
        public virtual DbSet<Emailmarketing> Emailmarketing { get; set; }
        public virtual DbSet<Emailscobranca> Emailscobranca { get; set; }
        public virtual DbSet<Empresasoftwaregestao> Empresasoftwaregestao { get; set; }
        public virtual DbSet<Faq> Faq { get; set; }
        public virtual DbSet<Formulariopbm> Formulariopbm { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<Grupoordem> Grupoordem { get; set; }
        public virtual DbSet<Gruposervico> Gruposervico { get; set; }
        public virtual DbSet<Historicoafe> Historicoafe { get; set; }
        public virtual DbSet<Historicofp> Historicofp { get; set; }
        public virtual DbSet<Historicofpdou> Historicofpdou { get; set; }
        public virtual DbSet<Historicoliberacaopbm> Historicoliberacaopbm { get; set; }
        public virtual DbSet<Historiconovosservicos> Historiconovosservicos { get; set; }
        public virtual DbSet<Historicopropostas> Historicopropostas { get; set; }
        public virtual DbSet<Historicosifap> Historicosifap { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Hospital> Hospital { get; set; }
        public virtual DbSet<Incineradora> Incineradora { get; set; }
        public virtual DbSet<InfopharmaUsers> InfopharmaUsers { get; set; }
        public virtual DbSet<Itemdado> Itemdado { get; set; }
        public virtual DbSet<Itemdadopesquisa> Itemdadopesquisa { get; set; }
        public virtual DbSet<Itemservicospop> Itemservicospop { get; set; }
        public virtual DbSet<Lancamento> Lancamento { get; set; }
        public virtual DbSet<Lancamentoinativo> Lancamentoinativo { get; set; }
        public virtual DbSet<Lanche> Lanche { get; set; }
        public virtual DbSet<Legal> Legal { get; set; }
        public virtual DbSet<Ligacao> Ligacao { get; set; }
        public virtual DbSet<Logalteracoesfinanceiro> Logalteracoesfinanceiro { get; set; }
        public virtual DbSet<Logalteracoessistema> Logalteracoessistema { get; set; }
        public virtual DbSet<Logerrosservicoswindows> Logerrosservicoswindows { get; set; }
        public virtual DbSet<Logexclusoessistema> Logexclusoessistema { get; set; }
        public virtual DbSet<Logsistema> Logsistema { get; set; }
        public virtual DbSet<Motivonaofechamentoproposta> Motivonaofechamentoproposta { get; set; }
        public virtual DbSet<Numerosequencialboleto> Numerosequencialboleto { get; set; }
        public virtual DbSet<Ordempesquisa> Ordempesquisa { get; set; }
        public virtual DbSet<Ordemservico> Ordemservico { get; set; }
        public virtual DbSet<Origemlancamento> Origemlancamento { get; set; }
        public virtual DbSet<Parcelamentojuros> Parcelamentojuros { get; set; }
        public virtual DbSet<Permissaousuario> Permissaousuario { get; set; }
        public virtual DbSet<Pesquisa> Pesquisa { get; set; }
        public virtual DbSet<Peticionamentosafependentes> Peticionamentosafependentes { get; set; }
        public virtual DbSet<Pgrssmbp> Pgrssmbp { get; set; }
        public virtual DbSet<Plano> Plano { get; set; }
        public virtual DbSet<Planocontas> Planocontas { get; set; }
        public virtual DbSet<Pontocliente> Pontocliente { get; set; }
        public virtual DbSet<Pops> Pops { get; set; }
        public virtual DbSet<Premio> Premio { get; set; }
        public virtual DbSet<Processo> Processo { get; set; }
        public virtual DbSet<Programaponto> Programaponto { get; set; }
        public virtual DbSet<Programapontotipoponto> Programapontotipoponto { get; set; }
        public virtual DbSet<Proposta> Proposta { get; set; }
        public virtual DbSet<Propostaservico> Propostaservico { get; set; }
        public virtual DbSet<Propostausuario> Propostausuario { get; set; }
        public virtual DbSet<Regracontrato> Regracontrato { get; set; }
        public virtual DbSet<Regracontratoparcela> Regracontratoparcela { get; set; }
        public virtual DbSet<Regrascontrato> Regrascontrato { get; set; }
        public virtual DbSet<Regrausuario> Regrausuario { get; set; }
        public virtual DbSet<Remessa> Remessa { get; set; }
        public virtual DbSet<Responsavel> Responsavel { get; set; }
        public virtual DbSet<Senhacliente> Senhacliente { get; set; }
        public virtual DbSet<Senhas> Senhas { get; set; }
        public virtual DbSet<Servico> Servico { get; set; }
        public virtual DbSet<Servicocontrato> Servicocontrato { get; set; }
        public virtual DbSet<Servicodocumentos> Servicodocumentos { get; set; }
        public virtual DbSet<Servicopop> Servicopop { get; set; }
        public virtual DbSet<Servicoproposta> Servicoproposta { get; set; }
        public virtual DbSet<Servicowindows> Servicowindows { get; set; }
        public virtual DbSet<Solicitacaocontrato> Solicitacaocontrato { get; set; }
        public virtual DbSet<Solicitacaodoc> Solicitacaodoc { get; set; }
        public virtual DbSet<Solicitacaopropostas> Solicitacaopropostas { get; set; }
        public virtual DbSet<Tecnico> Tecnico { get; set; }
        public virtual DbSet<Telasistema> Telasistema { get; set; }
        public virtual DbSet<Telefone> Telefone { get; set; }
        public virtual DbSet<Tipodocumentoservico> Tipodocumentoservico { get; set; }
        public virtual DbSet<Tipoponto> Tipoponto { get; set; }
        public virtual DbSet<Tiposenhacliente> Tiposenhacliente { get; set; }
        public virtual DbSet<Tiposervico> Tiposervico { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        // Unable to generate entity type for table 'dbo.CONTRATOSERVICO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CONTRATOORDEMSERVICO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EMAILMARKETINGSERVICO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Infopharma_UsersInRoles'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.USUARIOSERVICOSUSUARIO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.USUARIOSERVICOSCOMISSIONADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SERVICOABRANGENCIAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CONTRATOUSUARIOSCOMISSIONADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CONTRATOCOMISSIONADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SERVICONAOABRANGENCIAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DOCUMENTODADOSPROCESSO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SOLICITACAOPROPOSTASSERVICO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SOLICITACAOPROPOSTASSERVICOSDEVETER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SOLICITACAOPROPOSTASSERVICOSNAODEVETER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PLANOSERVICO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DOCUMENTOPROCESSOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SOLICITACAOPROPOSTASSERVICOSDEVETERVIGENTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SOLICITACAOPROPOSTASSERVICOSNAODEVETERVIGENTE'. Please see the warning messages.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abrangenciaservico>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("ABRANGENCIASERVICO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(150);

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.Property(e => e.TipoAbrangencia).HasColumnName("tipo_abrangencia");

                entity.Property(e => e.Uf).HasColumnName("uf");

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Abrangenciaservico)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FK7594034EB764A226");
            });

            modelBuilder.Entity<Agendamentoemail>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("AGENDAMENTOEMAIL");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ArquivoEmailsPath)
                    .HasColumnName("arquivo_emails_path")
                    .HasMaxLength(200);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEnvioEmail)
                    .HasColumnName("data_envio_email")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataUltimoEnvioFeito)
                    .HasColumnName("data_ultimo_envio_feito")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiaSemanaEnvioEmail).HasColumnName("dia_semana_envio_email");

                entity.Property(e => e.ImagemEmailLink)
                    .HasColumnName("imagem_email_link")
                    .HasMaxLength(300);

                entity.Property(e => e.ImagemEmailUrl)
                    .HasColumnName("imagem_email_url")
                    .HasMaxLength(300);

                entity.Property(e => e.IntervaloEntreEnvios).HasColumnName("intervalo_entre_envios");

                entity.Property(e => e.NumeroSemanaEnvioEmail).HasColumnName("numero_semana_envio_email");

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.Property(e => e.TextoEmail).HasColumnName("texto_email");

                entity.Property(e => e.TituloEmail)
                    .HasColumnName("titulo_email")
                    .HasMaxLength(200);

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Agendamentoemail)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FKFC884FD1513BC5B9");
            });

            modelBuilder.Entity<Agendamentoenviopropostas>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("AGENDAMENTOENVIOPROPOSTAS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiaDaSemana).HasColumnName("dia_da_semana");

                entity.Property(e => e.GrupoServicoIdFk).HasColumnName("grupo_servico_id_fk");

                entity.HasOne(d => d.GrupoServicoIdFkNavigation)
                    .WithMany(p => p.Agendamentoenviopropostas)
                    .HasForeignKey(d => d.GrupoServicoIdFk)
                    .HasConstraintName("FK921BE5893A13554C");
            });

            modelBuilder.Entity<Agendamentoligacao>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("AGENDAMENTOLIGACAO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAgendamento)
                    .HasColumnName("data_agendamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(255);

                entity.Property(e => e.NomeContato)
                    .IsRequired()
                    .HasColumnName("nome_contato")
                    .HasMaxLength(255);

                entity.Property(e => e.Vencido).HasColumnName("vencido");

                entity.Property(e => e.Visto).HasColumnName("visto");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Agendamentoligacao)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FK8E807667D64882D9");
            });

            modelBuilder.Entity<Anexodocumento>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("ANEXODOCUMENTO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentoIdFk).HasColumnName("documento_id_fk");

                entity.Property(e => e.TipoDocumentoServicoIdFk).HasColumnName("tipo_documento_servico_id_fk");

                entity.HasOne(d => d.DocumentoIdFkNavigation)
                    .WithMany(p => p.Anexodocumento)
                    .HasForeignKey(d => d.DocumentoIdFk)
                    .HasConstraintName("FK15167FD215CCCD1");

                entity.HasOne(d => d.TipoDocumentoServicoIdFkNavigation)
                    .WithMany(p => p.Anexodocumento)
                    .HasForeignKey(d => d.TipoDocumentoServicoIdFk)
                    .HasConstraintName("FK15167FDEB31F51");
            });

            modelBuilder.Entity<Anotacaoos>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("ANOTACAOOS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Anotacao)
                    .IsRequired()
                    .HasColumnName("anotacao")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrdemServicoIdFk).HasColumnName("ordem_servico_id_fk");

                entity.HasOne(d => d.OrdemServicoIdFkNavigation)
                    .WithMany(p => p.Anotacaoos)
                    .HasForeignKey(d => d.OrdemServicoIdFk)
                    .HasConstraintName("FKF5577964A4FD7F16");
            });

            modelBuilder.Entity<Anotacaoproposta>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("ANOTACAOPROPOSTA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Anotacao)
                    .IsRequired()
                    .HasColumnName("anotacao")
                    .HasMaxLength(600);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.PropostaIdFk).HasColumnName("proposta_id_fk");

                entity.HasOne(d => d.PropostaIdFkNavigation)
                    .WithMany(p => p.Anotacaoproposta)
                    .HasForeignKey(d => d.PropostaIdFk)
                    .HasConstraintName("FKDE39AE02959C9BDE");
            });

            modelBuilder.Entity<Apresentacao>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("APRESENTACAO");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("CNPJ")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Dataretorno)
                    .HasColumnName("DATARETORNO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100);

                entity.Property(e => e.Horaretorno)
                    .IsRequired()
                    .HasColumnName("HORARETORNO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nomecontato)
                    .IsRequired()
                    .HasColumnName("NOMECONTATO")
                    .HasMaxLength(50);

                entity.Property(e => e.Nomedrogaria)
                    .IsRequired()
                    .HasColumnName("NOMEDROGARIA")
                    .HasMaxLength(100);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasColumnName("TELEFONE")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Apresentacaodocumentos>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("APRESENTACAODOCUMENTOS");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Codapresentacao).HasColumnName("CODAPRESENTACAO");

                entity.Property(e => e.Coddocumento).HasColumnName("CODDOCUMENTO");

                entity.HasOne(d => d.CodapresentacaoNavigation)
                    .WithMany(p => p.Apresentacaodocumentos)
                    .HasForeignKey(d => d.Codapresentacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK516B1429561E4E21");

                entity.HasOne(d => d.CoddocumentoNavigation)
                    .WithMany(p => p.Apresentacaodocumentos)
                    .HasForeignKey(d => d.Coddocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK516B14297DA85D4D");
            });

            modelBuilder.Entity<Areaservico>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("AREASERVICO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoArea)
                    .IsRequired()
                    .HasColumnName("descricao_area")
                    .HasMaxLength(255);

                entity.Property(e => e.NomeArea)
                    .IsRequired()
                    .HasColumnName("nome_area")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<AspnetApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.ApplicationName)
                    .HasName("UQ__aspnet_A__3091033101142BA1")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName)
                    .HasName("aspnet_Applications_Index")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate })
                    .HasName("aspnet_Users_Index2");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName })
                    .HasName("aspnet_Users_Index")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__07C12930");
            });

            modelBuilder.Entity<Bairro>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("BAIRRO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.CidadeIdFk).HasColumnName("cidade_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NomeBairro)
                    .IsRequired()
                    .HasColumnName("nome_bairro")
                    .HasMaxLength(100);

                entity.HasOne(d => d.CidadeIdFkNavigation)
                    .WithMany(p => p.Bairro)
                    .HasForeignKey(d => d.CidadeIdFk)
                    .HasConstraintName("FKFDF81819401E5821");
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("BANCO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Agencia)
                    .HasColumnName("agencia")
                    .HasMaxLength(255);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CodigoBanco)
                    .HasColumnName("codigo_banco")
                    .HasMaxLength(255);

                entity.Property(e => e.Conta)
                    .HasColumnName("conta")
                    .HasMaxLength(255);

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DigitoAgencia)
                    .HasColumnName("digito_agencia")
                    .HasMaxLength(255);

                entity.Property(e => e.DigitoConta)
                    .HasColumnName("digito_conta")
                    .HasMaxLength(255);

                entity.Property(e => e.InsereInformacaoDeCedente).HasColumnName("insere_informacao_de_cedente");

                entity.Property(e => e.Moeda).HasColumnName("moeda");

                entity.Property(e => e.NomeFantasia)
                    .HasColumnName("nome_fantasia")
                    .HasMaxLength(255);

                entity.Property(e => e.Operacao)
                    .HasColumnName("operacao")
                    .HasMaxLength(255);

                entity.Property(e => e.RazaoSocial)
                    .HasColumnName("razao_social")
                    .HasMaxLength(255);

                entity.Property(e => e.VersaoAplicativo)
                    .HasColumnName("versao_aplicativo")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Campanharenovacao>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CAMPANHARENOVACAO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.AnoReferencia).HasColumnName("ano_referencia");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFim)
                    .HasColumnName("data_fim")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInicio)
                    .HasColumnName("data_inicio")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Cedente>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CEDENTE");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Aceite).HasColumnName("aceite");

                entity.Property(e => e.Ambiente).HasColumnName("ambiente");

                entity.Property(e => e.BaixarDevolverTituloAoCendente).HasColumnName("baixar_devolver_titulo_ao_cendente");

                entity.Property(e => e.BancoEmiteBloqueto).HasColumnName("banco_emite_bloqueto");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CodigoCedenteNoBanco)
                    .HasColumnName("codigo_cedente_no_banco")
                    .HasMaxLength(255);

                entity.Property(e => e.ContaIdFk).HasColumnName("conta_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntregaDoBloqueto).HasColumnName("entrega_do_bloqueto");

                entity.Property(e => e.EspecieDeTitulo).HasColumnName("especie_de_titulo");

                entity.Property(e => e.IdentificacaoTitulo).HasColumnName("identificacao_titulo");

                entity.Property(e => e.JuroDeMora).HasColumnName("juro_de_mora");

                entity.Property(e => e.NumeroDeDiasBaixarDevolverAoCedente).HasColumnName("numero_de_dias_baixar_devolver_ao_cedente");

                entity.Property(e => e.NumeroDeDiasParaProtesto).HasColumnName("numero_de_dias_para_protesto");

                entity.Property(e => e.PathBoletos)
                    .HasColumnName("path_boletos")
                    .HasMaxLength(255);

                entity.Property(e => e.PercentualDesconto)
                    .HasColumnName("percentual_desconto")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.PercentualJuroMora)
                    .HasColumnName("percentual_juro_mora")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.PlanoContasIdFk).HasColumnName("plano_contas_id_fk");

                entity.Property(e => e.PrazoSegundaVia).HasColumnName("prazo_segunda_via");

                entity.Property(e => e.ProtestarSePossivel).HasColumnName("protestar_se_possivel");

                entity.Property(e => e.TipoDesconto).HasColumnName("tipo_desconto");

                entity.Property(e => e.TipoRemessa).HasColumnName("tipo_remessa");

                entity.Property(e => e.TitulosRegistrados).HasColumnName("titulos_registrados");

                entity.Property(e => e.ValorJuroMora)
                    .HasColumnName("valor_juro_mora")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.VersaoLayoutArquivo)
                    .HasColumnName("versao_layout_arquivo")
                    .HasMaxLength(255);

                entity.Property(e => e.VersaoLayoutLote)
                    .HasColumnName("versao_layout_lote")
                    .HasMaxLength(255);

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Cedente)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FKF3097C5ED64882D9");

                entity.HasOne(d => d.ContaIdFkNavigation)
                    .WithMany(p => p.Cedente)
                    .HasForeignKey(d => d.ContaIdFk)
                    .HasConstraintName("FKF3097C5E6624E711");

                entity.HasOne(d => d.PlanoContasIdFkNavigation)
                    .WithMany(p => p.Cedente)
                    .HasForeignKey(d => d.PlanoContasIdFk)
                    .HasConstraintName("FKF3097C5EDC0BFFF6");
            });

            modelBuilder.Entity<Cheque>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CHEQUE");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Compensado).HasColumnName("compensado");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataCheque)
                    .HasColumnName("data_cheque")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(255);

                entity.Property(e => e.Identificacao)
                    .IsRequired()
                    .HasColumnName("identificacao")
                    .HasMaxLength(100);

                entity.Property(e => e.ValorCheque)
                    .HasColumnName("valor_cheque")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Vinculado).HasColumnName("vinculado");
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CIDADE");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NomeCidade)
                    .IsRequired()
                    .HasColumnName("nome_cidade")
                    .HasMaxLength(100);

                entity.Property(e => e.Uf).HasColumnName("uf");
            });

            modelBuilder.Entity<Cidadeabrangencia>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CIDADEABRANGENCIA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.AbrangenciaServicoIdFk).HasColumnName("abrangencia_servico_id_fk");

                entity.Property(e => e.CidadeIdFk).HasColumnName("cidade_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AbrangenciaServicoIdFkNavigation)
                    .WithMany(p => p.Cidadeabrangencia)
                    .HasForeignKey(d => d.AbrangenciaServicoIdFk)
                    .HasConstraintName("FK89E2F273ED78FD56");

                entity.HasOne(d => d.CidadeIdFkNavigation)
                    .WithMany(p => p.Cidadeabrangencia)
                    .HasForeignKey(d => d.CidadeIdFk)
                    .HasConstraintName("FK89E2F273401E5821");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CLIENTE");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.AgenciaNis)
                    .HasColumnName("agencia_nis")
                    .HasMaxLength(5);

                entity.Property(e => e.AlvaraPendente).HasColumnName("alvara_pendente");

                entity.Property(e => e.AnoExercicioAlvara).HasColumnName("ano_exercicio_alvara");

                entity.Property(e => e.AreaConstruida)
                    .HasColumnName("area_construida")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.AreaTerreno)
                    .HasColumnName("area_terreno")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Atividade).HasColumnName("atividade");

                entity.Property(e => e.BairroIdFk).HasColumnName("bairro_id_fk");

                entity.Property(e => e.BoletoConfirmado).HasColumnName("boleto_confirmado");

                entity.Property(e => e.BoletosRegistrados).HasColumnName("boletos_registrados");

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10);

                entity.Property(e => e.CidadeIdFk).HasColumnName("cidade_id_fk");

                entity.Property(e => e.CidadeNis)
                    .HasColumnName("cidade_nis")
                    .HasMaxLength(100);

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.CndPendente).HasColumnName("cnd_pendente");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("cnpj")
                    .HasMaxLength(20);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(100);

                entity.Property(e => e.ContatoFinanceiro)
                    .HasColumnName("contato_financeiro")
                    .HasMaxLength(255);

                entity.Property(e => e.ContratoFechado).HasColumnName("contrato_fechado");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataAutorizacao)
                    .HasColumnName("data_autorizacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInicioFuncionamento)
                    .HasColumnName("data_inicio_funcionamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataValidadeAlvara)
                    .HasColumnName("data_validade_alvara")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataValidadeCnd)
                    .HasColumnName("data_validade_cnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataValidadeRegularidade)
                    .HasColumnName("data_validade_regularidade")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesabilitarAfe).HasColumnName("desabilitar_afe");

                entity.Property(e => e.Distribuidora1).HasColumnName("distribuidora1");

                entity.Property(e => e.Distribuidora2).HasColumnName("distribuidora2");

                entity.Property(e => e.Distribuidora3).HasColumnName("distribuidora3");

                entity.Property(e => e.Distribuidora4).HasColumnName("distribuidora4");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(500);

                entity.Property(e => e.EmailEmpresaAnvisa)
                    .HasColumnName("email_empresa_anvisa")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailFp)
                    .HasColumnName("email_fp")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailSngpc)
                    .HasColumnName("email_sngpc")
                    .HasMaxLength(100);

                entity.Property(e => e.EmpresaSoftwareGestaoIdFk).HasColumnName("empresa_software_gestao_id_fk");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasColumnName("endereco")
                    .HasMaxLength(150);

                entity.Property(e => e.FormularioPbmIdFk).HasColumnName("formulario_pbm_id_fk");

                entity.Property(e => e.HorarioEntradaDomingo)
                    .HasColumnName("horario_entrada_domingo")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioEntradaSabado)
                    .HasColumnName("horario_entrada_sabado")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioEntradaSemana)
                    .HasColumnName("horario_entrada_semana")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioFuncionamentoDomingo)
                    .HasColumnName("horario_funcionamento_domingo")
                    .HasMaxLength(150);

                entity.Property(e => e.HorarioFuncionamentoFeriados)
                    .HasColumnName("horario_funcionamento_feriados")
                    .HasMaxLength(150);

                entity.Property(e => e.HorarioFuncionamentoSabado)
                    .HasColumnName("horario_funcionamento_sabado")
                    .HasMaxLength(150);

                entity.Property(e => e.HorarioFuncionamentoSemana)
                    .HasColumnName("horario_funcionamento_semana")
                    .HasMaxLength(300);

                entity.Property(e => e.HorarioSaidaDomingo)
                    .HasColumnName("horario_saida_domingo")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioSaidaSabado)
                    .HasColumnName("horario_saida_sabado")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioSaidaSemana)
                    .HasColumnName("horario_saida_semana")
                    .HasColumnType("datetime");

                entity.Property(e => e.HospitalIdFk).HasColumnName("hospital_id_fk");

                entity.Property(e => e.Ie)
                    .HasColumnName("ie")
                    .HasMaxLength(20);

                entity.Property(e => e.Inativo).HasColumnName("inativo");

                entity.Property(e => e.Incompleto).HasColumnName("incompleto");

                entity.Property(e => e.JuntaComercial)
                    .HasColumnName("junta_comercial")
                    .HasMaxLength(50);

                entity.Property(e => e.ListaPrecos).HasColumnName("lista_precos");

                entity.Property(e => e.Matriz).HasColumnName("matriz");

                entity.Property(e => e.Nis)
                    .HasColumnName("nis")
                    .HasMaxLength(100);

                entity.Property(e => e.NisValido).HasColumnName("nis_valido");

                entity.Property(e => e.NomeContatoDrogaria)
                    .HasColumnName("nome_contato_drogaria")
                    .HasMaxLength(100);

                entity.Property(e => e.NomeFantasia)
                    .IsRequired()
                    .HasColumnName("nome_fantasia")
                    .HasMaxLength(100);

                entity.Property(e => e.NomeIncineradora).HasColumnName("nome_incineradora");

                entity.Property(e => e.NomeMsn)
                    .HasColumnName("nome_msn")
                    .HasMaxLength(100);

                entity.Property(e => e.NomeSkype)
                    .HasColumnName("nome_skype")
                    .HasMaxLength(100);

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasMaxLength(10);

                entity.Property(e => e.NumeroAlvara)
                    .HasColumnName("numero_alvara")
                    .HasMaxLength(20);

                entity.Property(e => e.NumeroAutorizacao)
                    .HasColumnName("numero_autorizacao")
                    .HasMaxLength(20);

                entity.Property(e => e.NumeroRegularidade)
                    .HasColumnName("numero_regularidade")
                    .HasMaxLength(20);

                entity.Property(e => e.Observacao).HasColumnName("observacao");

                entity.Property(e => e.PopsIdFk).HasColumnName("pops_id_fk");

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasColumnName("razao_social")
                    .HasMaxLength(150);

                entity.Property(e => e.RegularidadePendente).HasColumnName("regularidade_pendente");

                entity.Property(e => e.Renegociado).HasColumnName("renegociado");

                entity.Property(e => e.SenhaEmailFp)
                    .HasColumnName("senha_email_fp")
                    .HasMaxLength(20);

                entity.Property(e => e.SenhaEmpresaAnvisa)
                    .HasColumnName("senha_empresa_anvisa")
                    .HasMaxLength(20);

                entity.Property(e => e.SenhaFp)
                    .HasColumnName("senha_fp")
                    .HasMaxLength(20);

                entity.Property(e => e.SenhaNis)
                    .HasColumnName("senha_nis")
                    .HasMaxLength(20);

                entity.Property(e => e.SenhaPortalDrogaria)
                    .HasColumnName("senha_portal_drogaria")
                    .HasMaxLength(20);

                entity.Property(e => e.SenhaSngpc)
                    .HasColumnName("senha_sngpc")
                    .HasMaxLength(20);

                entity.Property(e => e.SistemaGerencial).HasColumnName("sistema_gerencial");

                entity.Property(e => e.SistemaSngpc).HasColumnName("sistema_sngpc");

                entity.Property(e => e.Situacao).HasColumnName("situacao");

                entity.Property(e => e.Spc).HasColumnName("spc");

                entity.Property(e => e.TipoLogradouro).HasColumnName("tipo_logradouro");

                entity.Property(e => e.Uf).HasColumnName("uf");

                entity.Property(e => e.UsuarioFp)
                    .HasColumnName("usuario_fp")
                    .HasMaxLength(100);

                entity.Property(e => e.UsuarioPortalDrogaria)
                    .HasColumnName("usuario_portal_drogaria")
                    .HasMaxLength(100);

                entity.HasOne(d => d.BairroIdFkNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.BairroIdFk)
                    .HasConstraintName("FKDA2270DC5801B011");

                entity.HasOne(d => d.CidadeIdFkNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.CidadeIdFk)
                    .HasConstraintName("FKDA2270DC401E5821");

                entity.Ignore(d => d.ClienteIdFkNavigation);

                entity.HasOne(d => d.EmpresaSoftwareGestaoIdFkNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.EmpresaSoftwareGestaoIdFk)
                    .HasConstraintName("FKDA2270DC6DFCC9F9");

                entity.HasOne(d => d.FormularioPbmIdFkNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.FormularioPbmIdFk)
                    .HasConstraintName("FKDA2270DC676C92B2");

                entity.HasOne(d => d.HospitalIdFkNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.HospitalIdFk)
                    .HasConstraintName("FKDA2270DC79FE5DF1");

                entity.HasOne(d => d.PopsIdFkNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.PopsIdFk)
                    .HasConstraintName("FKDA2270DC7021D221");
            });

            modelBuilder.Entity<Clienteservicosexistentes>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CLIENTESERVICOSEXISTENTES");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Clienteservicosexistentes)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FKBDF1B5A6C0A3E2EE");

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Clienteservicosexistentes)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FKBDF1B5A6B764A226");
            });

            modelBuilder.Entity<Clientesimmeds>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CLIENTESIMMEDS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Ativo).HasColumnName("ativo");

                entity.Property(e => e.BoletoAberto).HasColumnName("boleto_aberto");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("cnpj")
                    .HasMaxLength(255);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CpfSngpc)
                    .HasColumnName("cpf_sngpc")
                    .HasMaxLength(50);

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEmailEnvioAtrasado)
                    .HasColumnName("data_email_envio_atrasado")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEmailErroValidacao)
                    .HasColumnName("data_email_erro_validacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEmailNaoAbriuSimMeds)
                    .HasColumnName("data_email_nao_abriu_sim_meds")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEmailNaoSolicitouBoleto)
                    .HasColumnName("data_email_nao_solicitou_boleto")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEmailProximoDoVencimento)
                    .HasColumnName("data_email_proximo_do_vencimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEmailSatisfacaoCliente)
                    .HasColumnName("data_email_satisfacao_cliente")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFinalLicenca)
                    .HasColumnName("data_final_licenca")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInicialLicenca)
                    .HasColumnName("data_inicial_licenca")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataUltimaUtilizacao)
                    .HasColumnName("data_ultima_utilizacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataUltimoEnvio)
                    .HasColumnName("data_ultimo_envio")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailContato)
                    .HasColumnName("email_contato")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailNovoClienteEnviado).HasColumnName("email_novo_cliente_enviado");

                entity.Property(e => e.EmailSngpc)
                    .HasColumnName("email_sngpc")
                    .HasMaxLength(100);

                entity.Property(e => e.ErroValidacaoUltimoEnvio).HasColumnName("erro_validacao_ultimo_envio");

                entity.Property(e => e.MensagemErroValidacao)
                    .IsRequired()
                    .HasColumnName("mensagem_erro_validacao");

                entity.Property(e => e.NomeContato)
                    .IsRequired()
                    .HasColumnName("nome_contato")
                    .HasMaxLength(100);

                entity.Property(e => e.SenhaSngpc)
                    .HasColumnName("senha_sngpc")
                    .HasMaxLength(50);

                entity.Property(e => e.SerialHd)
                    .IsRequired()
                    .HasColumnName("serial_hd")
                    .HasMaxLength(100);

                entity.Property(e => e.SerialProcessador)
                    .IsRequired()
                    .HasColumnName("serial_processador")
                    .HasMaxLength(100);

                entity.Property(e => e.Teste).HasColumnName("teste");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Clientesimmeds)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FK5B720594D64882D9");
            });

            modelBuilder.Entity<Codigodistribuidora>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CODIGODISTRIBUIDORA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DistribuidoraIdFk).HasColumnName("distribuidora_id_fk");

                entity.Property(e => e.FormularioPbmIdFk).HasColumnName("formulario_pbm_id_fk");

                entity.Property(e => e.ValorCodigo)
                    .HasColumnName("valor_codigo")
                    .HasMaxLength(255);

                entity.HasOne(d => d.DistribuidoraIdFkNavigation)
                    .WithMany(p => p.Codigodistribuidora)
                    .HasForeignKey(d => d.DistribuidoraIdFk)
                    .HasConstraintName("FKB934516CB9497A09");

                entity.HasOne(d => d.FormularioPbmIdFkNavigation)
                    .WithMany(p => p.Codigodistribuidora)
                    .HasForeignKey(d => d.FormularioPbmIdFk)
                    .HasConstraintName("FKB934516C676C92B2");
            });

            modelBuilder.Entity<Colaboradoreslanche>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("COLABORADORESLANCHE");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Apelido)
                    .HasColumnName("apelido")
                    .HasMaxLength(255);

                entity.Property(e => e.Atual).HasColumnName("atual");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataUltimoPagamento)
                    .HasColumnName("data_ultimo_pagamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.LancheIdFk).HasColumnName("lanche_id_fk");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(255);

                entity.Property(e => e.Ordem).HasColumnName("ordem");

                entity.Property(e => e.Sabor).HasColumnName("sabor");

                entity.HasOne(d => d.LancheIdFkNavigation)
                    .WithMany(p => p.Colaboradoreslanche)
                    .HasForeignKey(d => d.LancheIdFk)
                    .HasConstraintName("FK68831B18B88A81");
            });

            modelBuilder.Entity<Coleta>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("COLETA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.IncineradoraIdFk).HasColumnName("incineradora_id_fk");

                entity.Property(e => e.Periodo).HasColumnName("periodo");

                entity.Property(e => e.ResiduoA).HasColumnName("residuo_a");

                entity.Property(e => e.ResiduoB).HasColumnName("residuo_b");

                entity.Property(e => e.ResiduoD).HasColumnName("residuo_d");

                entity.Property(e => e.ResiduoE).HasColumnName("residuo_e");

                entity.Property(e => e.Vezes).HasColumnName("vezes");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Coleta)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FKD2263504D64882D9");

                entity.HasOne(d => d.IncineradoraIdFkNavigation)
                    .WithMany(p => p.Coleta)
                    .HasForeignKey(d => d.IncineradoraIdFk)
                    .HasConstraintName("FKD226350442EB939");
            });

            modelBuilder.Entity<Comissaousuario>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("COMISSAOUSUARIO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Comissao)
                    .HasColumnName("comissao")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.Property(e => e.UsuarioIdFk).HasColumnName("usuario_id_fk");

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Comissaousuario)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FKF6F9FCE6B764A226");

                entity.HasOne(d => d.UsuarioIdFkNavigation)
                    .WithMany(p => p.Comissaousuario)
                    .HasForeignKey(d => d.UsuarioIdFk)
                    .HasConstraintName("FKF6F9FCE6B59B002F");
            });

            modelBuilder.Entity<Configuracaodescontocliente>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CONFIGURACAODESCONTOCLIENTE");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataPrimeiroBoleto)
                    .HasColumnName("data_primeiro_boleto")
                    .HasColumnType("datetime");

                entity.Property(e => e.PercentualDescontoAdesao)
                    .HasColumnName("percentual_desconto_adesao")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.PercentualDescontoMensalidade)
                    .HasColumnName("percentual_desconto_mensalidade")
                    .HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Configuracaodescontocliente)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKF4D61184D64882D9");
            });

            modelBuilder.Entity<Configuracoes>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CONFIGURACOES");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.BccEmails)
                    .HasColumnName("bcc_emails")
                    .HasMaxLength(200);

                entity.Property(e => e.BccFinanceiroEmails)
                    .HasColumnName("bcc_financeiro_emails")
                    .HasMaxLength(200);

                entity.Property(e => e.CarenciaAtrasoPagamento).HasColumnName("carencia_atraso_pagamento");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContaIdFk).HasColumnName("conta_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiaPgtoDadoprocesso).HasColumnName("dia_pgto_dadoprocesso");

                entity.Property(e => e.DiasCarenciaContratoAVista).HasColumnName("dias_carencia_contrato_a_vista");

                entity.Property(e => e.DiasCarenciaPrimeiraParcela).HasColumnName("dias_carencia_primeira_parcela");

                entity.Property(e => e.DiasProximaProposta).HasColumnName("dias_proxima_proposta");

                entity.Property(e => e.DiasValidadeProposta).HasColumnName("dias_validade_proposta");

                entity.Property(e => e.Emails)
                    .HasColumnName("emails")
                    .HasMaxLength(500);

                entity.Property(e => e.FromEmail)
                    .HasColumnName("from_email")
                    .HasMaxLength(80);

                entity.Property(e => e.FromFinanceiroEmail)
                    .HasColumnName("from_financeiro_email")
                    .HasMaxLength(80);

                entity.Property(e => e.FromFinanceiroNome)
                    .HasColumnName("from_financeiro_nome")
                    .HasMaxLength(40);

                entity.Property(e => e.FromFinanceiroPort).HasColumnName("from_financeiro_port");

                entity.Property(e => e.FromFinanceiroSenha)
                    .HasColumnName("from_financeiro_senha")
                    .HasMaxLength(20);

                entity.Property(e => e.FromFinanceiroSmtp)
                    .HasColumnName("from_financeiro_smtp")
                    .HasMaxLength(50);

                entity.Property(e => e.FromNome)
                    .HasColumnName("from_nome")
                    .HasMaxLength(40);

                entity.Property(e => e.FromPort).HasColumnName("from_port");

                entity.Property(e => e.FromSenha)
                    .HasColumnName("from_senha")
                    .HasMaxLength(30);

                entity.Property(e => e.FromSmtp)
                    .HasColumnName("from_smtp")
                    .HasMaxLength(50);

                entity.Property(e => e.GerarSempre).HasColumnName("gerar_sempre");

                entity.Property(e => e.JurosContrato)
                    .HasColumnName("juros_contrato")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.MensagemAtrasoPagamento)
                    .HasColumnName("mensagem_atraso_pagamento")
                    .HasMaxLength(300);

                entity.Property(e => e.MultaContrato)
                    .HasColumnName("multa_contrato")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.PathArquivoConfigServicosWindows)
                    .HasColumnName("path_arquivo_config_servicos_windows")
                    .HasMaxLength(255);

                entity.Property(e => e.PathDestinoDocs)
                    .IsRequired()
                    .HasColumnName("path_destino_docs")
                    .HasMaxLength(255);

                entity.Property(e => e.PathDestinoPops)
                    .IsRequired()
                    .HasColumnName("path_destino_pops")
                    .HasMaxLength(255);

                entity.Property(e => e.PathDocs)
                    .IsRequired()
                    .HasColumnName("path_docs")
                    .HasMaxLength(255);

                entity.Property(e => e.PathDocsClientes)
                    .HasColumnName("path_docs_clientes")
                    .HasMaxLength(255);

                entity.Property(e => e.PathPbms)
                    .HasColumnName("path_pbms")
                    .HasMaxLength(255);

                entity.Property(e => e.PathPops)
                    .IsRequired()
                    .HasColumnName("path_pops")
                    .HasMaxLength(255);

                entity.Property(e => e.PathPropostas)
                    .HasColumnName("path_propostas")
                    .HasMaxLength(255);

                entity.Property(e => e.PathPublic)
                    .HasColumnName("path_public")
                    .HasMaxLength(255);

                entity.Property(e => e.PlanoContasIdFk).HasColumnName("plano_contas_id_fk");

                entity.Property(e => e.TipoCarenciaPrimeiraParcela).HasColumnName("tipo_carencia_primeira_parcela");

                entity.Property(e => e.TipoJurosContrato).HasColumnName("tipo_juros_contrato");

                entity.Property(e => e.TipoJurosPagar).HasColumnName("tipo_juros_pagar");

                entity.HasOne(d => d.ContaIdFkNavigation)
                    .WithMany(p => p.Configuracoes)
                    .HasForeignKey(d => d.ContaIdFk)
                    .HasConstraintName("FKA614751DE31CF071");

                entity.HasOne(d => d.PlanoContasIdFkNavigation)
                    .WithMany(p => p.Configuracoes)
                    .HasForeignKey(d => d.PlanoContasIdFk)
                    .HasConstraintName("FKA614751DE7371685");
            });

            modelBuilder.Entity<Configuracoesdinamicas>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CONFIGURACOESDINAMICAS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Grupo)
                    .HasColumnName("grupo")
                    .HasMaxLength(255);

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(80);

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasMaxLength(500);

                entity.Property(e => e.ValoresCombo)
                    .HasColumnName("valores_combo")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Configuracoesweb>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CONFIGURACOESWEB");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(80);

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Conta>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CONTA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoConta)
                    .IsRequired()
                    .HasColumnName("descricao_conta")
                    .HasMaxLength(255);

                entity.Property(e => e.NomeConta)
                    .IsRequired()
                    .HasColumnName("nome_conta")
                    .HasMaxLength(80);

                entity.Property(e => e.SaldoInicial)
                    .HasColumnName("saldo_inicial")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.StatusConta).HasColumnName("status_conta");
            });

            modelBuilder.Entity<Contato>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CONTATO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("cnpj")
                    .HasMaxLength(20);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NomeFantasia)
                    .IsRequired()
                    .HasColumnName("nome_fantasia")
                    .HasMaxLength(100);

                entity.Property(e => e.RazaoSocial)
                    .HasColumnName("razao_social")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Contatousuariocampanha>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CONTATOUSUARIOCAMPANHA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.CampanhaRenovacaoIdFk).HasColumnName("campanha_renovacao_id_fk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Observacao)
                    .HasColumnName("observacao")
                    .HasMaxLength(250);

                entity.Property(e => e.TipoProposta).HasColumnName("tipo_proposta");

                entity.Property(e => e.UsuarioIdFk).HasColumnName("usuario_id_fk");

                entity.HasOne(d => d.CampanhaRenovacaoIdFkNavigation)
                    .WithMany(p => p.Contatousuariocampanha)
                    .HasForeignKey(d => d.CampanhaRenovacaoIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTATOUSUARIOCAMPANHA_CAMPANHARENOVACAO");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Contatousuariocampanha)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTATOUSUARIOCAMPANHA_CLIENTE");

                entity.HasOne(d => d.UsuarioIdFkNavigation)
                    .WithMany(p => p.Contatousuariocampanha)
                    .HasForeignKey(d => d.UsuarioIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTATOUSUARIOCAMPANHA_USUARIO");
            });

            modelBuilder.Entity<Contrato>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CONTRATO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Assinado).HasColumnName("assinado");

                entity.Property(e => e.BoletosGerados).HasColumnName("boletos_gerados");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContratoDigitalizado).HasColumnName("contrato_digitalizado");

                entity.Property(e => e.ContratoFilial).HasColumnName("contrato_filial");

                entity.Property(e => e.ContratoIdFk).HasColumnName("contrato_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFinal)
                    .HasColumnName("data_final")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInicial)
                    .HasColumnName("data_inicial")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataPrevisaoTermino)
                    .HasColumnName("data_previsao_termino")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiaPagamento).HasColumnName("dia_pagamento");

                entity.Property(e => e.DocsEnviados).HasColumnName("docs_enviados");

                entity.Property(e => e.EntrouNaCampanha).HasColumnName("entrou_na_campanha");

                entity.Property(e => e.EnviarDocs).HasColumnName("enviar_docs");

                entity.Property(e => e.FornecedorIdFk).HasColumnName("fornecedor_id_fk");

                entity.Property(e => e.GerarDocs).HasColumnName("gerar_docs");

                entity.Property(e => e.Inativo).HasColumnName("inativo");

                entity.Property(e => e.NumeroContrato)
                    .IsRequired()
                    .HasColumnName("numero_contrato")
                    .HasMaxLength(12);

                entity.Property(e => e.PagamentoPosExecucao).HasColumnName("pagamento_pos_execucao");

                entity.Property(e => e.ParcelasIguais).HasColumnName("parcelas_iguais");

                entity.Property(e => e.PlanoIdFk).HasColumnName("plano_id_fk");

                entity.Property(e => e.PorRepresentante).HasColumnName("por_representante");

                entity.Property(e => e.PropostaIdFk).HasColumnName("proposta_id_fk");

                entity.Property(e => e.QtdParcelas).HasColumnName("qtd_parcelas");

                entity.Property(e => e.RegraContratoIdFk).HasColumnName("regra_contrato_id_fk");

                entity.Property(e => e.TipoFechamentoContrato).HasColumnName("tipo_fechamento_contrato");

                entity.Property(e => e.ValidadePacote)
                    .HasColumnName("validade_pacote")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValorContrato)
                    .HasColumnName("valor_contrato")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ValorDesconto)
                    .HasColumnName("valor_desconto")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ValorParcela)
                    .HasColumnName("valor_parcela")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ValorTotal)
                    .HasColumnName("valor_total")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Vigente).HasColumnName("vigente");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Contrato)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FKD3503BFED64882D9");

                entity.HasOne(d => d.ContratoIdFkNavigation)
                    .WithMany(p => p.InverseContratoIdFkNavigation)
                    .HasForeignKey(d => d.ContratoIdFk)
                    .HasConstraintName("FKD3503BFE7F07A61");

                entity.HasOne(d => d.FornecedorIdFkNavigation)
                    .WithMany(p => p.Contrato)
                    .HasForeignKey(d => d.FornecedorIdFk)
                    .HasConstraintName("FKD3503BFE32C12461");

                entity.HasOne(d => d.PlanoIdFkNavigation)
                    .WithMany(p => p.Contrato)
                    .HasForeignKey(d => d.PlanoIdFk)
                    .HasConstraintName("FKD3503BFE6183F741");

                entity.HasOne(d => d.PropostaIdFkNavigation)
                    .WithMany(p => p.Contrato)
                    .HasForeignKey(d => d.PropostaIdFk)
                    .HasConstraintName("FKD3503BFEA4354939");

                entity.HasOne(d => d.RegraContratoIdFkNavigation)
                    .WithMany(p => p.Contrato)
                    .HasForeignKey(d => d.RegraContratoIdFk)
                    .HasConstraintName("FKD3503BFE91AC4CC");
            });

            modelBuilder.Entity<Contratoparcelas>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CONTRATOPARCELAS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContratoIdFk).HasColumnName("contrato_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Parcela).HasColumnName("parcela");

                entity.Property(e => e.ValorParcela)
                    .HasColumnName("valor_parcela")
                    .HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.ContratoIdFkNavigation)
                    .WithMany(p => p.Contratoparcelas)
                    .HasForeignKey(d => d.ContratoIdFk)
                    .HasConstraintName("FK317F8671F353E7A7");
            });

            modelBuilder.Entity<Dadopesquisa>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("DADOPESQUISA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoDadoPesquisa)
                    .IsRequired()
                    .HasColumnName("descricao_dado_pesquisa")
                    .HasMaxLength(255);

                entity.Property(e => e.NomeDadoPesquisa)
                    .IsRequired()
                    .HasColumnName("nome_dado_pesquisa")
                    .HasMaxLength(100);

                entity.Property(e => e.PesquisaIdFk).HasColumnName("pesquisa_id_fk");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.ValorCombo)
                    .HasColumnName("valor_combo")
                    .HasMaxLength(255);

                entity.HasOne(d => d.PesquisaIdFkNavigation)
                    .WithMany(p => p.Dadopesquisa)
                    .HasForeignKey(d => d.PesquisaIdFk)
                    .HasConstraintName("FKB1A9107984C215C0");
            });

            modelBuilder.Entity<Dadoprocesso>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("DADOPROCESSO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Acao).HasMaxLength(255);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DadoProcessoIdFk).HasColumnName("dado_processo_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Desabilitavel).HasColumnName("desabilitavel");

                entity.Property(e => e.DescricaoDadoProcesso)
                    .IsRequired()
                    .HasColumnName("descricao_dado_processo")
                    .HasMaxLength(255);

                entity.Property(e => e.NomeDadoProcesso)
                    .IsRequired()
                    .HasColumnName("nome_dado_processo")
                    .HasMaxLength(100);

                entity.Property(e => e.NomeMetodo).HasMaxLength(255);

                entity.Property(e => e.ProcessoIdFk).HasColumnName("processo_id_fk");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.ValorCombo)
                    .HasColumnName("valor_combo")
                    .HasMaxLength(255);

                entity.Property(e => e.ValorParametroString).HasMaxLength(255);

                entity.HasOne(d => d.DadoProcessoIdFkNavigation)
                    .WithMany(p => p.InverseDadoProcessoIdFkNavigation)
                    .HasForeignKey(d => d.DadoProcessoIdFk)
                    .HasConstraintName("FK7B1248A94CA929C");

                entity.HasOne(d => d.ProcessoIdFkNavigation)
                    .WithMany(p => p.Dadoprocesso)
                    .HasForeignKey(d => d.ProcessoIdFk)
                    .HasConstraintName("FK7B1248A14FAA6D9");
            });

            modelBuilder.Entity<Distribuidora>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("DISTRIBUIDORA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("cnpj")
                    .HasMaxLength(20);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NomeFantasia)
                    .HasColumnName("nome_fantasia")
                    .HasMaxLength(100);

                entity.Property(e => e.RazaoSocial)
                    .HasColumnName("razao_social")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("DOCUMENTO");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Caminho).HasColumnName("CAMINHO");

                entity.Property(e => e.Descricao).HasColumnName("DESCRICAO");

                entity.Property(e => e.EmailSeparado).HasColumnName("email_separado");

                entity.Property(e => e.Emails)
                    .HasColumnName("emails")
                    .HasMaxLength(255);

                entity.Property(e => e.EnviarAposGerar).HasColumnName("enviar_apos_gerar");

                entity.Property(e => e.FooterMessage)
                    .HasColumnName("footer_message")
                    .HasMaxLength(255);

                entity.Property(e => e.FromEmail)
                    .HasColumnName("from_email")
                    .HasMaxLength(255);

                entity.Property(e => e.GerarPdf).HasColumnName("gerar_pdf");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(150);

                entity.Property(e => e.TextoEmail)
                    .HasColumnName("texto_email")
                    .IsUnicode(false);

                entity.Property(e => e.Tipo).HasColumnName("TIPO");
            });

            modelBuilder.Entity<Documentoservico>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("DOCUMENTOSERVICO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.Property(e => e.TipoDocumentoServicoIdFk).HasColumnName("tipo_documento_servico_id_fk");

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Documentoservico)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FKDBC9D68EB764A226");

                entity.HasOne(d => d.TipoDocumentoServicoIdFkNavigation)
                    .WithMany(p => p.Documentoservico)
                    .HasForeignKey(d => d.TipoDocumentoServicoIdFk)
                    .HasConstraintName("FKDBC9D68E4531BC02");
            });

            modelBuilder.Entity<Emailmarketing>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("EMAILMARKETING");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(250);

                entity.Property(e => e.Enviado).HasColumnName("enviado");

                entity.Property(e => e.HistoricoPropostasIdFk).HasColumnName("historico_propostas_id_fk");

                entity.Property(e => e.UsuarioIdFk).HasColumnName("usuario_id_fk");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Emailmarketing)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKDCF4EFA6D64882D9");

                entity.HasOne(d => d.HistoricoPropostasIdFkNavigation)
                    .WithMany(p => p.Emailmarketing)
                    .HasForeignKey(d => d.HistoricoPropostasIdFk)
                    .HasConstraintName("FKDCF4EFA6EEBE7E4C");

                entity.HasOne(d => d.UsuarioIdFkNavigation)
                    .WithMany(p => p.Emailmarketing)
                    .HasForeignKey(d => d.UsuarioIdFk)
                    .HasConstraintName("FKDCF4EFA63A09D2F9");
            });

            modelBuilder.Entity<Emailscobranca>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("EMAILSCOBRANCA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEnvio)
                    .HasColumnName("data_envio")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoEnvio)
                    .HasColumnName("descricao_envio")
                    .HasMaxLength(500);

                entity.Property(e => e.Erro)
                    .HasColumnName("erro")
                    .HasMaxLength(800);

                entity.Property(e => e.LancamentoIdFk).HasColumnName("lancamento_id_fk");

                entity.HasOne(d => d.LancamentoIdFkNavigation)
                    .WithMany(p => p.Emailscobranca)
                    .HasForeignKey(d => d.LancamentoIdFk)
                    .HasConstraintName("FK6990D215948E012C");
            });

            modelBuilder.Entity<Empresasoftwaregestao>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("EMPRESASOFTWAREGESTAO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("cnpj")
                    .HasMaxLength(255);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Contato)
                    .HasColumnName("contato")
                    .HasMaxLength(255);

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(255);

                entity.Property(e => e.Software).HasMaxLength(255);

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("FAQ");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pergunta)
                    .IsRequired()
                    .HasColumnName("pergunta")
                    .HasMaxLength(500);

                entity.Property(e => e.Resposta)
                    .IsRequired()
                    .HasColumnName("resposta")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Formulariopbm>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("FORMULARIOPBM");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.AbrangenciaEntrega).HasColumnName("abrangencia_entrega");

                entity.Property(e => e.Agencia)
                    .HasColumnName("agencia")
                    .HasMaxLength(255);

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.CnpjSoftwareHouse)
                    .HasColumnName("cnpj_software_house")
                    .HasMaxLength(255);

                entity.Property(e => e.CobraTaxaEntrega).HasColumnName("cobra_taxa_entrega");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Conta)
                    .HasColumnName("conta")
                    .HasMaxLength(255);

                entity.Property(e => e.ContatoSoftwareHouse)
                    .HasColumnName("contato_software_house")
                    .HasMaxLength(100);

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailSoftwareHouse)
                    .HasColumnName("email_software_house")
                    .HasMaxLength(255);

                entity.Property(e => e.EmpresaSoftwareGestaoIdFk).HasColumnName("empresa_software_gestao_id_fk");

                entity.Property(e => e.EntregaPeloConvenio).HasColumnName("entrega_pelo_convenio");

                entity.Property(e => e.FormaReposicaoProdutos).HasColumnName("forma_reposicao_produtos");

                entity.Property(e => e.HorarioDiasSemanaFinal)
                    .HasColumnName("horario_dias_semana_final")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioDiasSemanaInicial)
                    .HasColumnName("horario_dias_semana_inicial")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioFeriadoFinal)
                    .HasColumnName("horario_feriado_final")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioFeriadoInicial)
                    .HasColumnName("horario_feriado_inicial")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioFinalSemanaFinal)
                    .HasColumnName("horario_final_semana_final")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioFinalSemanaInicial)
                    .HasColumnName("horario_final_semana_inicial")
                    .HasColumnType("datetime");

                entity.Property(e => e.NomeBanco)
                    .HasColumnName("nome_banco")
                    .HasMaxLength(150);

                entity.Property(e => e.NomeContidoNaConta)
                    .HasColumnName("nome_contido_na_conta")
                    .HasMaxLength(150);

                entity.Property(e => e.NomeDaRede)
                    .HasColumnName("nome_da_rede")
                    .HasMaxLength(100);

                entity.Property(e => e.NomeResponsavelTecnico)
                    .HasColumnName("nome_responsavel_tecnico")
                    .HasMaxLength(255);

                entity.Property(e => e.NomeSoftwareHouse)
                    .HasColumnName("nome_software_house")
                    .HasMaxLength(100);

                entity.Property(e => e.NumeroCaixas).HasColumnName("numero_caixas");

                entity.Property(e => e.NumeroComputadores).HasColumnName("numero_computadores");

                entity.Property(e => e.NumeroCrf)
                    .HasColumnName("numero_crf")
                    .HasMaxLength(255);

                entity.Property(e => e.NumeroFuncionarios).HasColumnName("numero_funcionarios");

                entity.Property(e => e.PossuiCartaoFidelidade).HasColumnName("possui_cartao_fidelidade");

                entity.Property(e => e.PossuiConvenioComEmpresas).HasColumnName("possui_convenio_com_empresas");

                entity.Property(e => e.QuantidadeCartoesFidelidade).HasColumnName("quantidade_cartoes_fidelidade");

                entity.Property(e => e.QuantidadeConvenios).HasColumnName("quantidade_convenios");

                entity.Property(e => e.RedeIdFk).HasColumnName("rede_id_fk");

                entity.Property(e => e.SistemaOperacional).HasColumnName("sistema_operacional");

                entity.Property(e => e.Software)
                    .HasColumnName("software")
                    .HasMaxLength(100);

                entity.Property(e => e.TelefoneSoftwareHouse)
                    .HasColumnName("telefone_software_house")
                    .HasMaxLength(255);

                entity.Property(e => e.TipoConexaoInternet).HasColumnName("tipo_conexao_internet");

                entity.Property(e => e.TipoEmpresa).HasColumnName("tipo_empresa");

                entity.Property(e => e.Uf).HasColumnName("uf");

                entity.Property(e => e.ValorMinimoParaEntrega)
                    .HasColumnName("valor_minimo_para_entrega")
                    .HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.FormulariopbmClienteIdFkNavigation)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FK70375A75D64882D9");

                entity.HasOne(d => d.EmpresaSoftwareGestaoIdFkNavigation)
                    .WithMany(p => p.Formulariopbm)
                    .HasForeignKey(d => d.EmpresaSoftwareGestaoIdFk)
                    .HasConstraintName("FKA48A1707F037BE13");

                entity.HasOne(d => d.RedeIdFkNavigation)
                    .WithMany(p => p.FormulariopbmRedeIdFkNavigation)
                    .HasForeignKey(d => d.RedeIdFk)
                    .HasConstraintName("FKA48A170753430EF8");
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("FORNECEDOR");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.BairroIdFk).HasColumnName("bairro_id_fk");

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10);

                entity.Property(e => e.CidadeIdFk).HasColumnName("cidade_id_fk");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("cnpj")
                    .HasMaxLength(20);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Comissao)
                    .HasColumnName("comissao")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Comissionado).HasColumnName("comissionado");

                entity.Property(e => e.Cpf)
                    .HasColumnName("cpf")
                    .HasMaxLength(20);

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasColumnName("endereco")
                    .HasMaxLength(150);

                entity.Property(e => e.Ie)
                    .HasColumnName("ie")
                    .HasMaxLength(20);

                entity.Property(e => e.NomeContato)
                    .HasColumnName("nome_contato")
                    .HasMaxLength(150);

                entity.Property(e => e.NomeFantasia)
                    .IsRequired()
                    .HasColumnName("nome_fantasia")
                    .HasMaxLength(100);

                entity.Property(e => e.Observacao)
                    .HasColumnName("observacao")
                    .HasMaxLength(255);

                entity.Property(e => e.RazaoSocial)
                    .HasColumnName("razao_social")
                    .HasMaxLength(150);

                entity.Property(e => e.Representante).HasColumnName("representante");

                entity.Property(e => e.Site)
                    .HasColumnName("site")
                    .HasMaxLength(100);

                entity.Property(e => e.Situacao).HasColumnName("situacao");

                entity.Property(e => e.TipoPessoa).HasColumnName("tipo_pessoa");

                entity.Property(e => e.Uf).HasColumnName("uf");

                entity.Property(e => e.ValorMinimoMensalidade)
                    .HasColumnName("valor_minimo_mensalidade")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ValorRepasse)
                    .HasColumnName("valor_repasse")
                    .HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.BairroIdFkNavigation)
                    .WithMany(p => p.Fornecedor)
                    .HasForeignKey(d => d.BairroIdFk)
                    .HasConstraintName("FKFDEC21335801B011");

                entity.HasOne(d => d.CidadeIdFkNavigation)
                    .WithMany(p => p.Fornecedor)
                    .HasForeignKey(d => d.CidadeIdFk)
                    .HasConstraintName("FKFDEC2133401E5821");
            });

            modelBuilder.Entity<Grupoordem>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("GRUPOORDEM");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NomeArea)
                    .IsRequired()
                    .HasColumnName("nome_area")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Gruposervico>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("GRUPOSERVICO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(500);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(150);

                entity.Property(e => e.TipoOferta).HasColumnName("tipo_oferta");
            });

            modelBuilder.Entity<Historicoafe>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("HISTORICOAFE");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContratoIdFk).HasColumnName("contrato_id_fk");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnName("data_atualizacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoResultado)
                    .HasColumnName("descricao_resultado")
                    .HasMaxLength(1700);

                entity.Property(e => e.OrdemServicoIdFk).HasColumnName("ordem_servico_id_fk");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Verificado).HasColumnName("verificado");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Historicoafe)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FKE16D99B2D64882D9");

                entity.HasOne(d => d.ContratoIdFkNavigation)
                    .WithMany(p => p.Historicoafe)
                    .HasForeignKey(d => d.ContratoIdFk)
                    .HasConstraintName("FKE16D99B27F07A61");

                entity.HasOne(d => d.OrdemServicoIdFkNavigation)
                    .WithMany(p => p.Historicoafe)
                    .HasForeignKey(d => d.OrdemServicoIdFk)
                    .HasConstraintName("FKE16D99B2A4FD7F16");
            });

            modelBuilder.Entity<Historicofp>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("HISTORICOFP");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContratoIdFk).HasColumnName("contrato_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEmail)
                    .HasColumnName("data_email")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailOrigem)
                    .HasColumnName("email_origem")
                    .HasMaxLength(255);

                entity.Property(e => e.OrdemServicoIdFk).HasColumnName("ordem_servico_id_fk");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TextoEmail)
                    .HasColumnName("texto_email")
                    .HasMaxLength(2000);

                entity.Property(e => e.TituloEmail)
                    .HasColumnName("titulo_email")
                    .HasMaxLength(255);

                entity.Property(e => e.Verificado).HasColumnName("verificado");

                entity.HasOne(d => d.ContratoIdFkNavigation)
                    .WithMany(p => p.Historicofp)
                    .HasForeignKey(d => d.ContratoIdFk)
                    .HasConstraintName("FKA9E1D3BCF353E7A7");

                entity.HasOne(d => d.OrdemServicoIdFkNavigation)
                    .WithMany(p => p.Historicofp)
                    .HasForeignKey(d => d.OrdemServicoIdFk)
                    .HasConstraintName("FKA9E1D3BCD292D151");
            });

            modelBuilder.Entity<Historicofpdou>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("HISTORICOFPDOU");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContratoIdFk).HasColumnName("contrato_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataPublicacao)
                    .HasColumnName("data_publicacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoResultado)
                    .HasColumnName("descricao_resultado")
                    .HasMaxLength(2000);

                entity.Property(e => e.EnviadoCliente).HasColumnName("enviado_cliente");

                entity.Property(e => e.OrdemServicoIdFk).HasColumnName("ordem_servico_id_fk");

                entity.Property(e => e.PaginaDou).HasColumnName("pagina_dou");

                entity.Property(e => e.Verificado).HasColumnName("verificado");

                entity.HasOne(d => d.ContratoIdFkNavigation)
                    .WithMany(p => p.Historicofpdou)
                    .HasForeignKey(d => d.ContratoIdFk)
                    .HasConstraintName("FK7B5F6661F353E7A7");

                entity.HasOne(d => d.OrdemServicoIdFkNavigation)
                    .WithMany(p => p.Historicofpdou)
                    .HasForeignKey(d => d.OrdemServicoIdFk)
                    .HasConstraintName("FK7B5F6661D292D151");
            });

            modelBuilder.Entity<Historicoliberacaopbm>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("HISTORICOLIBERACAOPBM");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContratoIdFk).HasColumnName("contrato_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.Property(e => e.Visualizado).HasColumnName("visualizado");

                entity.HasOne(d => d.ContratoIdFkNavigation)
                    .WithMany(p => p.Historicoliberacaopbm)
                    .HasForeignKey(d => d.ContratoIdFk)
                    .HasConstraintName("FKEF8DD852F353E7A7");

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Historicoliberacaopbm)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FKEF8DD852B764A226");
            });

            modelBuilder.Entity<Historiconovosservicos>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("HISTORICONOVOSSERVICOS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContratoIdFk).HasColumnName("contrato_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.Property(e => e.UsuarioIdFk).HasColumnName("usuario_id_fk");

                entity.Property(e => e.Visto).HasColumnName("visto");

                entity.HasOne(d => d.ContratoIdFkNavigation)
                    .WithMany(p => p.Historiconovosservicos)
                    .HasForeignKey(d => d.ContratoIdFk)
                    .HasConstraintName("FKF2687F09F353E7A7");

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Historiconovosservicos)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FKF2687F09B764A226");

                entity.HasOne(d => d.UsuarioIdFkNavigation)
                    .WithMany(p => p.Historiconovosservicos)
                    .HasForeignKey(d => d.UsuarioIdFk)
                    .HasConstraintName("FKF2687F09B59B002F");
            });

            modelBuilder.Entity<Historicopropostas>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("HISTORICOPROPOSTAS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataVerificacao)
                    .HasColumnName("data_verificacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(500);

                entity.Property(e => e.GrupoServicoIdFk).HasColumnName("grupo_servico_id_fk");

                entity.Property(e => e.SolicitacaoPropostasIdFk).HasColumnName("solicitacao_propostas_id_fk");

                entity.Property(e => e.Utilizado).HasColumnName("utilizado");

                entity.HasOne(d => d.GrupoServicoIdFkNavigation)
                    .WithMany(p => p.Historicopropostas)
                    .HasForeignKey(d => d.GrupoServicoIdFk)
                    .HasConstraintName("FKEDD297CF6BDC1713");

                entity.HasOne(d => d.SolicitacaoPropostasIdFkNavigation)
                    .WithMany(p => p.Historicopropostas)
                    .HasForeignKey(d => d.SolicitacaoPropostasIdFk)
                    .HasConstraintName("FKEDD297CFFC2EE7C2");
            });

            modelBuilder.Entity<Historicosifap>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("HISTORICOSIFAP");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Agencia)
                    .HasColumnName("agencia")
                    .HasMaxLength(50);

                entity.Property(e => e.CnpjCadastro)
                    .HasColumnName("cnpj_cadastro")
                    .HasMaxLength(255);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContratoIdFk).HasColumnName("contrato_id_fk");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(1000);

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasColumnName("motivo")
                    .HasMaxLength(255);

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.HasOne(d => d.ContratoIdFkNavigation)
                    .WithMany(p => p.Historicosifap)
                    .HasForeignKey(d => d.ContratoIdFk)
                    .HasConstraintName("FKCA57EC6AF353E7A7");

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Historicosifap)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FKCA57EC6AB764A226");
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("HORARIO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiaSemana).HasColumnName("dia_semana");

                entity.Property(e => e.HorarioEntrada)
                    .HasColumnName("horario_entrada")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioParada)
                    .HasColumnName("horario_parada")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioRetorno)
                    .HasColumnName("horario_retorno")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorarioSaida)
                    .HasColumnName("horario_saida")
                    .HasColumnType("datetime");

                entity.Property(e => e.TecnicoIdFk).HasColumnName("tecnico_id_fk");

                entity.HasOne(d => d.TecnicoIdFkNavigation)
                    .WithMany(p => p.Horario)
                    .HasForeignKey(d => d.TecnicoIdFk)
                    .HasConstraintName("FKED3BF0EB5D1C3B93");
            });

            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("HOSPITAL");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Cidade)
                    .HasColumnName("cidade")
                    .HasMaxLength(255);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnderecoHospital)
                    .HasColumnName("endereco_hospital")
                    .HasMaxLength(255);

                entity.Property(e => e.NomeIncineradora)
                    .HasColumnName("nome_incineradora")
                    .HasMaxLength(255);

                entity.Property(e => e.Uf).HasColumnName("uf");
            });

            modelBuilder.Entity<Incineradora>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("INCINERADORA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Cidade)
                    .HasColumnName("cidade")
                    .HasMaxLength(255);

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NomeIncineradora)
                    .HasColumnName("nome_incineradora")
                    .HasMaxLength(255);

                entity.Property(e => e.TratamentoIncineradora)
                    .HasColumnName("tratamento_incineradora")
                    .HasMaxLength(255);

                entity.Property(e => e.Uf).HasColumnName("uf");

                entity.Property(e => e.Veiculo)
                    .HasColumnName("veiculo")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<InfopharmaUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Infopharma_Users");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UserAtivo)
                    .HasColumnName("User_Ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserCnpj)
                    .IsRequired()
                    .HasColumnName("User_Cnpj")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserCreateDate)
                    .HasColumnName("User_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("User_Email")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UserLastLogInDate)
                    .HasColumnName("User_LastLogInDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("User_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("User_Password")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Itemdado>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("ITEMDADO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DadoProcessoIdFk).HasColumnName("dado_processo_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrdemservicoIdFk).HasColumnName("ordemservico_id_fk");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.DadoProcessoIdFkNavigation)
                    .WithMany(p => p.Itemdado)
                    .HasForeignKey(d => d.DadoProcessoIdFk)
                    .HasConstraintName("FK8884CBE394CA929C");

                entity.HasOne(d => d.OrdemservicoIdFkNavigation)
                    .WithMany(p => p.Itemdado)
                    .HasForeignKey(d => d.OrdemservicoIdFk)
                    .HasConstraintName("FK8884CBE375867659");
            });

            modelBuilder.Entity<Itemdadopesquisa>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("ITEMDADOPESQUISA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DadoPesquisaIdFk).HasColumnName("dado_pesquisa_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrdemPesquisaIdFk).HasColumnName("ordem_pesquisa_id_fk");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.DadoPesquisaIdFkNavigation)
                    .WithMany(p => p.Itemdadopesquisa)
                    .HasForeignKey(d => d.DadoPesquisaIdFk)
                    .HasConstraintName("FKDF5DC7F24D41975C");

                entity.HasOne(d => d.OrdemPesquisaIdFkNavigation)
                    .WithMany(p => p.Itemdadopesquisa)
                    .HasForeignKey(d => d.OrdemPesquisaIdFk)
                    .HasConstraintName("FKDF5DC7F29F3228AA");
            });

            modelBuilder.Entity<Itemservicospop>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("ITEMSERVICOSPOP");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.PopIdFk).HasColumnName("pop_id_fk");

                entity.Property(e => e.ServicoPopIdFk).HasColumnName("servico_pop_id_fk");

                entity.HasOne(d => d.PopIdFkNavigation)
                    .WithMany(p => p.Itemservicospop)
                    .HasForeignKey(d => d.PopIdFk)
                    .HasConstraintName("FK8FD21A40D191CB5C");

                entity.HasOne(d => d.ServicoPopIdFkNavigation)
                    .WithMany(p => p.Itemservicospop)
                    .HasForeignKey(d => d.ServicoPopIdFk)
                    .HasConstraintName("FK8FD21A40BA8036E1");
            });

            modelBuilder.Entity<Lancamento>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("LANCAMENTO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ChequeIdFk).HasColumnName("cheque_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CodigoBarras)
                    .HasColumnName("codigo_barras")
                    .HasMaxLength(30);

                entity.Property(e => e.ConfirmadoRecebimentoBoleto).HasColumnName("confirmado_recebimento_boleto");

                entity.Property(e => e.ContaIdFk).HasColumnName("conta_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataLancamento)
                    .HasColumnName("data_lancamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataVencimento)
                    .HasColumnName("data_vencimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Desconto)
                    .HasColumnName("desconto")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Documento).HasColumnName("documento");

                entity.Property(e => e.EmailAposVencimento).HasColumnName("email_apos_vencimento");

                entity.Property(e => e.EmailLogoAposVencimento).HasColumnName("email_logo_apos_vencimento");

                entity.Property(e => e.EmailPreVencimento).HasColumnName("email_pre_vencimento");

                entity.Property(e => e.HistoricoLancamento)
                    .IsRequired()
                    .HasColumnName("historico_lancamento")
                    .HasMaxLength(1000);

                entity.Property(e => e.IdentificacaoBoleto)
                    .HasColumnName("identificacao_boleto")
                    .HasMaxLength(50);

                entity.Property(e => e.Juros)
                    .HasColumnName("juros")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.LinhaDigitavel)
                    .HasColumnName("linha_digitavel")
                    .HasMaxLength(60);

                entity.Property(e => e.MeioPagamento).HasColumnName("meio_pagamento");

                entity.Property(e => e.Multa)
                    .HasColumnName("multa")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.NomeBoletoParaUpload)
                    .HasColumnName("nome_boleto_para_upload")
                    .HasMaxLength(150);

                entity.Property(e => e.NumeroDocumento)
                    .HasColumnName("numero_documento")
                    .HasMaxLength(20);

                entity.Property(e => e.OrigemLancamentoIdFk).HasColumnName("origem_lancamento_id_fk");

                entity.Property(e => e.Parcela).HasColumnName("parcela");

                entity.Property(e => e.PlanoContasIdFk).HasColumnName("plano_contas_id_fk");

                entity.Property(e => e.Registrado).HasColumnName("registrado");

                entity.Property(e => e.Rejeitado).HasColumnName("rejeitado");

                entity.Property(e => e.StatusLancamento).HasColumnName("status_lancamento");

                entity.Property(e => e.TaxaBoleto)
                    .HasColumnName("taxa_boleto")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.TipoBaixa).HasColumnName("tipo_baixa");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ValorTotal)
                    .HasColumnName("valor_total")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.VezesCartao).HasColumnName("vezes_cartao");

                entity.HasOne(d => d.ChequeIdFkNavigation)
                    .WithMany(p => p.Lancamento)
                    .HasForeignKey(d => d.ChequeIdFk)
                    .HasConstraintName("FKE70314BCA977C67F");

                entity.HasOne(d => d.ContaIdFkNavigation)
                    .WithMany(p => p.Lancamento)
                    .HasForeignKey(d => d.ContaIdFk)
                    .HasConstraintName("FKE70314BCE31CF071");

                entity.HasOne(d => d.OrigemLancamentoIdFkNavigation)
                    .WithMany(p => p.Lancamento)
                    .HasForeignKey(d => d.OrigemLancamentoIdFk)
                    .HasConstraintName("FKE70314BCBC8FEC4E");

                entity.HasOne(d => d.PlanoContasIdFkNavigation)
                    .WithMany(p => p.Lancamento)
                    .HasForeignKey(d => d.PlanoContasIdFk)
                    .HasConstraintName("FKE70314BCE7371685");
            });

            modelBuilder.Entity<Lancamentoinativo>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("LANCAMENTOINATIVO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataLancamento)
                    .HasColumnName("data_lancamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataVencimento)
                    .HasColumnName("data_vencimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Desconto)
                    .HasColumnName("desconto")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.HistoricoLancamento)
                    .IsRequired()
                    .HasColumnName("Historico_lancamento")
                    .HasMaxLength(1200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdentificacaoBoleto)
                    .HasColumnName("identificacao_boleto")
                    .HasMaxLength(20);

                entity.Property(e => e.Juros)
                    .HasColumnName("juros")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.LancamentoIdFk).HasColumnName("lancamento_id_fk");

                entity.Property(e => e.Multa)
                    .HasColumnName("multa")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.OrigemLancamentoIdFk).HasColumnName("origem_lancamento_id_fk");

                entity.Property(e => e.Renegociado).HasColumnName("renegociado");

                entity.Property(e => e.StatusLancamento).HasColumnName("status_lancamento");

                entity.Property(e => e.TaxaBoleto)
                    .HasColumnName("taxa_boleto")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ValorTotal)
                    .HasColumnName("valor_total")
                    .HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.LancamentoIdFkNavigation)
                    .WithMany(p => p.Lancamentoinativo)
                    .HasForeignKey(d => d.LancamentoIdFk)
                    .HasConstraintName("FK6AFBBAFCD9CEA49");

                entity.HasOne(d => d.OrigemLancamentoIdFkNavigation)
                    .WithMany(p => p.Lancamentoinativo)
                    .HasForeignKey(d => d.OrigemLancamentoIdFk)
                    .HasConstraintName("FK6AFBBAFC42D4751A");
            });

            modelBuilder.Entity<Lanche>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("LANCHE");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(255);

                entity.Property(e => e.DiaSemana).HasColumnName("dia_semana");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecoUnitario)
                    .HasColumnName("preco_unitario")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.TipoLanche).HasColumnName("tipo_lanche");
            });

            modelBuilder.Entity<Legal>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("LEGAL");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponsavelContrato).HasColumnName("responsavel_contrato");

                entity.Property(e => e.ResponsavelIdFk).HasColumnName("responsavel_id_fk");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Legal)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FK5FFFD46DC0A3E2EE");

                entity.HasOne(d => d.ResponsavelIdFkNavigation)
                    .WithMany(p => p.Legal)
                    .HasForeignKey(d => d.ResponsavelIdFk)
                    .HasConstraintName("FK5FFFD46DC84F83CE");
            });

            modelBuilder.Entity<Ligacao>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("LIGACAO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAgendamento)
                    .HasColumnName("data_agendamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(500);

                entity.Property(e => e.NomeContato)
                    .IsRequired()
                    .HasColumnName("nome_contato")
                    .HasMaxLength(500);

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Ligacao)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FK3688575FC0A3E2EE");
            });

            modelBuilder.Entity<Logalteracoesfinanceiro>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("LOGALTERACOESFINANCEIRO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasMaxLength(3000);

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasColumnName("motivo")
                    .HasMaxLength(1500);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Logalteracoessistema>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("LOGALTERACOESSISTEMA");

                entity.Property(e => e.IdPk).HasColumnName("id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(3000);

                entity.Property(e => e.Motivo)
                    .HasColumnName("motivo")
                    .HasMaxLength(1500);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Logerrosservicoswindows>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("LOGERROSSERVICOSWINDOWS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataErro)
                    .HasColumnName("data_erro")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.MensagemErro)
                    .IsRequired()
                    .HasColumnName("mensagem_erro")
                    .HasMaxLength(2000);

                entity.Property(e => e.MensagemExcecao)
                    .IsRequired()
                    .HasColumnName("mensagem_excecao");

                entity.Property(e => e.ServicoWindowsIdFk).HasColumnName("servico_windows_id_fk");

                entity.Property(e => e.Visto).HasColumnName("visto");

                entity.HasOne(d => d.ServicoWindowsIdFkNavigation)
                    .WithMany(p => p.Logerrosservicoswindows)
                    .HasForeignKey(d => d.ServicoWindowsIdFk)
                    .HasConstraintName("FKB3AE0D576E2976E");
            });

            modelBuilder.Entity<Logexclusoessistema>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("LOGEXCLUSOESSISTEMA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasMaxLength(3000);

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasColumnName("motivo")
                    .HasMaxLength(1500);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Logsistema>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("LOGSISTEMA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Exception)
                    .HasColumnName("exception")
                    .HasMaxLength(2000);

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasColumnName("level")
                    .HasMaxLength(50);

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasColumnName("logger")
                    .HasMaxLength(255);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasMaxLength(4000);

                entity.Property(e => e.Thread)
                    .IsRequired()
                    .HasColumnName("thread")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Motivonaofechamentoproposta>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("MOTIVONAOFECHAMENTOPROPOSTA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Numerosequencialboleto>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("NUMEROSEQUENCIALBOLETO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumeroItau)
                    .HasColumnName("numero_itau")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ordempesquisa>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("ORDEMPESQUISA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataOrdem)
                    .HasColumnName("data_ordem")
                    .HasColumnType("datetime");

                entity.Property(e => e.NomeOrdem)
                    .HasColumnName("nome_ordem")
                    .HasMaxLength(255);

                entity.Property(e => e.Observacao).HasMaxLength(500);

                entity.Property(e => e.PesquisaIdFk).HasColumnName("pesquisa_id_fk");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Ordempesquisa)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FK895E7482C0A3E2EE");

                entity.HasOne(d => d.PesquisaIdFkNavigation)
                    .WithMany(p => p.Ordempesquisa)
                    .HasForeignKey(d => d.PesquisaIdFk)
                    .HasConstraintName("FK895E748284C215C0");
            });

            modelBuilder.Entity<Ordemservico>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("ORDEMSERVICO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataOrdem)
                    .HasColumnName("data_ordem")
                    .HasColumnType("datetime");

                entity.Property(e => e.NomeOrdem)
                    .HasColumnName("nome_ordem")
                    .HasMaxLength(255);

                entity.Property(e => e.NumeroOrdem).HasColumnName("numero_ordem");

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Ordemservico)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FKD4B50F24B764A226");
            });

            modelBuilder.Entity<Origemlancamento>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("ORIGEMLANCAMENTO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContratoIdFk).HasColumnName("contrato_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEmissao)
                    .HasColumnName("data_emissao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Documento).HasColumnName("documento");

                entity.Property(e => e.EntradaAvulsa).HasColumnName("entrada_avulsa");

                entity.Property(e => e.FornecedorIdFk).HasColumnName("fornecedor_id_fk");

                entity.Property(e => e.Historico)
                    .IsRequired()
                    .HasColumnName("historico")
                    .HasMaxLength(255);

                entity.Property(e => e.Juros)
                    .HasColumnName("juros")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Multa)
                    .HasColumnName("multa")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.NumeroDocumento)
                    .HasColumnName("numero_documento")
                    .HasMaxLength(50);

                entity.Property(e => e.Observacao)
                    .HasColumnName("observacao")
                    .HasMaxLength(255);

                entity.Property(e => e.PercentualJuros)
                    .HasColumnName("percentual_juros")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.PercentualMulta)
                    .HasColumnName("percentual_multa")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.StatusOrigemLancamento).HasColumnName("status_origem_lancamento");

                entity.Property(e => e.TipoBoleto).HasColumnName("tipo_boleto");

                entity.Property(e => e.TipoOrigemLancamento).HasColumnName("tipo_origem_lancamento");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Origemlancamento)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FK9C33EFA4C0A3E2EE");

                entity.HasOne(d => d.ContratoIdFkNavigation)
                    .WithMany(p => p.Origemlancamento)
                    .HasForeignKey(d => d.ContratoIdFk)
                    .HasConstraintName("FK9C33EFA4F353E7A7");

                entity.HasOne(d => d.FornecedorIdFkNavigation)
                    .WithMany(p => p.Origemlancamento)
                    .HasForeignKey(d => d.FornecedorIdFk)
                    .HasConstraintName("FK9C33EFA42CD73ED8");
            });

            modelBuilder.Entity<Parcelamentojuros>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("PARCELAMENTOJUROS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Juros)
                    .HasColumnName("juros")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.QtdParcelas).HasColumnName("qtd_parcelas");
            });

            modelBuilder.Entity<Permissaousuario>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("PERMISSAOUSUARIO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.CanCreate).HasColumnName("can_create");

                entity.Property(e => e.CanDelete).HasColumnName("can_delete");

                entity.Property(e => e.CanRead).HasColumnName("can_read");

                entity.Property(e => e.CanUpdate).HasColumnName("can_update");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.TelaSistemaIdFk).HasColumnName("tela_sistema_id_fk");

                entity.Property(e => e.UsuarioIdFk).HasColumnName("usuario_id_fk");

                entity.HasOne(d => d.TelaSistemaIdFkNavigation)
                    .WithMany(p => p.Permissaousuario)
                    .HasForeignKey(d => d.TelaSistemaIdFk)
                    .HasConstraintName("FK5AD5531353DCC702");

                entity.HasOne(d => d.UsuarioIdFkNavigation)
                    .WithMany(p => p.Permissaousuario)
                    .HasForeignKey(d => d.UsuarioIdFk)
                    .HasConstraintName("FK5AD55313B59B002F");
            });

            modelBuilder.Entity<Pesquisa>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("PESQUISA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataValidade)
                    .HasColumnName("data_validade")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoPesquisa)
                    .IsRequired()
                    .HasColumnName("descricao_pesquisa")
                    .HasMaxLength(255);

                entity.Property(e => e.GrupoOrdemIdFk).HasColumnName("grupo_ordem_id_fk");

                entity.Property(e => e.NomePesquisa)
                    .IsRequired()
                    .HasColumnName("nome_pesquisa")
                    .HasMaxLength(100);

                entity.HasOne(d => d.GrupoOrdemIdFkNavigation)
                    .WithMany(p => p.Pesquisa)
                    .HasForeignKey(d => d.GrupoOrdemIdFk)
                    .HasConstraintName("FK598D421582121F21");
            });

            modelBuilder.Entity<Peticionamentosafependentes>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("PETICIONAMENTOSAFEPENDENTES");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContratoIdFk).HasColumnName("contrato_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pendente).HasColumnName("pendente");

                entity.Property(e => e.StatusPeticionamento).HasColumnName("status_peticionamento");

                entity.HasOne(d => d.ContratoIdFkNavigation)
                    .WithMany(p => p.Peticionamentosafependentes)
                    .HasForeignKey(d => d.ContratoIdFk)
                    .HasConstraintName("FK88687B107F07A61");
            });

            modelBuilder.Entity<Pgrssmbp>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("PGRSSMBP");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.PgrssMbpIdFk).HasColumnName("pgrss_mbp_id_fk");

                entity.Property(e => e.ServicoPopIdFk).HasColumnName("servico_pop_id_fk");

                entity.Property(e => e.TagTexto).HasColumnName("tag_texto");

                entity.Property(e => e.TagTitulo).HasColumnName("tag_titulo");

                entity.Property(e => e.Texto).HasColumnName("texto");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo");

                entity.HasOne(d => d.PgrssMbpIdFkNavigation)
                    .WithMany(p => p.InversePgrssMbpIdFkNavigation)
                    .HasForeignKey(d => d.PgrssMbpIdFk)
                    .HasConstraintName("FKDED0AAEB32759385");

                entity.HasOne(d => d.ServicoPopIdFkNavigation)
                    .WithMany(p => p.Pgrssmbp)
                    .HasForeignKey(d => d.ServicoPopIdFk)
                    .HasConstraintName("FKDED0AAEBBA8036E1");
            });

            modelBuilder.Entity<Plano>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("PLANO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoPlano)
                    .IsRequired()
                    .HasColumnName("descricao_plano")
                    .HasMaxLength(256);

                entity.Property(e => e.Flexivel).HasColumnName("flexivel");

                entity.Property(e => e.NomePlano)
                    .IsRequired()
                    .HasColumnName("nome_plano")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Planocontas>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("PLANOCONTAS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContaIdFk).HasColumnName("conta_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoPlanoContas)
                    .IsRequired()
                    .HasColumnName("descricao_plano_contas")
                    .HasMaxLength(255);

                entity.Property(e => e.Nivel).HasColumnName("nivel");

                entity.Property(e => e.NomePlanoContas)
                    .IsRequired()
                    .HasColumnName("nome_plano_contas")
                    .HasMaxLength(80);

                entity.Property(e => e.PlanoContasIdFk).HasColumnName("plano_contas_id_fk");

                entity.Property(e => e.ReferenteAoMesAnterior).HasColumnName("referente_ao_mes_anterior");

                entity.Property(e => e.TextoInclusaoAutomatica)
                    .HasColumnName("texto_inclusao_automatica")
                    .HasMaxLength(255);

                entity.Property(e => e.TipoConta).HasColumnName("tipo_conta");

                entity.HasOne(d => d.ContaIdFkNavigation)
                    .WithMany(p => p.Planocontas)
                    .HasForeignKey(d => d.ContaIdFk)
                    .HasConstraintName("FKC7B4C22A6624E711");

                entity.HasOne(d => d.PlanoContasIdFkNavigation)
                    .WithMany(p => p.InversePlanoContasIdFkNavigation)
                    .HasForeignKey(d => d.PlanoContasIdFk)
                    .HasConstraintName("FKC7B4C22ADC0BFFF6");
            });

            modelBuilder.Entity<Pontocliente>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("PONTOCLIENTE");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoIndicado)
                    .HasColumnName("descricao_indicado")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimeiroPonto).HasColumnName("primeiro_ponto");

                entity.Property(e => e.ProgramaPontoIdFk).HasColumnName("programa_ponto_id_fk");

                entity.Property(e => e.UtilizadoDesconto).HasColumnName("utilizado_desconto");

                entity.Property(e => e.UtilizadoPremio).HasColumnName("utilizado_premio");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Pontocliente)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FK61457984D64882D9");

                entity.HasOne(d => d.ProgramaPontoIdFkNavigation)
                    .WithMany(p => p.Pontocliente)
                    .HasForeignKey(d => d.ProgramaPontoIdFk)
                    .HasConstraintName("FK61457984C46CF19E");
            });

            modelBuilder.Entity<Pops>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("POPS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.AfericaoPressao).HasColumnName("afericao_pressao");

                entity.Property(e => e.AparelhoGlicemia).HasColumnName("aparelho_glicemia");

                entity.Property(e => e.AplicacaoInjetaveis).HasColumnName("aplicacao_injetaveis");

                entity.Property(e => e.AquisicaoProdsEMedcs).HasColumnName("aquisicao_prods_e_medcs");

                entity.Property(e => e.ArmazenamentoInternoInfectante)
                    .HasColumnName("armazenamento_interno_infectante")
                    .HasMaxLength(255);

                entity.Property(e => e.ArmazenamentoInternoQuimico)
                    .HasColumnName("armazenamento_interno_quimico")
                    .HasMaxLength(255);

                entity.Property(e => e.Biosseguranca).HasColumnName("biosseguranca");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Climatizador).HasColumnName("climatizador");

                entity.Property(e => e.ConfDispAntiMicrobianos).HasColumnName("conf_disp_anti_microbianos");

                entity.Property(e => e.ConferenciaDispensacao).HasColumnName("conferencia_dispensacao");

                entity.Property(e => e.ControlePragas).HasColumnName("controle_pragas");

                entity.Property(e => e.ControleTempAmbiente).HasColumnName("controle_temp_ambiente");

                entity.Property(e => e.ControleTempGeladeira).HasColumnName("controle_temp_geladeira");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DesabilitarOpcoesPop).HasColumnName("desabilitar_opcoes_pop");

                entity.Property(e => e.Fracionados).HasColumnName("fracionados");

                entity.Property(e => e.FrequenciaColetaComum)
                    .HasColumnName("frequencia_coleta_comum")
                    .HasMaxLength(255);

                entity.Property(e => e.HigieneVestConduta).HasColumnName("higiene_vest_conduta");

                entity.Property(e => e.HorarioGeladeira1)
                    .HasColumnName("horario_geladeira1")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioGeladeira2)
                    .HasColumnName("horario_geladeira2")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioLimpezaDrogaria1)
                    .HasColumnName("horario_limpeza_drogaria1")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioLimpezaDrogaria2)
                    .HasColumnName("horario_limpeza_drogaria2")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioLimpezaInjetaveis1)
                    .HasColumnName("horario_limpeza_injetaveis1")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioLimpezaInjetaveis2)
                    .HasColumnName("horario_limpeza_injetaveis2")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioVerificaTemp1)
                    .HasColumnName("horario_verifica_temp1")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioVerificaTemp2)
                    .HasColumnName("horario_verifica_temp2")
                    .HasMaxLength(255);

                entity.Property(e => e.LavagemMaos).HasColumnName("lavagem_maos");

                entity.Property(e => e.Limpeza).HasColumnName("limpeza");

                entity.Property(e => e.LimpezaCaixaDagua).HasColumnName("limpeza_caixa_dagua");

                entity.Property(e => e.MedProximoVencimento).HasColumnName("med_proximo_vencimento");

                entity.Property(e => e.MonitoramentoGlicemia).HasColumnName("monitoramento_glicemia");

                entity.Property(e => e.PerfuracaoLobulo).HasColumnName("perfuracao_lobulo");

                entity.Property(e => e.RecebimentoArmazenamento).HasColumnName("recebimento_armazenamento");

                entity.Property(e => e.ReceitaA).HasColumnName("receita_a");

                entity.Property(e => e.ReceitaB1).HasColumnName("receita_b1");

                entity.Property(e => e.ReceitaB2).HasColumnName("receita_b2");

                entity.Property(e => e.ReceitaBranca).HasColumnName("receita_branca");

                entity.Property(e => e.RetirarMesesAntesVencimento).HasColumnName("retirar_meses_antes_vencimento");

                entity.Property(e => e.TemperaturaCorporal).HasColumnName("temperatura_corporal");

                entity.Property(e => e.Treinamento).HasColumnName("treinamento");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Pops)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FKA6299D6AC0A3E2EE");
            });

            modelBuilder.Entity<Premio>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("PREMIO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(255);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(150);

                entity.Property(e => e.NumeroPontos).HasColumnName("numero_pontos");

                entity.Property(e => e.UrlBanner)
                    .HasColumnName("url_banner")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Processo>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("PROCESSO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoProcesso)
                    .IsRequired()
                    .HasColumnName("descricao_processo")
                    .HasMaxLength(255);

                entity.Property(e => e.IdentificacaoProcesso)
                    .HasColumnName("identificacao_processo")
                    .HasMaxLength(255);

                entity.Property(e => e.NomeProcesso)
                    .IsRequired()
                    .HasColumnName("nome_processo")
                    .HasMaxLength(100);

                entity.Property(e => e.NumeroColunas).HasColumnName("numero_colunas");

                entity.Property(e => e.NumeroLinhas).HasColumnName("numero_linhas");

                entity.Property(e => e.NumeroProcesso).HasColumnName("numero_processo");

                entity.Property(e => e.Ordem).HasColumnName("ordem");

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.Property(e => e.TempoEstimado).HasColumnName("tempo_estimado");

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Processo)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FK975B3529B764A226");
            });

            modelBuilder.Entity<Programaponto>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("PROGRAMAPONTO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataValidade)
                    .HasColumnName("data_validade")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(250);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Programapontotipoponto>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("PROGRAMAPONTOTIPOPONTO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProgramaPontoIdFk).HasColumnName("programa_ponto_id_fk");

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.HasOne(d => d.ProgramaPontoIdFkNavigation)
                    .WithMany(p => p.Programapontotipoponto)
                    .HasForeignKey(d => d.ProgramaPontoIdFk)
                    .HasConstraintName("FK686E51FC46CF19E");

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Programapontotipoponto)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FK686E51F6DE33560");
            });

            modelBuilder.Entity<Proposta>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("PROPOSTA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.ClienteIndicadorIdFk).HasColumnName("cliente_indicador_id_fk");

                entity.Property(e => e.Codcliente).HasColumnName("CODCLIENTE");

                entity.Property(e => e.Codcontrato).HasColumnName("CODCONTRATO");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Codregracontrato).HasColumnName("CODREGRACONTRATO");

                entity.Property(e => e.ContratoIdFk).HasColumnName("contrato_id_fk");

                entity.Property(e => e.Contratoproposta).HasColumnName("CONTRATOPROPOSTA");

                entity.Property(e => e.Dataalteracao)
                    .HasColumnName("DATAALTERACAO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datainclusao)
                    .HasColumnName("DATAINCLUSAO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(300);

                entity.Property(e => e.Formapgto).HasColumnName("FORMAPGTO");

                entity.Property(e => e.HistoricoPropostasIdFk).HasColumnName("historico_propostas_id_fk");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Juros).HasColumnName("JUROS");

                entity.Property(e => e.MotivoNaoFechamentoPropostaFk).HasColumnName("motivo_nao_fechamento_proposta_fk");

                entity.Property(e => e.Observacao)
                    .HasColumnName("OBSERVACAO")
                    .HasColumnType("text");

                entity.Property(e => e.PorRepresentante).HasColumnName("por_representante");

                entity.Property(e => e.Primeiraparcela)
                    .HasColumnName("PRIMEIRAPARCELA")
                    .HasColumnType("datetime");

                entity.Property(e => e.PropostaFilial).HasColumnName("proposta_filial");

                entity.Property(e => e.PropostaIdFk).HasColumnName("proposta_id_fk");

                entity.Property(e => e.PropostaMatriz).HasColumnName("proposta_matriz");

                entity.Property(e => e.Qtdparcela).HasColumnName("QTDPARCELA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Telefones)
                    .HasColumnName("TELEFONES")
                    .HasMaxLength(255);

                entity.Property(e => e.TipoFechamentoContrato).HasColumnName("tipo_fechamento_contrato");

                entity.Property(e => e.UsuarioIdFk).HasColumnName("usuario_id_fk");

                entity.Property(e => e.Validadelicenca)
                    .HasColumnName("VALIDADELICENCA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Validadepacote)
                    .HasColumnName("VALIDADEPACOTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Valorprimeiraparcela)
                    .HasColumnName("VALORPRIMEIRAPARCELA")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Valortotal)
                    .HasColumnName("VALORTOTAL")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Valortotalalterado).HasColumnName("VALORTOTALALTERADO");

                entity.Property(e => e.Valortotalavista)
                    .HasColumnName("VALORTOTALAVISTA")
                    .HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.PropostaClienteIdFkNavigation)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKF10BF94AD64882D9");

                entity.HasOne(d => d.ClienteIndicadorIdFkNavigation)
                    .WithMany(p => p.PropostaClienteIndicadorIdFkNavigation)
                    .HasForeignKey(d => d.ClienteIndicadorIdFk)
                    .HasConstraintName("FKF10BF94AD892018B");

                entity.HasOne(d => d.CodcontratoNavigation)
                    .WithMany(p => p.PropostaCodcontratoNavigation)
                    .HasForeignKey(d => d.Codcontrato)
                    .HasConstraintName("FKF10BF94A2E120F29");

                entity.HasOne(d => d.CodregracontratoNavigation)
                    .WithMany(p => p.Proposta)
                    .HasForeignKey(d => d.Codregracontrato)
                    .HasConstraintName("FKF10BF94AD2914259");

                entity.HasOne(d => d.ContratoIdFkNavigation)
                    .WithMany(p => p.PropostaContratoIdFkNavigation)
                    .HasForeignKey(d => d.ContratoIdFk)
                    .HasConstraintName("FK42D892F4F353E7A7");

                entity.HasOne(d => d.HistoricoPropostasIdFkNavigation)
                    .WithMany(p => p.Proposta)
                    .HasForeignKey(d => d.HistoricoPropostasIdFk)
                    .HasConstraintName("FKF10BF94AEEBE7E4C");

                entity.HasOne(d => d.MotivoNaoFechamentoPropostaFkNavigation)
                    .WithMany(p => p.Proposta)
                    .HasForeignKey(d => d.MotivoNaoFechamentoPropostaFk)
                    .HasConstraintName("FKF10BF94A5DEB752A");

                entity.HasOne(d => d.PropostaIdFkNavigation)
                    .WithMany(p => p.InversePropostaIdFkNavigation)
                    .HasForeignKey(d => d.PropostaIdFk)
                    .HasConstraintName("FKF10BF94AA4354939");

                entity.HasOne(d => d.UsuarioIdFkNavigation)
                    .WithMany(p => p.Proposta)
                    .HasForeignKey(d => d.UsuarioIdFk)
                    .HasConstraintName("FKF10BF94A3A09D2F9");
            });

            modelBuilder.Entity<Propostaservico>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("PROPOSTASERVICO");

                entity.HasIndex(e => new { e.Codproposta, e.Codservico })
                    .HasName("IX_PROPOSTASERVICO")
                    .IsUnique();

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Codproposta).HasColumnName("CODPROPOSTA");

                entity.Property(e => e.Codservico).HasColumnName("CODSERVICO");

                entity.HasOne(d => d.CodpropostaNavigation)
                    .WithMany(p => p.Propostaservico)
                    .HasForeignKey(d => d.Codproposta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK9A1B6B9F8AA4DAA5");

                entity.HasOne(d => d.CodservicoNavigation)
                    .WithMany(p => p.Propostaservico)
                    .HasForeignKey(d => d.Codservico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK9A1B6B9F2184790D");
            });

            modelBuilder.Entity<Propostausuario>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("PROPOSTAUSUARIO");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Codproposta).HasColumnName("CODPROPOSTA");

                entity.Property(e => e.Coduser).HasColumnName("CODUSER");

                entity.HasOne(d => d.CodpropostaNavigation)
                    .WithMany(p => p.Propostausuario)
                    .HasForeignKey(d => d.Codproposta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROPOSTAUSUARIO_CODPROPOSTA_PROPOSTA_CODIGO");

                entity.HasOne(d => d.CoduserNavigation)
                    .WithMany(p => p.Propostausuario)
                    .HasForeignKey(d => d.Coduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROPOSTAUSUARIO_CODUSER");
            });

            modelBuilder.Entity<Regracontrato>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("REGRACONTRATO");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Diapagamentocontrato).HasColumnName("DIAPAGAMENTOCONTRATO");

                entity.Property(e => e.Diapagamentoespecifico).HasColumnName("DIAPAGAMENTOESPECIFICO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantidadeparcela).HasColumnName("QUANTIDADEPARCELA");
            });

            modelBuilder.Entity<Regracontratoparcela>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("REGRACONTRATOPARCELA");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Codprocesso).HasColumnName("CODPROCESSO");

                entity.Property(e => e.Codregracontrato).HasColumnName("CODREGRACONTRATO");

                entity.Property(e => e.DadoProcessoIdFk).HasColumnName("dado_processo_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Parcela).HasColumnName("PARCELA");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.HasOne(d => d.CodprocessoNavigation)
                    .WithMany(p => p.Regracontratoparcela)
                    .HasForeignKey(d => d.Codprocesso)
                    .HasConstraintName("FKCAA38C8569EEF7FD");

                entity.HasOne(d => d.CodregracontratoNavigation)
                    .WithMany(p => p.Regracontratoparcela)
                    .HasForeignKey(d => d.Codregracontrato)
                    .HasConstraintName("FKCAA38C85D2914259");

                entity.HasOne(d => d.DadoProcessoIdFkNavigation)
                    .WithMany(p => p.Regracontratoparcela)
                    .HasForeignKey(d => d.DadoProcessoIdFk)
                    .HasConstraintName("FKCAA38C8594CA929C");
            });

            modelBuilder.Entity<Regrascontrato>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("REGRASCONTRATO");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(255);

                entity.Property(e => e.Diapagamentocontrato).HasColumnName("DIAPAGAMENTOCONTRATO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantidadeparcela).HasColumnName("QUANTIDADEPARCELA");
            });

            modelBuilder.Entity<Regrausuario>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("REGRAUSUARIO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoRegra)
                    .IsRequired()
                    .HasColumnName("descricao_regra")
                    .HasMaxLength(100);

                entity.Property(e => e.NomeRegra)
                    .IsRequired()
                    .HasColumnName("nome_regra")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Remessa>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("REMESSA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ConteudoArquivoRemessa).HasColumnName("conteudo_arquivo_remessa");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.LancamentoId).HasColumnName("lancamento_id");

                entity.Property(e => e.NumeroRemessa).HasColumnName("numero_remessa");
            });

            modelBuilder.Entity<Responsavel>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("RESPONSAVEL");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.BairroIdFk).HasColumnName("bairro_id_fk");

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(20);

                entity.Property(e => e.CidadeIdFk).HasColumnName("cidade_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ConselhoRegional).HasColumnName("conselho_regional");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("cpf")
                    .HasMaxLength(20);

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataExpedicaoCrf)
                    .HasColumnName("data_expedicao_crf")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataExpedicaoRg)
                    .HasColumnName("data_expedicao_rg")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataNascimento)
                    .HasColumnName("data_nascimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataNascimentoConfirmada).HasColumnName("data_nascimento_confirmada");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailConfirmado).HasColumnName("email_confirmado");

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(150);

                entity.Property(e => e.EstadoCivil).HasColumnName("estado_civil");

                entity.Property(e => e.Nacionalidade)
                    .HasColumnName("nacionalidade")
                    .HasMaxLength(15);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(150);

                entity.Property(e => e.NomeMae)
                    .HasColumnName("nome_mae")
                    .HasMaxLength(100);

                entity.Property(e => e.NumeroCr)
                    .HasColumnName("numero_cr")
                    .HasMaxLength(12);

                entity.Property(e => e.OrgaoExpedidor).HasColumnName("orgao_expedidor");

                entity.Property(e => e.Profissao)
                    .HasColumnName("profissao")
                    .HasMaxLength(40);

                entity.Property(e => e.ResponsavelContrato).HasColumnName("responsavel_contrato");

                entity.Property(e => e.Rg)
                    .HasColumnName("rg")
                    .HasMaxLength(20);

                entity.Property(e => e.Sexo).HasColumnName("sexo");

                entity.Property(e => e.Uf).HasColumnName("uf");

                entity.Property(e => e.UfCr).HasColumnName("uf_cr");

                entity.Property(e => e.UfOrgaoExpedidor).HasColumnName("uf_orgao_expedidor");

                entity.HasOne(d => d.BairroIdFkNavigation)
                    .WithMany(p => p.Responsavel)
                    .HasForeignKey(d => d.BairroIdFk)
                    .HasConstraintName("FKAE9F7DFB9988AD15");

                entity.HasOne(d => d.CidadeIdFkNavigation)
                    .WithMany(p => p.Responsavel)
                    .HasForeignKey(d => d.CidadeIdFk)
                    .HasConstraintName("FKAE9F7DFBB4D0844");
            });

            modelBuilder.Entity<Senhacliente>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("SENHACLIENTE");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasMaxLength(255);

                entity.Property(e => e.TipoSenhaClienteIdFk).HasColumnName("tipo_senha_cliente_id_fk");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(255);

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Senhacliente)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FKE8897671D64882D9");

                entity.HasOne(d => d.TipoSenhaClienteIdFkNavigation)
                    .WithMany(p => p.Senhacliente)
                    .HasForeignKey(d => d.TipoSenhaClienteIdFk)
                    .HasConstraintName("FKE8897671F0071545");
            });

            modelBuilder.Entity<Senhas>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("SENHAS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(500);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("senha")
                    .HasMaxLength(100);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Servico>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("SERVICO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.AreaServicoIdFk).HasColumnName("area_servico_id_fk");

                entity.Property(e => e.Avulso).HasColumnName("avulso");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DadoProcessoIdFk).HasColumnName("dado_processo_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoServico)
                    .IsRequired()
                    .HasColumnName("descricao_servico")
                    .HasMaxLength(256);

                entity.Property(e => e.DiaPagamento).HasColumnName("dia_pagamento");

                entity.Property(e => e.FornecedorIdFk).HasColumnName("fornecedor_id_fk");

                entity.Property(e => e.GerarProcuracao).HasColumnName("gerar_procuracao");

                entity.Property(e => e.GrupoServicoIdFk).HasColumnName("grupo_servico_id_fk");

                entity.Property(e => e.HtmlResource)
                    .HasColumnName("html_resource")
                    .HasMaxLength(255);

                entity.Property(e => e.Inativo).HasColumnName("inativo");

                entity.Property(e => e.NomeServico)
                    .IsRequired()
                    .HasColumnName("nome_servico")
                    .HasMaxLength(150);

                entity.Property(e => e.SemProcesso).HasColumnName("sem_processo");

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.Property(e => e.Terceirizado).HasColumnName("terceirizado");

                entity.Property(e => e.TipoOferta).HasColumnName("tipo_oferta");

                entity.Property(e => e.TipoServicoIdFk).HasColumnName("tipo_servico_id_fk");

                entity.Property(e => e.UrlImagem)
                    .HasColumnName("url_imagem")
                    .HasMaxLength(255);

                entity.Property(e => e.UrlSite)
                    .HasColumnName("url_site")
                    .HasMaxLength(255);

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Valor2)
                    .HasColumnName("valor2")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Valor3)
                    .HasColumnName("valor3")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ValorDespesa)
                    .HasColumnName("valor_despesa")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ValorEntrada)
                    .HasColumnName("valor_entrada")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.VigenciaServico).HasColumnName("vigencia_servico");

                entity.HasOne(d => d.AreaServicoIdFkNavigation)
                    .WithMany(p => p.Servico)
                    .HasForeignKey(d => d.AreaServicoIdFk)
                    .HasConstraintName("FKC49C5A6BA270AD7C");

                entity.HasOne(d => d.DadoProcessoIdFkNavigation)
                    .WithMany(p => p.Servico)
                    .HasForeignKey(d => d.DadoProcessoIdFk)
                    .HasConstraintName("FKC49C5A6B94CA929C");

                entity.HasOne(d => d.FornecedorIdFkNavigation)
                    .WithMany(p => p.Servico)
                    .HasForeignKey(d => d.FornecedorIdFk)
                    .HasConstraintName("FKC49C5A6B32C12461");

                entity.HasOne(d => d.GrupoServicoIdFkNavigation)
                    .WithMany(p => p.Servico)
                    .HasForeignKey(d => d.GrupoServicoIdFk)
                    .HasConstraintName("FKC49C5A6B3A13554C");

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Servico)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FK9536F177C97A7D96");

                entity.HasOne(d => d.TipoServicoIdFkNavigation)
                    .WithMany(p => p.Servico)
                    .HasForeignKey(d => d.TipoServicoIdFk)
                    .HasConstraintName("FKC49C5A6BCA4E2C18");
            });

            modelBuilder.Entity<Servicocontrato>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("SERVICOCONTRATO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContratoIdFk).HasColumnName("contrato_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.ContratoIdFkNavigation)
                    .WithMany(p => p.Servicocontrato)
                    .HasForeignKey(d => d.ContratoIdFk)
                    .HasConstraintName("FKFD4EEE4F353E7A7");

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Servicocontrato)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FKFD4EEE4B764A226");
            });

            modelBuilder.Entity<Servicodocumentos>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("SERVICODOCUMENTOS");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Coddocumento).HasColumnName("CODDOCUMENTO");

                entity.Property(e => e.Codservico).HasColumnName("CODSERVICO");

                entity.HasOne(d => d.CoddocumentoNavigation)
                    .WithMany(p => p.Servicodocumentos)
                    .HasForeignKey(d => d.Coddocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKEEC7D0B07DA85D4D");

                entity.HasOne(d => d.CodservicoNavigation)
                    .WithMany(p => p.Servicodocumentos)
                    .HasForeignKey(d => d.Codservico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKEEC7D0B02184790D");
            });

            modelBuilder.Entity<Servicopop>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("SERVICOPOP");

                entity.Property(e => e.IdPk)
                    .HasColumnName("Id_pk")
                    .ValueGeneratedNever();

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoServico)
                    .HasColumnName("descricao_servico")
                    .HasMaxLength(255);

                entity.Property(e => e.NomeServico)
                    .HasColumnName("nome_servico")
                    .HasMaxLength(255);

                entity.Property(e => e.Obrigatorio).HasColumnName("obrigatorio");
            });

            modelBuilder.Entity<Servicoproposta>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("SERVICOPROPOSTA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.PropostaIdFk).HasColumnName("proposta_id_fk");

                entity.Property(e => e.ServicoIdFk).HasColumnName("servico_id_fk");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.PropostaIdFkNavigation)
                    .WithMany(p => p.Servicoproposta)
                    .HasForeignKey(d => d.PropostaIdFk)
                    .HasConstraintName("FK3F5CF477959C9BDE");

                entity.HasOne(d => d.ServicoIdFkNavigation)
                    .WithMany(p => p.Servicoproposta)
                    .HasForeignKey(d => d.ServicoIdFk)
                    .HasConstraintName("FK3F5CF477B764A226");
            });

            modelBuilder.Entity<Servicowindows>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("SERVICOWINDOWS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoServico)
                    .IsRequired()
                    .HasColumnName("descricao_servico")
                    .HasMaxLength(255);

                entity.Property(e => e.NomeDisplay)
                    .IsRequired()
                    .HasColumnName("nome_display")
                    .HasMaxLength(150);

                entity.Property(e => e.NomeServico)
                    .IsRequired()
                    .HasColumnName("nome_servico")
                    .HasMaxLength(150);

                entity.Property(e => e.Ordem).HasColumnName("ordem");

                entity.Property(e => e.UltimaExecucao)
                    .HasColumnName("ultima_execucao")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Solicitacaocontrato>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("SOLICITACAOCONTRATO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContratoIdFk).HasColumnName("contrato_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataDocGerado)
                    .HasColumnName("data_doc_gerado")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gerado).HasColumnName("gerado");

                entity.HasOne(d => d.ContratoIdFkNavigation)
                    .WithMany(p => p.Solicitacaocontrato)
                    .HasForeignKey(d => d.ContratoIdFk)
                    .HasConstraintName("FKD09EB6197F07A61");
            });

            modelBuilder.Entity<Solicitacaodoc>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("SOLICITACAODOC");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataDocGerado)
                    .HasColumnName("data_doc_gerado")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gerado).HasColumnName("gerado");

                entity.Property(e => e.TipoDoc).HasColumnName("tipo_doc");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Solicitacaodoc)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FKB198B34FD64882D9");
            });

            modelBuilder.Entity<Solicitacaopropostas>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("SOLICITACAOPROPOSTAS");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataGeracao)
                    .HasColumnName("data_geracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Enviado).HasColumnName("enviado");

                entity.Property(e => e.Gerado).HasColumnName("gerado");

                entity.Property(e => e.NumeroPropostas).HasColumnName("numero_propostas");

                entity.Property(e => e.UltimoIdCliente).HasColumnName("ultimo_id_cliente");

                entity.Property(e => e.UsuarioIdFk).HasColumnName("usuario_id_fk");

                entity.HasOne(d => d.UsuarioIdFkNavigation)
                    .WithMany(p => p.Solicitacaopropostas)
                    .HasForeignKey(d => d.UsuarioIdFk)
                    .HasConstraintName("FKF3E74C023A09D2F9");
            });

            modelBuilder.Entity<Tecnico>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("TECNICO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.CadastradoNoPbm).HasColumnName("cadastrado_no_pbm");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataPrimeiroRegistro).HasColumnName("data_primeiro_registro");

                entity.Property(e => e.HorarioDomingoManha)
                    .HasColumnName("horario_domingo_manha")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioDomingoTarde)
                    .HasColumnName("horario_domingo_tarde")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioQuartaManha)
                    .HasColumnName("horario_quarta_manha")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioQuartaTarde)
                    .HasColumnName("horario_quarta_tarde")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioQuintaManha)
                    .HasColumnName("horario_quinta_manha")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioQuintaTarde)
                    .HasColumnName("horario_quinta_tarde")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioSabadoManha)
                    .HasColumnName("horario_sabado_manha")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioSabadoTarde)
                    .HasColumnName("horario_sabado_tarde")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioSegundaManha)
                    .HasColumnName("horario_segunda_manha")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioSegundaTarde)
                    .HasColumnName("horario_segunda_tarde")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioSextaManha)
                    .HasColumnName("horario_sexta_manha")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioSextaTarde)
                    .HasColumnName("horario_sexta_tarde")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioTecaTarde)
                    .HasColumnName("horario_teca_tarde")
                    .HasMaxLength(255);

                entity.Property(e => e.HorarioTercaManha)
                    .HasColumnName("horario_terca_manha")
                    .HasMaxLength(255);

                entity.Property(e => e.ResponsavelIdFk).HasColumnName("responsavel_id_fk");

                entity.Property(e => e.Salario)
                    .HasColumnName("salario")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TecnicoPop).HasColumnName("tecnico_pop");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Tecnico)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FK814A3E35D64882D9");

                entity.HasOne(d => d.ResponsavelIdFkNavigation)
                    .WithMany(p => p.Tecnico)
                    .HasForeignKey(d => d.ResponsavelIdFk)
                    .HasConstraintName("FK814A3E3556CF38B9");
            });

            modelBuilder.Entity<Telasistema>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("TELASISTEMA");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(255);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Telefone>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("TELEFONE");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.ClienteIdFk).HasColumnName("cliente_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Contato)
                    .HasColumnName("contato")
                    .HasMaxLength(20);

                entity.Property(e => e.ContatoIdFk).HasColumnName("contato_id_fk");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ddd)
                    .IsRequired()
                    .HasColumnName("ddd")
                    .HasMaxLength(5);

                entity.Property(e => e.FornecedorIdFk).HasColumnName("fornecedor_id_fk");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasColumnName("numero")
                    .HasMaxLength(14);

                entity.Property(e => e.ResponsavelIdFk).HasColumnName("responsavel_id_fk");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.UsuarioIdFk).HasColumnName("usuario_id_fk");

                entity.HasOne(d => d.ClienteIdFkNavigation)
                    .WithMany(p => p.Telefone)
                    .HasForeignKey(d => d.ClienteIdFk)
                    .HasConstraintName("FK5B9C540D64882D9");

                entity.HasOne(d => d.ContatoIdFkNavigation)
                    .WithMany(p => p.Telefone)
                    .HasForeignKey(d => d.ContatoIdFk)
                    .HasConstraintName("FK5B9C54036EDC201");

                entity.HasOne(d => d.FornecedorIdFkNavigation)
                    .WithMany(p => p.Telefone)
                    .HasForeignKey(d => d.FornecedorIdFk)
                    .HasConstraintName("FK5B9C54032C12461");

                entity.HasOne(d => d.ResponsavelIdFkNavigation)
                    .WithMany(p => p.Telefone)
                    .HasForeignKey(d => d.ResponsavelIdFk)
                    .HasConstraintName("FK5B9C54056CF38B9");

                entity.HasOne(d => d.UsuarioIdFkNavigation)
                    .WithMany(p => p.Telefone)
                    .HasForeignKey(d => d.UsuarioIdFk)
                    .HasConstraintName("FK5B9C5403A09D2F9");
            });

            modelBuilder.Entity<Tipodocumentoservico>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("TIPODOCUMENTOSERVICO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.ContratoVigente).HasColumnName("contrato_vigente");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoTipoDocumentoServico)
                    .IsRequired()
                    .HasColumnName("descricao_tipo_documento_servico")
                    .HasMaxLength(255);

                entity.Property(e => e.NomeTipoDocumentoServico)
                    .IsRequired()
                    .HasColumnName("nome_tipo_documento_servico")
                    .HasMaxLength(100);

                entity.Property(e => e.TipoContrato).HasColumnName("tipo_contrato");
            });

            modelBuilder.Entity<Tipoponto>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("TIPOPONTO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(250);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(150);

                entity.Property(e => e.PremioIdFk).HasColumnName("premio_id_fk");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.ValorDesconto)
                    .HasColumnName("valor_desconto")
                    .HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ValorDescontoPrimeiro)
                    .HasColumnName("valor_desconto_primeiro")
                    .HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.PremioIdFkNavigation)
                    .WithMany(p => p.Tipoponto)
                    .HasForeignKey(d => d.PremioIdFk)
                    .HasConstraintName("FKDEC90FB796678FF7");
            });

            modelBuilder.Entity<Tiposenhacliente>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("TIPOSENHACLIENTE");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(255);

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tiposervico>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("TIPOSERVICO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescricaoTipoServico).HasColumnName("descricao_tipo_servico");

                entity.Property(e => e.ExecucaoUnica).HasColumnName("execucao_unica");

                entity.Property(e => e.NomeTipoServico)
                    .IsRequired()
                    .HasColumnName("nome_tipo_servico")
                    .HasMaxLength(150);

                entity.Property(e => e.NumeroMeses).HasColumnName("numero_meses");

                entity.Property(e => e.VigenciaServico).HasColumnName("vigencia_servico");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("USUARIO");

                entity.Property(e => e.IdPk).HasColumnName("Id_pk");

                entity.Property(e => e.BairroIdFk).HasColumnName("bairro_id_fk");

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(255);

                entity.Property(e => e.CidadeIdFk).HasColumnName("cidade_id_fk");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Comissao).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Cor).HasColumnName("cor");

                entity.Property(e => e.Cpf)
                    .HasColumnName("cpf")
                    .HasMaxLength(255);

                entity.Property(e => e.DataAlteracao)
                    .HasColumnName("data_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInclusao)
                    .HasColumnName("data_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailPassword)
                    .HasColumnName("email_password")
                    .HasMaxLength(255);

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(255);

                entity.Property(e => e.FornecedorIdFk).HasColumnName("fornecedor_id_fk");

                entity.Property(e => e.Inativo).HasColumnName("inativo");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.RegrausuarioIdFk).HasColumnName("regrausuario_id_fk");

                entity.Property(e => e.Rg)
                    .HasColumnName("rg")
                    .HasMaxLength(255);

                entity.Property(e => e.Shortcuts)
                    .HasColumnName("shortcuts")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);

                entity.HasOne(d => d.BairroIdFkNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.BairroIdFk)
                    .HasConstraintName("FK102B720E5801B011");

                entity.HasOne(d => d.CidadeIdFkNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.CidadeIdFk)
                    .HasConstraintName("FK102B720E401E5821");

                entity.HasOne(d => d.FornecedorIdFkNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.FornecedorIdFk)
                    .HasConstraintName("FK61D4E1D2CD73ED8");

                entity.HasOne(d => d.RegrausuarioIdFkNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.RegrausuarioIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK61D4E1DF3BB3464");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}