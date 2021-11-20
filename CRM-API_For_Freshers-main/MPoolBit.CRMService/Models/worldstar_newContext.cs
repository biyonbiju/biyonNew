using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MPoolBit.CRMService.Models
{
    public partial class worldstar_newContext : DbContext
    {
        public worldstar_newContext()
        {
        }

        public worldstar_newContext(DbContextOptions<worldstar_newContext> options)
            : base(options)
        {
        }
        public virtual DbSet<feedback>feedback { get; set; }

        public virtual DbSet<AccomodationType> AccomodationType { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountDocument> AccountDocument { get; set; }
        public virtual DbSet<AccountDocumentCategory> AccountDocumentCategory { get; set; }
        public virtual DbSet<AccountGroup> AccountGroup { get; set; }
        public virtual DbSet<AccountGroupCode> AccountGroupCode { get; set; }
        public virtual DbSet<AccountInvoice> AccountInvoice { get; set; }
        public virtual DbSet<AccountInvoiceDetails> AccountInvoiceDetails { get; set; }
        public virtual DbSet<AccountInvoiceType> AccountInvoiceType { get; set; }
        public virtual DbSet<AccountJournal> AccountJournal { get; set; }
        public virtual DbSet<AccountJournalBook> AccountJournalBook { get; set; }
        public virtual DbSet<AccountJournalBookDetail> AccountJournalBookDetail { get; set; }
        public virtual DbSet<AccountJournalDetails> AccountJournalDetails { get; set; }
        public virtual DbSet<AccountLedgerType> AccountLedgerType { get; set; }
        public virtual DbSet<AccountNote> AccountNote { get; set; }
        public virtual DbSet<AccountNoteAccount> AccountNoteAccount { get; set; }
        public virtual DbSet<AccountNoteInvoice> AccountNoteInvoice { get; set; }
        public virtual DbSet<AccountOpeningBalance> AccountOpeningBalance { get; set; }
        public virtual DbSet<AccountOpeningBalanceDetails> AccountOpeningBalanceDetails { get; set; }
        public virtual DbSet<AccountPaymentReceipt> AccountPaymentReceipt { get; set; }
        public virtual DbSet<AccountPaymentReceiptAccount> AccountPaymentReceiptAccount { get; set; }
        public virtual DbSet<AccountPaymentReceiptInvoice> AccountPaymentReceiptInvoice { get; set; }
        public virtual DbSet<AccountSettings> AccountSettings { get; set; }
        public virtual DbSet<AccountUserInvoice> AccountUserInvoice { get; set; }
        public virtual DbSet<AccountUserInvoiceDocument> AccountUserInvoiceDocument { get; set; }
        public virtual DbSet<ActivityLog> ActivityLog { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<AttendanceReason> AttendanceReason { get; set; }
        public virtual DbSet<AttendanceRegister> AttendanceRegister { get; set; }
        public virtual DbSet<AttendanceRegisterDetails> AttendanceRegisterDetails { get; set; }
        public virtual DbSet<AttendanceStatus> AttendanceStatus { get; set; }
        public virtual DbSet<BasicDetails> BasicDetails { get; set; }
        public virtual DbSet<BloodGroup> BloodGroup { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<BranchDocument> BranchDocument { get; set; }
        public virtual DbSet<Camp> Camp { get; set; }
        public virtual DbSet<CampAllocation> CampAllocation { get; set; }
        public virtual DbSet<ClientInvoiceDesignation> ClientInvoiceDesignation { get; set; }
        public virtual DbSet<ClientInvoiceExpense> ClientInvoiceExpense { get; set; }
        public virtual DbSet<ClientInvoiceProject> ClientInvoiceProject { get; set; }
        public virtual DbSet<ClientInvoiceReference> ClientInvoiceReference { get; set; }
        public virtual DbSet<ClientTimeSheet> ClientTimeSheet { get; set; }
        public virtual DbSet<ClientTimeSheetDesignation> ClientTimeSheetDesignation { get; set; }
        public virtual DbSet<ClientTimeSheetEmployee> ClientTimeSheetEmployee { get; set; }
        public virtual DbSet<ClientTimeSheetProject> ClientTimeSheetProject { get; set; }
        public virtual DbSet<CodeGenerator> CodeGenerator { get; set; }
        public virtual DbSet<CodeGeneratorModule> CodeGeneratorModule { get; set; }
        public virtual DbSet<ContractSalaryDetails> ContractSalaryDetails { get; set; }
        public virtual DbSet<CostCategory> CostCategory { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CrmcompanyType> CrmcompanyType { get; set; }
        public virtual DbSet<CrmcustomerSalesExecutiveHistory> CrmcustomerSalesExecutiveHistory { get; set; }
        public virtual DbSet<Crmlead> Crmlead { get; set; }
        public virtual DbSet<CrmleadComments> CrmleadComments { get; set; }
        public virtual DbSet<CrmleadDetails> CrmleadDetails { get; set; }
        public virtual DbSet<CrmleadReference> CrmleadReference { get; set; }
        public virtual DbSet<CrmleadSource> CrmleadSource { get; set; }
        public virtual DbSet<CrmleadStatus> CrmleadStatus { get; set; }
        public virtual DbSet<Crmopportunity> Crmopportunity { get; set; }
        public virtual DbSet<CrmopportunityDetail> CrmopportunityDetail { get; set; }
        public virtual DbSet<Crmpriority> Crmpriority { get; set; }
        public virtual DbSet<Crmpurpose> Crmpurpose { get; set; }
        public virtual DbSet<Crmtask> Crmtask { get; set; }
        public virtual DbSet<CrmopportunityTerms> CrmopportunityTerms { get; set; }
        public virtual DbSet<CrmtaskDetail> CrmtaskDetail { get; set; }
        public virtual DbSet<CrmtaskDocument> CrmtaskDocument { get; set; }
        public virtual DbSet<CrmtaskType> CrmtaskType { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<DeMobilizeReason> DeMobilizeReason { get; set; }
        public virtual DbSet<DemandRequest> DemandRequest { get; set; }
        public virtual DbSet<DemandRequestAction> DemandRequestAction { get; set; }
        public virtual DbSet<DemandRequestAllocation> DemandRequestAllocation { get; set; }
        public virtual DbSet<CrmquotationTerms> CrmquotationTerms { get; set; }
        public virtual DbSet<DemandRequestReason> DemandRequestReason { get; set; }
        public virtual DbSet<DemandRequestStatus> DemandRequestStatus { get; set; }
        public virtual DbSet<DemandRequestTrades> DemandRequestTrades { get; set; }
        public virtual DbSet<DemandRequestType> DemandRequestType { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<WorkCategory> WorkCategory { get; set; }
        public virtual DbSet<Designation> Designation { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<DocumentType> DocumentType { get; set; }
        public virtual DbSet<Eidstatus> Eidstatus { get; set; }
        public virtual DbSet<Emirate> Emirate { get; set; }
        public virtual DbSet<FileMigrationInserted> FileMigrationInserted { get; set; }
        public virtual DbSet<FinancialPeriod> FinancialPeriod { get; set; }
        public virtual DbSet<GradeType> GradeType { get; set; }
        public virtual DbSet<HeadDepartment> HeadDepartment { get; set; }
        public virtual DbSet<HoliDay> HoliDay { get; set; }
        public virtual DbSet<HolidayType> HolidayType { get; set; }
        public virtual DbSet<InactiveReason> InactiveReason { get; set; }
        public virtual DbSet<InsuranceCardType> InsuranceCardType { get; set; }
        public virtual DbSet<InvoiceExpenseType> InvoiceExpenseType { get; set; }
        public virtual DbSet<InvoiceReferenceHeadType> InvoiceReferenceHeadType { get; set; }
        public virtual DbSet<JobDetails> JobDetails { get; set; }
        public virtual DbSet<KnownTrade> KnownTrade { get; set; }
        public virtual DbSet<LabourTimeCard> LabourTimeCard { get; set; }
        public virtual DbSet<LabourTimeCardHeader> LabourTimeCardHeader { get; set; }
        public virtual DbSet<LicenceType> LicenceType { get; set; }
        public virtual DbSet<LineManager> LineManager { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<MedicalDetails> MedicalDetails { get; set; }
        public virtual DbSet<MedicalStatus> MedicalStatus { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<NocAccomadationStatus> NocAccomadationStatus { get; set; }
        public virtual DbSet<NocDeMobilizeStatus> NocDeMobilizeStatus { get; set; }
        public virtual DbSet<NocDetails> NocDetails { get; set; }
        public virtual DbSet<NocEmployeeDetails> NocEmployeeDetails { get; set; }
        public virtual DbSet<NocRenarks> NocRenarks { get; set; }
        public virtual DbSet<NocReportType> NocReportType { get; set; }
        public virtual DbSet<NocSafetyStatus> NocSafetyStatus { get; set; }
        public virtual DbSet<NocStatus> NocStatus { get; set; }
        public virtual DbSet<NocTradeReason> NocTradeReason { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<OccuranceType> OccuranceType { get; set; }
        public virtual DbSet<OfficeLocation> OfficeLocation { get; set; }
        public virtual DbSet<OperationSettings> OperationSettings { get; set; }
        public virtual DbSet<Organisation> Organisation { get; set; }
        public virtual DbSet<PassportStatus> PassportStatus { get; set; }
        public virtual DbSet<PaymentMode> PaymentMode { get; set; }
        public virtual DbSet<PaymentSchedule> PaymentSchedule { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PermissionType> PermissionType { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectDetails> ProjectDetails { get; set; }
        public virtual DbSet<ProjectDocument> ProjectDocument { get; set; }
        public virtual DbSet<ProjectHolidayDetails> ProjectHolidayDetails { get; set; }
        public virtual DbSet<ProjectLocation> ProjectLocation { get; set; }
        public virtual DbSet<ProjectRate> ProjectRate { get; set; }
        public virtual DbSet<ProjectType> ProjectType { get; set; }
        public virtual DbSet<RateContractTemplete> RateContractTemplete { get; set; }
        public virtual DbSet<RateContractTempleteTrades> RateContractTempleteTrades { get; set; }
        public virtual DbSet<RateType> RateType { get; set; }
        public virtual DbSet<Religion> Religion { get; set; }
        public virtual DbSet<SalaryDetails> SalaryDetails { get; set; }
        public virtual DbSet<SalaryHead> SalaryHead { get; set; }
        public virtual DbSet<SalaryHeadValue> SalaryHeadValue { get; set; }
        public virtual DbSet<SponsorshipCompany> SponsorshipCompany { get; set; }
        public virtual DbSet<SponsorshipCompanyDocument> SponsorshipCompanyDocument { get; set; }
        public virtual DbSet<StaffSalary> StaffSalary { get; set; }
        public virtual DbSet<StaffSalaryHeader> StaffSalaryHeader { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<SupplierDescription> SupplierDescription { get; set; }
        public virtual DbSet<SupplierInvoiceDetails> SupplierInvoiceDetails { get; set; }
        public virtual DbSet<SupplierTimeCard> SupplierTimeCard { get; set; }
        public virtual DbSet<SupplierTimeCardHeader> SupplierTimeCardHeader { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserCategory> UserCategory { get; set; }
        public virtual DbSet<UserDetails> UserDetails { get; set; }
        public virtual DbSet<UserDocument> UserDocument { get; set; }
        public virtual DbSet<UserHistory> UserHistory { get; set; }
        public virtual DbSet<UserRate> UserRate { get; set; }
        public virtual DbSet<UserRefrence> UserRefrence { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserRoleCategory> UserRoleCategory { get; set; }
        public virtual DbSet<UserRoleRules> UserRoleRules { get; set; }
        public virtual DbSet<UserSponsorshipCompany> UserSponsorshipCompany { get; set; }
        public virtual DbSet<UserTransfer> UserTransfer { get; set; }
        public virtual DbSet<VisaSponsor> VisaSponsor { get; set; }
        public virtual DbSet<VisaStatus> VisaStatus { get; set; }
        public virtual DbSet<VisaType> VisaType { get; set; }
        public virtual DbSet<CrmleadDocuments> CrmleadDocuments { get; set; }
        public virtual DbSet<SisterConcernCompanies> SisterConcernCompanies { get; set; }
        public virtual DbSet<LeadComments> LeadComments { get; set; }
        public virtual DbSet<CustomerEvaluation> CustomerEvaluation { get; set; }
        public virtual DbSet<CustomerEvaluationAnswer> CustomerEvaluationAnswer { get; set; }
        public virtual DbSet<CustomerEvaluationDetails> CustomerEvaluationDetails { get; set; }
        public virtual DbSet<CustomerEvaluationQuestionnaire> CustomerEvaluationQuestionnaire { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=64.227.35.33;port=3306;user=admin;password=T0utBit!123;database=worldstar_new;SslMode=None;Allow User Variables=True;Connection Timeout=300;default command timeout=600");
               // optionsBuilder.UseMySQL("server=65.0.69.106; port=3306;user=Admin; password=T0utBit!; database=mpoolbit;SslMode=None;Allow User Variables=True;Connection Timeout=300;default command timeout=600");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccomodationType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasIndex(e => e.AccountGroupId)
                    .HasName("AccountHeadAccountGroup_idx");

                entity.HasIndex(e => e.CostCategoryId)
                    .HasName("AccountCostCategoryId_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("AccountSponsorshipCompany_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountGroupId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodeNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CostCategoryId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsBlocked)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(20,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.HasOne(d => d.AccountGroup)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.AccountGroupId)
                    .HasConstraintName("AccountHeadAccountGroup");

                entity.HasOne(d => d.CostCategory)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.CostCategoryId)
                    .HasConstraintName("AccountCostCategoryId");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("AccountSponsorshipCompany");
            });

            modelBuilder.Entity<AccountDocument>(entity =>
            {
                entity.HasIndex(e => e.AccountHeadId)
                    .HasName("DocumentAccountHead_idx");

                entity.HasIndex(e => e.Category)
                    .HasName("AccountDocumentCategory_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("AccountDocumentSponsorshipCompany_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountHeadId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttachmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Category).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsPdc)
                    .HasColumnName("IsPDC")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.JournlPrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentPrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptPrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.AccountHead)
                    .WithMany(p => p.AccountDocument)
                    .HasForeignKey(d => d.AccountHeadId)
                    .HasConstraintName("DocumentAccountHead");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.AccountDocument)
                    .HasForeignKey(d => d.Category)
                    .HasConstraintName("AccountDocumentCategory");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.AccountDocument)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("AccountDocumentSponsorshipCompany");
            });

            modelBuilder.Entity<AccountDocumentCategory>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Type)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountGroup>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ParentLevel)
                    .HasName("ParentLevelId_idx");

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("AccountGroupSponsorshipCompany_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CodeNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LevelName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LevelNo).HasColumnType("int(11)");

                entity.Property(e => e.ParentLevel).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.ParentLevelNavigation)
                    .WithMany(p => p.InverseParentLevelNavigation)
                    .HasForeignKey(d => d.ParentLevel)
                    .HasConstraintName("ParentLevelId");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.AccountGroup)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("AccountGroupSponsorshipCompany");
            });

            modelBuilder.Entity<AccountGroupCode>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ParentId)
                    .HasName("AccountGroupCodeAccountGroup_idx");

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("AccountGroupCodeSponsorshipCompany_idx");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.LastestCode).HasColumnType("int(11)");

                entity.Property(e => e.Level).HasColumnType("int(11)");

                entity.Property(e => e.ParentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.AccountGroupCode)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("AccountGroupCodeAccountGroup");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.AccountGroupCode)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("AccountGroupCodeSponsorshipCompany");
            });

            modelBuilder.Entity<AccountInvoice>(entity =>
            {
                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("AccountInvoiceFinancialPeriod_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.PartyNameId)
                    .HasName("UserPartyNameId_idx");

                entity.HasIndex(e => e.SponsershipCompanyId)
                    .HasName("SponsershipCompanyId_idx");

                entity.HasIndex(e => e.TypeId)
                    .HasName("AccountInvoiceAccountInvoiceType_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.PartyNameId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SponsershipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TypeId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.AccountInvoice)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("AccountInvoiceFinancialPeriod");

                entity.HasOne(d => d.PartyName)
                    .WithMany(p => p.AccountInvoice)
                    .HasForeignKey(d => d.PartyNameId)
                    .HasConstraintName("AccountInvoicePartyName");

                entity.HasOne(d => d.SponsershipCompany)
                    .WithMany(p => p.AccountInvoice)
                    .HasForeignKey(d => d.SponsershipCompanyId)
                    .HasConstraintName("AccountInvoiceSponsershipCompany");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.AccountInvoice)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("AccountInvoiceAccountInvoiceType");
            });

            modelBuilder.Entity<AccountInvoiceDetails>(entity =>
            {
                entity.HasIndex(e => e.AccountInvoiceId)
                    .HasName("AccountInvoiceDetailsAccountInvoice_idx");

                entity.HasIndex(e => e.CostCategoryId)
                    .HasName("AccountInvoiceDetailsCostCategory_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountInvoiceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.CostCategoryId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LpoDnNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountInvoice)
                    .WithMany(p => p.AccountInvoiceDetails)
                    .HasForeignKey(d => d.AccountInvoiceId)
                    .HasConstraintName("AccountInvoiceDetailsAccountInvoice");

                entity.HasOne(d => d.CostCategory)
                    .WithMany(p => p.AccountInvoiceDetails)
                    .HasForeignKey(d => d.CostCategoryId)
                    .HasConstraintName("AccountInvoiceDetailsCostCategory");
            });

            modelBuilder.Entity<AccountInvoiceType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountJournal>(entity =>
            {
                entity.HasIndex(e => e.DocumentUploadId)
                    .HasName("AccountJournalAttachment_idx");

                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("AccountJournalFinancialPeriod_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("AccountJournalSponsorshipCompany_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DocumentUploadId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.JournelCode)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.DocumentUpload)
                    .WithMany(p => p.AccountJournal)
                    .HasForeignKey(d => d.DocumentUploadId)
                    .HasConstraintName("AccountJournalAttachment");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.AccountJournal)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("AccountJournalFinancialPeriod_idx");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.AccountJournal)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("AccountJournalSponsorshipCompany");
            });

            modelBuilder.Entity<AccountJournalBook>(entity =>
            {
                entity.HasIndex(e => e.AccountDocumentId)
                    .HasName("AccountJournalBookAccountDocument_idx");

                entity.HasIndex(e => e.AccountUserInvoiceId)
                    .HasName("AccountJournalBookAccountUserInvoice_idx");

                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("AccountJournalBookFinancialPeriod_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("AccountJournalBookSponsorshipCompany_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountDocumentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountUserInvoiceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Jnumber)
                    .HasColumnName("JNumber")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RefNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.AccountDocument)
                    .WithMany(p => p.AccountJournalBook)
                    .HasForeignKey(d => d.AccountDocumentId)
                    .HasConstraintName("AccountJournalBookAccountDocument");

                entity.HasOne(d => d.AccountUserInvoice)
                    .WithMany(p => p.AccountJournalBook)
                    .HasForeignKey(d => d.AccountUserInvoiceId)
                    .HasConstraintName("AccountJournalBookAccountUserInvoice");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.AccountJournalBook)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("AccountJournalBookFinancialPeriod");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.AccountJournalBook)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("AccountJournalBookSponsorshipCompany");
            });

            modelBuilder.Entity<AccountJournalBookDetail>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("AccountJournalBookDetailAccount_idx");

                entity.HasIndex(e => e.AccountJournalBookId)
                    .HasName("AccountJournalBookDetailAccountJournalBook_idx");

                entity.HasIndex(e => e.CostCategoryId)
                    .HasName("AccountJournalBookDetailCostCategory_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectId)
                    .HasName("AccountJournalBookDetailProject_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountJournalBookId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CostCategoryId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsTax)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Narration)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountJournalBookDetail)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("AccountJournalBookDetailAccount");

                entity.HasOne(d => d.AccountJournalBook)
                    .WithMany(p => p.AccountJournalBookDetail)
                    .HasForeignKey(d => d.AccountJournalBookId)
                    .HasConstraintName("AccountJournalBookDetailAccountJournalBook");

                entity.HasOne(d => d.CostCategory)
                    .WithMany(p => p.AccountJournalBookDetail)
                    .HasForeignKey(d => d.CostCategoryId)
                    .HasConstraintName("AccountJournalBookDetailCostCategory");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AccountJournalBookDetail)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("AccountJournalBookDetailProject");
            });

            modelBuilder.Entity<AccountJournalDetails>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("AccountJournalDetailsAccount_idx");

                entity.HasIndex(e => e.AccountJournalId)
                    .HasName("AccountJournalDetailsAccountJournal_idx");

                entity.HasIndex(e => e.CostCentreId)
                    .HasName("AccountJournalDetailsCostCentre_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountJournalId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CostCentreId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CreditAmount)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.DebitAmount)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountJournalDetails)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("AccountJournalDetailsAccount");

                entity.HasOne(d => d.AccountJournal)
                    .WithMany(p => p.AccountJournalDetails)
                    .HasForeignKey(d => d.AccountJournalId)
                    .HasConstraintName("AccountJournalDetailsAccountJournal");

                entity.HasOne(d => d.CostCentre)
                    .WithMany(p => p.AccountJournalDetails)
                    .HasForeignKey(d => d.CostCentreId)
                    .HasConstraintName("AccountJournalDetailsCostCentre");
            });

            modelBuilder.Entity<AccountLedgerType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Type)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountNote>(entity =>
            {
                entity.HasIndex(e => e.DocumentUploadId)
                    .HasName("AccountCreditNoteDocument_idx");

                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("AccountNoteFinancialPeriod_idx");

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("AccountNoteSponsorshipCompany_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("AccountCreditNoteClient_idx");

                entity.HasIndex(e => e.UserRoleId)
                    .HasName("AccountNoteUserRole_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AcknowledgementCopy).HasColumnType("bit(1)");

                entity.Property(e => e.CreditNoteNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentUploadId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserRoleId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.DocumentUpload)
                    .WithMany(p => p.AccountNote)
                    .HasForeignKey(d => d.DocumentUploadId)
                    .HasConstraintName("AccountCreditNoteDocument");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.AccountNote)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("AccountNoteFinancialPeriod");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.AccountNote)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("AccountNoteSponsorshipCompany");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccountNote)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("AccountNoteUser");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.AccountNote)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("AccountNoteUserRole");
            });

            modelBuilder.Entity<AccountNoteAccount>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("AccountNoteAccountAccount_idx");

                entity.HasIndex(e => e.AccountNoteId)
                    .HasName("AccountNoteAccountAccountNote_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountNoteId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Narration)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountNoteAccount)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("AccountNoteAccountAccount");

                entity.HasOne(d => d.AccountNote)
                    .WithMany(p => p.AccountNoteAccount)
                    .HasForeignKey(d => d.AccountNoteId)
                    .HasConstraintName("AccountNoteAccountAccountNote");
            });

            modelBuilder.Entity<AccountNoteInvoice>(entity =>
            {
                entity.HasIndex(e => e.AccountNoteId)
                    .HasName("AccountCreditNoteAccountAccountCreditNote_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.InvoiceId)
                    .HasName("AccountCreditNoteAccountInvoice_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountNoteId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.InvoiceAmount)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.InvoiceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.AccountNote)
                    .WithMany(p => p.AccountNoteInvoice)
                    .HasForeignKey(d => d.AccountNoteId)
                    .HasConstraintName("AccountCreditNoteInvoiceAccountCreditNote");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.AccountNoteInvoice)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("AccountCreditNoteInvoiceInvoice");
            });

            modelBuilder.Entity<AccountOpeningBalance>(entity =>
            {
                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("AccountOpeningBalanceFinancialPeriod_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("AccountOpeningBalanceSponsorshipCompany_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.AccountOpeningBalance)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("AccountOpeningBalanceFinancialPeriod");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.AccountOpeningBalance)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("AccountOpeningBalanceSponsorshipCompany");
            });

            modelBuilder.Entity<AccountOpeningBalanceDetails>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("AccountOpeningDetailsAccount_idx");

                entity.HasIndex(e => e.AccountOpeningId)
                    .HasName("AccountOpeningDetailsAccountOpening_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountOpeningId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountOpeningBalanceDetails)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("AccountOpeningBalanceDetailsAccount");

                entity.HasOne(d => d.AccountOpening)
                    .WithMany(p => p.AccountOpeningBalanceDetails)
                    .HasForeignKey(d => d.AccountOpeningId)
                    .HasConstraintName("AccountOpeningBalanceDetailsAccountOpening");
            });

            modelBuilder.Entity<AccountPaymentReceipt>(entity =>
            {
                entity.HasIndex(e => e.AccountDocumentId)
                    .HasName("AccountPaymentReceiptAccountDocument_idx");

                entity.HasIndex(e => e.ApprovedById)
                    .HasName("AccountPaymentReceiptApprovedBy_idx");

                entity.HasIndex(e => e.CheckedById)
                    .HasName("AccountPaymentReceiptCheckedBy_idx");

                entity.HasIndex(e => e.DocumentUploadId)
                    .HasName("AccountPaymentReceiptDocumentUpload_idx");

                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("AccountPaymentReceiptFinancialPeriod_idx");

                entity.HasIndex(e => e.LedgerTypeId)
                    .HasName("AccountPaymentReceiptAccountLedgerType_idx");

                entity.HasIndex(e => e.PaymentModeId)
                    .HasName("AccountPaymentReceiptPaymentMode_idx");

                entity.HasIndex(e => e.PreparedById)
                    .HasName("AccountPaymentReceiptPreparedBy_idx");

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("AccountPaymentReceiptSponsorshipCompany_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("AccountPaymentReceiptUser_idx");

                entity.HasIndex(e => e.UserRoleId)
                    .HasName("AccountPaymentReceiptUserRole_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountDocumentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ApprovedById).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BprvNo)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CheckedById).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CustBank)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentUploadId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.GrandTotal).HasColumnType("decimal(20,2)");

                entity.Property(e => e.HasPayee).HasColumnType("bit(1)");

                entity.Property(e => e.IsApproved)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsVerified)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LedgerTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Payee)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentModeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PreparedById).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Status).HasColumnType("bit(1)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserRemarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.AccountDocument)
                    .WithMany(p => p.AccountPaymentReceipt)
                    .HasForeignKey(d => d.AccountDocumentId)
                    .HasConstraintName("AccountPaymentReceiptAccountDocument");

                entity.HasOne(d => d.ApprovedBy)
                    .WithMany(p => p.AccountPaymentReceiptApprovedBy)
                    .HasForeignKey(d => d.ApprovedById)
                    .HasConstraintName("AccountPaymentReceiptApprovedBy");

                entity.HasOne(d => d.CheckedBy)
                    .WithMany(p => p.AccountPaymentReceiptCheckedBy)
                    .HasForeignKey(d => d.CheckedById)
                    .HasConstraintName("AccountPaymentReceiptCheckedBy");

                entity.HasOne(d => d.DocumentUpload)
                    .WithMany(p => p.AccountPaymentReceipt)
                    .HasForeignKey(d => d.DocumentUploadId)
                    .HasConstraintName("AccountPaymentReceiptDocumentUpload");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.AccountPaymentReceipt)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("AccountPaymentReceiptFinancialPeriod");

                entity.HasOne(d => d.LedgerType)
                    .WithMany(p => p.AccountPaymentReceipt)
                    .HasForeignKey(d => d.LedgerTypeId)
                    .HasConstraintName("AccountPaymentReceiptAccountLedgerType");

                entity.HasOne(d => d.PaymentMode)
                    .WithMany(p => p.AccountPaymentReceipt)
                    .HasForeignKey(d => d.PaymentModeId)
                    .HasConstraintName("AccountPaymentReceiptPaymentMode");

                entity.HasOne(d => d.PreparedBy)
                    .WithMany(p => p.AccountPaymentReceiptPreparedBy)
                    .HasForeignKey(d => d.PreparedById)
                    .HasConstraintName("AccountPaymentReceiptPreparedBy");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.AccountPaymentReceipt)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("AccountPaymentReceiptSponsorshipCompany");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccountPaymentReceiptUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("AccountPaymentReceiptUser");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.AccountPaymentReceipt)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("AccountPaymentReceiptUserRole");
            });

            modelBuilder.Entity<AccountPaymentReceiptAccount>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("AccountPaymentReceiptDetailsAccount_idx");

                entity.HasIndex(e => e.AccountPaymentReceiptId)
                    .HasName("AccountPaymentReceiptDetailsAccountPayment_idx");

                entity.HasIndex(e => e.CostCentreId)
                    .HasName("AccountPaymentReceiptDetailsCostCentre_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountPaymentReceiptId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CostCentreId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CreditAmount)
                    .HasColumnType("decimal(20,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.DebitAmount)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.Narration)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountPaymentReceiptAccount)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("AccountPaymentReceiptDetailsAccount");

                entity.HasOne(d => d.AccountPaymentReceipt)
                    .WithMany(p => p.AccountPaymentReceiptAccount)
                    .HasForeignKey(d => d.AccountPaymentReceiptId)
                    .HasConstraintName("AccountPaymentReceiptDetailsAccountPayment");

                entity.HasOne(d => d.CostCentre)
                    .WithMany(p => p.AccountPaymentReceiptAccount)
                    .HasForeignKey(d => d.CostCentreId)
                    .HasConstraintName("AccountPaymentReceiptDetailsCostCentre");
            });

            modelBuilder.Entity<AccountPaymentReceiptInvoice>(entity =>
            {
                entity.HasIndex(e => e.AccountPaymentReceiptId)
                    .HasName("AccountPaymentReceiptInvoiceAccountPaymentReceipt_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.InvoiceId)
                    .HasName("AccountPaymentReceiptInvoiceAccountUserInvoice_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountPaymentReceiptId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.InvoiceAmount)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.InvoiceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.AccountPaymentReceipt)
                    .WithMany(p => p.AccountPaymentReceiptInvoice)
                    .HasForeignKey(d => d.AccountPaymentReceiptId)
                    .HasConstraintName("AccountPaymentReceiptInvoiceAccountPaymentReceipt");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.AccountPaymentReceiptInvoice)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("AccountPaymentReceiptInvoiceAccountUserInvoice");
            });

            modelBuilder.Entity<AccountSettings>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("AccountSettingsBranch_idx");

                entity.HasIndex(e => e.CreditNoteAccountId)
                    .HasName("AccountSettingsCreditNoteAccount_idx");

                entity.HasIndex(e => e.CreditNoteDocumentId)
                    .HasName("AccountSettingsCreditNoteDocument_idx");

                entity.HasIndex(e => e.CurrencyId)
                    .HasName("AccountSettingsCurrency_idx");

                entity.HasIndex(e => e.DebitNoteAccountId)
                    .HasName("AccountSettingsDebitNoteAccount_idx");

                entity.HasIndex(e => e.DebitNoteDocumentId)
                    .HasName("AccountSettingsDebitNoteDocument_idx");

                entity.HasIndex(e => e.DefaultCashAccountId)
                    .HasName("AccountSettingsDefaultCashAccount_idx");

                entity.HasIndex(e => e.DefaultCustomerAccountId)
                    .HasName("AccountSettingsDefaultCustomerAccountId_idx");

                entity.HasIndex(e => e.DefaultJournlDocumentId)
                    .HasName("AccountSettingsDefaultJournalDocument_idx");

                entity.HasIndex(e => e.DefaultSupplierAccountId)
                    .HasName("AccountSettingsDefaultSupplierAccount_idx");

                entity.HasIndex(e => e.DepreciationDocumentId)
                    .HasName("AccountSettingsDepreciationDocument_idx");

                entity.HasIndex(e => e.EmployeeLoanAccountGroupId)
                    .HasName("AccountSettingsLoanAccountGroup_idx");

                entity.HasIndex(e => e.EmployeeSalaryAccountGroupId)
                    .HasName("AccountSettingsSalaryAccountGroup_idx");

                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("AccountsSettingsFinancialPeriod_idx");

                entity.HasIndex(e => e.GainLossAccountId)
                    .HasName("AccountSettingsFxAGainLoosAccount_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.InputTaxAccountId)
                    .HasName("AccountSettingsInputTaxAccount_idx");

                entity.HasIndex(e => e.LeaveSalaryAccountId)
                    .HasName("AccountSettingsLeaveSalaryAccount_idx");

                entity.HasIndex(e => e.LoanAccountId)
                    .HasName("AccountSettingsLoanAccount_idx");

                entity.HasIndex(e => e.OtherDeductionAccountId)
                    .HasName("AccountSettingsOtherDeductionAccount_idx");

                entity.HasIndex(e => e.OutputTaxAccountId)
                    .HasName("AccountSettingsOutputTaxAccount_idx");

                entity.HasIndex(e => e.PdcpaymentDocumentId)
                    .HasName("AccountSettingsPDCPaymentDocument_idx");

                entity.HasIndex(e => e.PdcreceiptDocumentId)
                    .HasName("AccountSettingsPDCReceipantDocument_idx");

                entity.HasIndex(e => e.ProjectAccountId)
                    .HasName("AccountSettingsProjectAccount_idx");

                entity.HasIndex(e => e.PurchaseAccountId)
                    .HasName("AccountSettingsPurchaseAccount_idx");

                entity.HasIndex(e => e.SalaryAccountId)
                    .HasName("AccountSettingsSalaryAccount_idx");

                entity.HasIndex(e => e.SalesAccountId)
                    .HasName("AccountSettingsSalesAccount_idx");

                entity.HasIndex(e => e.SecurityAccountId)
                    .HasName("AccountSettingsSecurityAccount_idx");

                entity.HasIndex(e => e.SettlementAccountId)
                    .HasName("AccountSettingsSettlementAccount_idx");

                entity.HasIndex(e => e.SiteAllowanceAccountId)
                    .HasName("AccountSettingsSiteAllowanceAccount_idx");

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("AccountSettingsSponsorshipCompany_idx");

                entity.HasIndex(e => e.SundryCreditorAccountGroupId)
                    .HasName("AccountSettingsSundyCreditAccountGroup_idx");

                entity.HasIndex(e => e.SundryDebtorAccountGroupId)
                    .HasName("AccountSettingsSundryDebitAccountGroup_idx");

                entity.HasIndex(e => e.TelephoneAccountId)
                    .HasName("AccountSettingsTelephoneAccount_idx");

                entity.HasIndex(e => e.VehicleFineAccountId)
                    .HasName("AccountSettingsVehicleFineAccount_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BankPaymentDocumentNumber)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BankReceiptDocumentNumber)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CashPaymentDocumentNumber)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CashReceiptDocumentNumber)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ContraDocumentNumber)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreditNoteAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CreditNoteDocumentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CurrencyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DebitNoteAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DebitNoteDocumentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DefaultCashAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DefaultCustomerAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DefaultJournlDocumentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DefaultSupplierAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DepreciationDocumentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EmployeeLoanAccountGroupId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EmployeeSalaryAccountGroupId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.GainLossAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.InputTax)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.InputTaxAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.JournlDocumentNumber)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LeaveSalaryAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LoanAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OtherDeductionAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OutputTax)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.OutputTaxAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PdcpaymentDocumentId)
                    .HasColumnName("PDCPaymentDocumentId")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PdcreceiptDocumentId)
                    .HasColumnName("PDCReceiptDocumentId")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ProjectAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PurchaceInvoiceDocumentNumber)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PurchaceInvoicePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PurchaseOrderDocumentNumber)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SalaryAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SalesAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SalesInvoiceDocumentNumber)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SalesInvoicePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SettlementAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SiteAllowanceAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SundryCreditorAccountGroupId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SundryDebtorAccountGroupId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TaxPercentage).HasColumnType("decimal(10,2)");

                entity.Property(e => e.TelephoneAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.VehicleFineAccountId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.AccountSettings)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("AccountSettingsBranch");

                entity.HasOne(d => d.CreditNoteAccount)
                    .WithMany(p => p.AccountSettingsCreditNoteAccount)
                    .HasForeignKey(d => d.CreditNoteAccountId)
                    .HasConstraintName("AccountSettingsCreditNoteAccount");

                entity.HasOne(d => d.CreditNoteDocument)
                    .WithMany(p => p.AccountSettingsCreditNoteDocument)
                    .HasForeignKey(d => d.CreditNoteDocumentId)
                    .HasConstraintName("AccountSettingsCreditNoteDocument");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.AccountSettings)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("AccountSettingsCurrency");

                entity.HasOne(d => d.DebitNoteAccount)
                    .WithMany(p => p.AccountSettingsDebitNoteAccount)
                    .HasForeignKey(d => d.DebitNoteAccountId)
                    .HasConstraintName("AccountSettingsDebitNoteAccount");

                entity.HasOne(d => d.DebitNoteDocument)
                    .WithMany(p => p.AccountSettingsDebitNoteDocument)
                    .HasForeignKey(d => d.DebitNoteDocumentId)
                    .HasConstraintName("AccountSettingsDebitNoteDocument");

                entity.HasOne(d => d.DefaultCashAccount)
                    .WithMany(p => p.AccountSettingsDefaultCashAccount)
                    .HasForeignKey(d => d.DefaultCashAccountId)
                    .HasConstraintName("AccountSettingsDefaultCashAccount");

                entity.HasOne(d => d.DefaultCustomerAccount)
                    .WithMany(p => p.AccountSettingsDefaultCustomerAccount)
                    .HasForeignKey(d => d.DefaultCustomerAccountId)
                    .HasConstraintName("AccountSettingsDefaultCustomerAccountId");

                entity.HasOne(d => d.DefaultJournlDocument)
                    .WithMany(p => p.AccountSettingsDefaultJournlDocument)
                    .HasForeignKey(d => d.DefaultJournlDocumentId)
                    .HasConstraintName("AccountSettingsDefaultJournalDocument");

                entity.HasOne(d => d.DefaultSupplierAccount)
                    .WithMany(p => p.AccountSettingsDefaultSupplierAccount)
                    .HasForeignKey(d => d.DefaultSupplierAccountId)
                    .HasConstraintName("AccountSettingsDefaultSupplierAccount");

                entity.HasOne(d => d.DepreciationDocument)
                    .WithMany(p => p.AccountSettingsDepreciationDocument)
                    .HasForeignKey(d => d.DepreciationDocumentId)
                    .HasConstraintName("AccountSettingsDepreciationDocument");

                entity.HasOne(d => d.EmployeeLoanAccountGroup)
                    .WithMany(p => p.AccountSettingsEmployeeLoanAccountGroup)
                    .HasForeignKey(d => d.EmployeeLoanAccountGroupId)
                    .HasConstraintName("AccountSettingsEmployeeLoanAccountGroup");

                entity.HasOne(d => d.EmployeeSalaryAccountGroup)
                    .WithMany(p => p.AccountSettingsEmployeeSalaryAccountGroup)
                    .HasForeignKey(d => d.EmployeeSalaryAccountGroupId)
                    .HasConstraintName("AccountSettingsEmployeeSalaryAccountGroup");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.AccountSettings)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("AccountsSettingsFinancialPeriod");

                entity.HasOne(d => d.GainLossAccount)
                    .WithMany(p => p.AccountSettingsGainLossAccount)
                    .HasForeignKey(d => d.GainLossAccountId)
                    .HasConstraintName("AccountSettingsGainLossAccount");

                entity.HasOne(d => d.InputTaxAccount)
                    .WithMany(p => p.AccountSettingsInputTaxAccount)
                    .HasForeignKey(d => d.InputTaxAccountId)
                    .HasConstraintName("AccountSettingsInputTaxAccount");

                entity.HasOne(d => d.LeaveSalaryAccount)
                    .WithMany(p => p.AccountSettingsLeaveSalaryAccount)
                    .HasForeignKey(d => d.LeaveSalaryAccountId)
                    .HasConstraintName("AccountSettingsLeaveSalaryAccount");

                entity.HasOne(d => d.LoanAccount)
                    .WithMany(p => p.AccountSettingsLoanAccount)
                    .HasForeignKey(d => d.LoanAccountId)
                    .HasConstraintName("AccountSettingsLoanAccount");

                entity.HasOne(d => d.OtherDeductionAccount)
                    .WithMany(p => p.AccountSettingsOtherDeductionAccount)
                    .HasForeignKey(d => d.OtherDeductionAccountId)
                    .HasConstraintName("AccountSettingsOtherDeductionAccount");

                entity.HasOne(d => d.OutputTaxAccount)
                    .WithMany(p => p.AccountSettingsOutputTaxAccount)
                    .HasForeignKey(d => d.OutputTaxAccountId)
                    .HasConstraintName("AccountSettingsOutputTaxAccount");

                entity.HasOne(d => d.PdcpaymentDocument)
                    .WithMany(p => p.AccountSettingsPdcpaymentDocument)
                    .HasForeignKey(d => d.PdcpaymentDocumentId)
                    .HasConstraintName("AccountSettingsPDCPaymentDocument");

                entity.HasOne(d => d.PdcreceiptDocument)
                    .WithMany(p => p.AccountSettingsPdcreceiptDocument)
                    .HasForeignKey(d => d.PdcreceiptDocumentId)
                    .HasConstraintName("AccountSettingsPDCReceipantDocument");

                entity.HasOne(d => d.ProjectAccount)
                    .WithMany(p => p.AccountSettingsProjectAccount)
                    .HasForeignKey(d => d.ProjectAccountId)
                    .HasConstraintName("AccountSettingsProjectAccount");

                entity.HasOne(d => d.PurchaseAccount)
                    .WithMany(p => p.AccountSettingsPurchaseAccount)
                    .HasForeignKey(d => d.PurchaseAccountId)
                    .HasConstraintName("AccountSettingsPurchaseAccount");

                entity.HasOne(d => d.SalaryAccount)
                    .WithMany(p => p.AccountSettingsSalaryAccount)
                    .HasForeignKey(d => d.SalaryAccountId)
                    .HasConstraintName("AccountSettingsSalaryAccount");

                entity.HasOne(d => d.SalesAccount)
                    .WithMany(p => p.AccountSettingsSalesAccount)
                    .HasForeignKey(d => d.SalesAccountId)
                    .HasConstraintName("AccountSettingsSalesAccount");

                entity.HasOne(d => d.SecurityAccount)
                    .WithMany(p => p.AccountSettingsSecurityAccount)
                    .HasForeignKey(d => d.SecurityAccountId)
                    .HasConstraintName("AccountSettingsSecurityAccount");

                entity.HasOne(d => d.SettlementAccount)
                    .WithMany(p => p.AccountSettingsSettlementAccount)
                    .HasForeignKey(d => d.SettlementAccountId)
                    .HasConstraintName("AccountSettingsSettlementAccount");

                entity.HasOne(d => d.SiteAllowanceAccount)
                    .WithMany(p => p.AccountSettingsSiteAllowanceAccount)
                    .HasForeignKey(d => d.SiteAllowanceAccountId)
                    .HasConstraintName("AccountSettingsSiteAllowanceAccount");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.AccountSettings)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("AccountSettingsSponsorshipCompany");

                entity.HasOne(d => d.SundryCreditorAccountGroup)
                    .WithMany(p => p.AccountSettingsSundryCreditorAccountGroup)
                    .HasForeignKey(d => d.SundryCreditorAccountGroupId)
                    .HasConstraintName("AccountSettingsSundyCreditAccountGroup");

                entity.HasOne(d => d.SundryDebtorAccountGroup)
                    .WithMany(p => p.AccountSettingsSundryDebtorAccountGroup)
                    .HasForeignKey(d => d.SundryDebtorAccountGroupId)
                    .HasConstraintName("AccountSettingsSundryDebitAccountGroup");

                entity.HasOne(d => d.TelephoneAccount)
                    .WithMany(p => p.AccountSettingsTelephoneAccount)
                    .HasForeignKey(d => d.TelephoneAccountId)
                    .HasConstraintName("AccountSettingsTelephoneAccount");

                entity.HasOne(d => d.VehicleFineAccount)
                    .WithMany(p => p.AccountSettingsVehicleFineAccount)
                    .HasForeignKey(d => d.VehicleFineAccountId)
                    .HasConstraintName("AccountSettingsVehicleFineAccount");
            });

            modelBuilder.Entity<AccountUserInvoice>(entity =>
            {
                entity.HasIndex(e => e.AccountDocumentId)
                    .HasName("AccountUserInvoiceAccountDocument_idx");

                entity.HasIndex(e => e.ApprovedById)
                    .HasName("AccountUserInvoiceApprovedBy_idx");

                entity.HasIndex(e => e.CheckedById)
                    .HasName("AccountUserInvoiceCheckedBy_idx");

                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("AccountUserInvoiceFinancialPeriod_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.PreparedById)
                    .HasName("AccountUserInvoicePreparedBy_idx");

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("AccountUserInvoiceDetailsSponsorshipCompany_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("AccountUserInvoiceDetailsUser_idx");

                entity.HasIndex(e => e.UserRoleId)
                    .HasName("AccountUserInvoiceUserRole_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AbsentPenality)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.AccountDocumentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Advance)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ApprovedById).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckedById).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Deduction)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.InvoiceAmount)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsAdvance)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDirectInvoice)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsFinal)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsPaymentCertificateFinal).HasColumnType("bit(1)");

                entity.Property(e => e.IsPerformaInvoice).HasColumnType("bit(1)");

                entity.Property(e => e.IsPosted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsTransfer)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Month).HasColumnType("int(11)");

                entity.Property(e => e.NetTotal)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.PreparedById).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SafetyDeduction)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.TaxPercentage).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserRoleId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.HasOne(d => d.AccountDocument)
                    .WithMany(p => p.AccountUserInvoice)
                    .HasForeignKey(d => d.AccountDocumentId)
                    .HasConstraintName("AccountUserInvoiceAccountDocument");

                entity.HasOne(d => d.ApprovedBy)
                    .WithMany(p => p.AccountUserInvoiceApprovedBy)
                    .HasForeignKey(d => d.ApprovedById)
                    .HasConstraintName("AccountUserInvoiceApprovedBy");

                entity.HasOne(d => d.CheckedBy)
                    .WithMany(p => p.AccountUserInvoiceCheckedBy)
                    .HasForeignKey(d => d.CheckedById)
                    .HasConstraintName("AccountUserInvoiceCheckedBy");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.AccountUserInvoice)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("AccountUserInvoiceFinancialPeriod");

                entity.HasOne(d => d.PreparedBy)
                    .WithMany(p => p.AccountUserInvoicePreparedBy)
                    .HasForeignKey(d => d.PreparedById)
                    .HasConstraintName("AccountUserInvoicePreparedBy");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.AccountUserInvoice)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("AccountUserDetailsSponsorshipCompany");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccountUserInvoiceUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("AccountUsertInvoiceDetailsUser");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.AccountUserInvoice)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("AccountUserInvoiceUserRole");

                entity.Property(e => e.BalanceAmountPr)
                  .HasColumnName("BalanceAmountPR")
                  .HasColumnType("decimal(10,2)")
                  .HasDefaultValueSql("'0.00'");
            });

            modelBuilder.Entity<AccountUserInvoiceDocument>(entity =>
            {
                entity.HasIndex(e => e.AccountUserInvoiceId)
                    .HasName("AccountUserInvoiceDocumenAccountUserInvoicet_idx");

                entity.HasIndex(e => e.AttachmentId)
                    .HasName("AccountUserInvoiceDocumentAttachemnt_idx");

                entity.HasIndex(e => e.DocumentTypeId)
                    .HasName("AccountUserInvoiceDocumentDocumentType_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountUserInvoiceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttachmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.AccountUserInvoice)
                    .WithMany(p => p.AccountUserInvoiceDocument)
                    .HasForeignKey(d => d.AccountUserInvoiceId)
                    .HasConstraintName("AccountUserInvoiceDocumenAccountUserInvoicet");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.AccountUserInvoiceDocument)
                    .HasForeignKey(d => d.AttachmentId)
                    .HasConstraintName("AccountUserInvoiceDocumentAttachemnt");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.AccountUserInvoiceDocument)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("AccountUserInvoiceDocumentDocumentType");
            });

            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy)
                    .HasName("ActivityLogCreated_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ModuleId)
                    .HasName("ActivityLogModuleId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Activity)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ModuleId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Path)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("ActivityLogCreatedUser");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("ActivityLogModuleId");
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttendanceReason>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeductiable).HasColumnType("bit(1)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Reason)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttendanceRegister>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("AttendanceRegisterBranch_idx");

                entity.HasIndex(e => e.CampId)
                    .HasName("AttendanceRegisterCamo_idx");

                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("AttendanceRegisterFinancialPeriod_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectId)
                    .HasName("AttendenceRegisterProject_idx");

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("AttendanceRegisterSponsorshipCompany_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CampId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsCamp)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsCompleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsHoliday)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.AttendanceRegister)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("AttendanceRegisterBranch");

                entity.HasOne(d => d.Camp)
                    .WithMany(p => p.AttendanceRegister)
                    .HasForeignKey(d => d.CampId)
                    .HasConstraintName("AttendanceRegisterCamo");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.AttendanceRegister)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("AttendanceRegisterFinancialPeriod");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AttendanceRegister)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("AttendenceRegisterProject");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.AttendanceRegister)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("AttendanceRegisterSponsorshipCompany");
            });

            modelBuilder.Entity<AttendanceRegisterDetails>(entity =>
            {
                entity.HasIndex(e => e.AttendanceReasonId)
                    .HasName("AttendenceRegisterDetailsAttendenceReason_idx");

                entity.HasIndex(e => e.AttendanceRegisterId)
                    .HasName("AttendenceRegisterDetailsAttendenceRegister_idx");

                entity.HasIndex(e => e.AttendanceStatusId)
                    .HasName("AttendenceRegisterDetailsAttendenceStatus_idx");

                entity.HasIndex(e => e.DesignationId)
                    .HasName("AttendenceRegisterDetailsDesignation_idx");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("AttendenceRegisterDetailsEmployee");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttendanceReasonId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttendanceRegisterId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttendanceStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EmployeeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.AttendanceReason)
                    .WithMany(p => p.AttendanceRegisterDetails)
                    .HasForeignKey(d => d.AttendanceReasonId)
                    .HasConstraintName("AttendenceRegisterDetailsAttendanceReason");

                entity.HasOne(d => d.AttendanceRegister)
                    .WithMany(p => p.AttendanceRegisterDetails)
                    .HasForeignKey(d => d.AttendanceRegisterId)
                    .HasConstraintName("AttendenceRegisterDetailsAttendaenceRegister");

                entity.HasOne(d => d.AttendanceStatus)
                    .WithMany(p => p.AttendanceRegisterDetails)
                    .HasForeignKey(d => d.AttendanceStatusId)
                    .HasConstraintName("AttendenceRegisterDetailsAttendanceStatus");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.AttendanceRegisterDetails)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("AttendenceRegisterDetailsDesignation");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AttendanceRegisterDetails)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("AttendenceRegisterDetailsEmployee");
            });

            modelBuilder.Entity<AttendanceStatus>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BasicDetails>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("UserAccountId_idx");

                entity.HasIndex(e => e.AdvanceAccountId)
                    .HasName("UserAdvanceAcoountId_idx");

                entity.HasIndex(e => e.BloodGroupId)
                    .HasName("UserBloodGroup_idx");

                entity.HasIndex(e => e.BranchId)
                    .HasName("UserBranchId_idx");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("UserCategoryId_idx");

                entity.HasIndex(e => e.CountryId)
                    .HasName("UserCountryId_idx");

                entity.HasIndex(e => e.CurrencyId)
                    .HasName("UserCurrencyId_idx");

                entity.HasIndex(e => e.DistrictId)
                    .HasName("UserDistrictId_idx");

                entity.HasIndex(e => e.EmiratesId)
                    .HasName("UserEmiratesId_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.InactiveReasonId)
                    .HasName("BasicDetailsInactiveReason_idx");

                entity.HasIndex(e => e.LocationId)
                    .HasName("UserLocationId_idx");

                entity.HasIndex(e => e.PaymentScheduleId)
                    .HasName("UserPaymentScheduleId_idx");

                entity.HasIndex(e => e.PhotoId)
                    .HasName("UserPhoto_idx");

                entity.HasIndex(e => e.ReligionId)
                    .HasName("UserReligionId_idx");

                entity.HasIndex(e => e.SignatureId)
                    .HasName("BasicDetailsSignature_idx");

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("UserSponsorshipCompanyId_idx");

                entity.HasIndex(e => e.StateId)
                    .HasName("UserStateId_idx");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("UserSupplierId_idx");

                entity.HasIndex(e => e.UserRoleCategoryId)
                    .HasName("BasicDetailsUserRoleCategory_idx");

                entity.HasIndex(e => e.SalesExecutiveId)
                    .HasName("BasicDetailsSalesExecutive_idx");

                entity.HasIndex(e => e.OfficePhotoId)
                    .HasName("BasicDetailsOfficePhoto_idx");

                entity.HasIndex(e => e.OutsideViewPhotoId)
                    .HasName("BasicDetailsOutsideViewPhoto_idx");

                entity.HasIndex(e => e.CommentId)
                    .HasName("BasicDetailsComment_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SalutationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.StatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SalesTarget).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AdvanceAccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Age)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BloodGroupId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");
                entity.Property(e => e.CreatedBy).HasColumnType("bigint(20) unsigned");
                entity.Property(e => e.SalesExecutiveId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Code)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CurrencyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DistrictId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Dob).HasColumnName("DOB");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactAddress)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmiratesId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HomeContactAddress)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HomeContactName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.HomeContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.InactiveReasonId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IncorporatedName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.LocalCompanyMobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocalContactAddress)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                  .HasMaxLength(200)
                  .IsUnicode(false);

                entity.Property(e => e.Longitude)
                   .HasMaxLength(200)
                   .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MolPersonCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentScheduleId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PhotoId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Pobox)
                    .HasColumnName("POBox")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousId)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ReligionId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.StateId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SupplierId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TelephoneNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Trn)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleCategoryId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OfficePhotoId).HasColumnType("bigint unsigned");

                entity.Property(e => e.OutsideViewPhotoId).HasColumnType("bigint unsigned");

                entity.Property(e => e.CommentId).HasColumnType("bigint unsigned");

                entity.Property(e => e.IsOwnLead).HasColumnType("bit(1)");
               
			    entity.Property(e => e.MakaniNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.BasicDetailsAccount)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("UserAccountId");

                entity.HasOne(d => d.AdvanceAccount)
                    .WithMany(p => p.BasicDetailsAdvanceAccount)
                    .HasForeignKey(d => d.AdvanceAccountId)
                    .HasConstraintName("UserAdvanceAcoountId");

                entity.HasOne(d => d.BloodGroup)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.BloodGroupId)
                    .HasConstraintName("UserBloodGroup");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("UserBranchId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("UserCategoryId");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("UserCountryId");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("UserCurrencyId");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("UserDistrictId");

                entity.HasOne(d => d.Emirates)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.EmiratesId)
                    .HasConstraintName("UserEmiratesId");

                entity.HasOne(d => d.InactiveReason)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.InactiveReasonId)
                    .HasConstraintName("BasicDetailsInactiveReason");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("UserLocationId");

                entity.HasOne(d => d.PaymentSchedule)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.PaymentScheduleId)
                    .HasConstraintName("UserPaymentScheduleId");

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.BasicDetailsPhoto)
                    .HasForeignKey(d => d.PhotoId)
                    .HasConstraintName("UserPhoto");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("UserReligionId");

                entity.HasOne(d => d.Signature)
                    .WithMany(p => p.BasicDetailsSignature)
                    .HasForeignKey(d => d.SignatureId)
                    .HasConstraintName("BasicDetailsSignature");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("UserSponsorshipCompanyId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("UserStateId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("UserSupplierId");

                entity.HasOne(d => d.UserRoleCategory)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.UserRoleCategoryId)
                    .HasConstraintName("BasicDetailsUserRoleCategory");

                entity.HasOne(d => d.SalesExecutive)
                     .WithMany(p => p.BasicDetailsSalesExecutive)
                     .HasForeignKey(d => d.SalesExecutiveId)
                     .HasConstraintName("BasicDetailsSalesExecutive");

                entity.HasOne(d => d.OfficePhoto)
                    .WithMany(p => p.BasicDetailsOfficePhoto)
                    .HasForeignKey(d => d.OfficePhotoId)
                    .HasConstraintName("BasicDetailsOfficePhotoId");

                entity.HasOne(d => d.OutsideViewPhoto)
                    .WithMany(p => p.BasicDetailsOutsideViewPhoto)
                    .HasForeignKey(d => d.OutsideViewPhotoId)
                    .HasConstraintName("BasicDetailsOutsidePhotoId");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.BasicDetails)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("BasicDetailsComment");

            });

            modelBuilder.Entity<BloodGroup>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Group)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasIndex(e => e.CountryId)
                    .HasName("BranchDefaultCountry_idx");

                entity.HasIndex(e => e.CurrencyId)
                    .HasName("BranchDefaultCurrency_idx");

                entity.HasIndex(e => e.LogoId)
                    .HasName("LogoAttachment_id_idx");

                entity.HasIndex(e => e.OrganisationId)
                    .HasName("OrganisationBranches_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCodePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CrmCustomerPrefix)
               .HasMaxLength(45)
               .IsUnicode(false);

                entity.Property(e => e.CrmLeadPrefix)
               .HasMaxLength(45)
               .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CurrencyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Email)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LabourCodePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LogoId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OrganisationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectCodePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StaffCodePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SuppliedLabourCodePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCodePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("BranchDefaultCountry");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("BranchDefaultCurrency");

                entity.HasOne(d => d.Logo)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.LogoId)
                    .HasConstraintName("LogoAttachment_id");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.OrganisationId)
                    .HasConstraintName("OrganisationBranch");
            });

            modelBuilder.Entity<BranchDocument>(entity =>
            {
                entity.HasIndex(e => e.AttachmentId)
                    .HasName("BranchDocumentAttachment_idx");

                entity.HasIndex(e => e.BranchId)
                    .HasName("BranchDocumentBranch_idx");

                entity.HasIndex(e => e.DocumentTypeId)
                    .HasName("BranchDocumentDocumentType_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttachmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.BranchDocument)
                    .HasForeignKey(d => d.AttachmentId)
                    .HasConstraintName("BranchDocumentAttachment");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchDocument)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("BranchDocumentBranch");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.BranchDocument)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("BranchDocumentDocumentType");
            });

            modelBuilder.Entity<Camp>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned zerofill");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CampAllocation>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("CampAttendanceBranchId_idx");

                entity.HasIndex(e => e.CampId)
                    .HasName("CampAttendanceCamp_idx");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("CampAttendanceEmployee_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CampId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EmployeeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CampAllocation)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("CampAttendanceBranchId");

                entity.HasOne(d => d.Camp)
                    .WithMany(p => p.CampAllocation)
                    .HasForeignKey(d => d.CampId)
                    .HasConstraintName("CampAttendanceCamp");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CampAllocation)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("CampAttendanceEmployee");
            });

            modelBuilder.Entity<ClientInvoiceDesignation>(entity =>
            {
                entity.HasIndex(e => e.AccountUserInvoiceId)
                    .HasName("ClientInvoiceDesignationAccountUserInvoice_idx");

                entity.HasIndex(e => e.DesignationId)
                    .HasName("ClientInvoiceDesignationDesignation_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountUserInvoiceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.AccountUserInvoice)
                    .WithMany(p => p.ClientInvoiceDesignation)
                    .HasForeignKey(d => d.AccountUserInvoiceId)
                    .HasConstraintName("ClientInvoiceDesignationAccountUserInvoice");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.ClientInvoiceDesignation)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("ClientInvoiceDesignationDesignation");
            });

            modelBuilder.Entity<ClientInvoiceExpense>(entity =>
            {
                entity.HasIndex(e => e.AccountUserInvoiceId)
                    .HasName("ClientInvoiceExpenseAccountUserInvoice_idx");

                entity.HasIndex(e => e.ExpenseId)
                    .HasName("ClientInvoiceExpenseExpense_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountUserInvoiceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ExpenseId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.AccountUserInvoice)
                    .WithMany(p => p.ClientInvoiceExpense)
                    .HasForeignKey(d => d.AccountUserInvoiceId)
                    .HasConstraintName("ClientInvoiceExpenseAccountUserInvoice");

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.ClientInvoiceExpense)
                    .HasForeignKey(d => d.ExpenseId)
                    .HasConstraintName("ClientInvoiceExpenseExpense");
            });

            modelBuilder.Entity<ClientInvoiceProject>(entity =>
            {
                entity.HasIndex(e => e.AccountUserInvoiceId)
                    .HasName("ClientInvoiceProjectAccountUserInvoice_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectId)
                    .HasName("ClientInvoiceProjectProject_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountUserInvoiceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.AccountUserInvoice)
                    .WithMany(p => p.ClientInvoiceProject)
                    .HasForeignKey(d => d.AccountUserInvoiceId)
                    .HasConstraintName("ClientInvoiceProjectAccountUserInvoice");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ClientInvoiceProject)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("ClientInvoiceProjectProject");
            });

            modelBuilder.Entity<ClientInvoiceReference>(entity =>
            {
                entity.HasIndex(e => e.AccountUserInvoiceId)
                    .HasName("ClientInvoiceReferenceAccountUserInvoice_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ReferenceHeadId)
                    .HasName("ClientInvoiceReferenceInvoiceReferenceHead_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountUserInvoiceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ReferenceHeadId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountUserInvoice)
                    .WithMany(p => p.ClientInvoiceReference)
                    .HasForeignKey(d => d.AccountUserInvoiceId)
                    .HasConstraintName("ClientInvoiceReferenceAccountUserInvoice");

                entity.HasOne(d => d.ReferenceHead)
                    .WithMany(p => p.ClientInvoiceReference)
                    .HasForeignKey(d => d.ReferenceHeadId)
                    .HasConstraintName("ClientInvoiceReferenceInvoiceReferenceHead");
            });

            modelBuilder.Entity<ClientTimeSheet>(entity =>
            {
                entity.HasIndex(e => e.ApprovedById)
                    .HasName("ClientTimeSheetApprovedBy_idx");

                entity.HasIndex(e => e.CheckedById)
                    .HasName("ClientTimeSheetCheckedBy_idx");

                entity.HasIndex(e => e.ClientId)
                    .HasName("ClientTimeSheetClient_idx");

                entity.HasIndex(e => e.DocumentUploadId)
                    .HasName("ClientTimeSheetDocument_idx");

                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("ClientTimeSheetFinancialPeriod_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.PreparedById)
                    .HasName("ClientTimeSheetPreparedBy_idx");

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("ClientTimeSheetSponsorshipCompanyId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ApprovedById).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CheckedById).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ClientId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DocumentUploadId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsFinal)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsRawTimesheet).HasColumnType("bit(1)");

                entity.Property(e => e.Month).HasColumnType("int(11)");

                entity.Property(e => e.PreparedById).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.ApprovedBy)
                    .WithMany(p => p.ClientTimeSheetApprovedBy)
                    .HasForeignKey(d => d.ApprovedById)
                    .HasConstraintName("ClientTimeSheetApprovedBy");

                entity.HasOne(d => d.CheckedBy)
                    .WithMany(p => p.ClientTimeSheetCheckedBy)
                    .HasForeignKey(d => d.CheckedById)
                    .HasConstraintName("ClientTimeSheetCheckedBy");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientTimeSheetClient)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("ClientTimeSheetClient");

                entity.HasOne(d => d.DocumentUpload)
                    .WithMany(p => p.ClientTimeSheet)
                    .HasForeignKey(d => d.DocumentUploadId)
                    .HasConstraintName("ClientTimeSheetDocumentUpload");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.ClientTimeSheet)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("ClientTimeSheetFinancialPeriod");

                entity.HasOne(d => d.PreparedBy)
                    .WithMany(p => p.ClientTimeSheetPreparedBy)
                    .HasForeignKey(d => d.PreparedById)
                    .HasConstraintName("ClientTimeSheetPreparedBy");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.ClientTimeSheet)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("ClientTimeSheetSponsorshipCompany");
            });

            modelBuilder.Entity<ClientTimeSheetDesignation>(entity =>
            {
                entity.HasIndex(e => e.ClientTimeSheetId)
                    .HasName("ClientTimeSheetDesignationClientTimeSheet_idx");

                entity.HasIndex(e => e.DesignationId)
                    .HasName("ClientTimeSheetDesignationDesignation_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("idClientTimeSheetDesignation_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ClientTimeSheetId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.ClientTimeSheet)
                    .WithMany(p => p.ClientTimeSheetDesignation)
                    .HasForeignKey(d => d.ClientTimeSheetId)
                    .HasConstraintName("ClientTimeSheetDesignationClientTimeSheet");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.ClientTimeSheetDesignation)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("ClientTimeSheetDesignationDesignation");
            });

            modelBuilder.Entity<ClientTimeSheetEmployee>(entity =>
            {
                entity.HasIndex(e => e.AccountUserInvoiceId)
                    .HasName("ClientTimeSheetEmployeeAccountUserInvoice_idx");

                entity.HasIndex(e => e.ClientTimeSheetId)
                    .HasName("ClientTimeSheetEmployeeClientTimeSheet_idx");

                entity.HasIndex(e => e.DesignationId)
                    .HasName("ClientTimeSheetEmployeeDesignation_idx");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("ClientTimeSheetEmployeeEmployee_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("idClientTimeSheetEmployee_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectId)
                    .HasName("ClientTimeSheetEmployeeProject_idx");

                entity.HasIndex(e => e.ProjectRateId)
                    .HasName("ClientTimeSheetEmployeeProjectRate_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountUserInvoiceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ClientEmployeeId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClientTimeSheetId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DedAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.DedHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.DedRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EmployeeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HotAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.HotHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.HotRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IncAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IncHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.IncRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IsAbsent).HasColumnType("bit(1)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsHoliday).HasColumnType("bit(1)");

                entity.Property(e => e.IsInvoiceFinal)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsRawTimesheet).HasColumnType("bit(1)");

                entity.Property(e => e.IsTimeSheetFinal)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.NormalAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.NormalHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.NormalRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.NotAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.NotHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.NotRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.OrderNo).HasColumnType("bigint(20)");

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ProjectRateId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.AccountUserInvoice)
                    .WithMany(p => p.ClientTimeSheetEmployee)
                    .HasForeignKey(d => d.AccountUserInvoiceId)
                    .HasConstraintName("ClientTimeSheetEmployeeAccountUserInvoice");

                entity.HasOne(d => d.ClientTimeSheet)
                    .WithMany(p => p.ClientTimeSheetEmployee)
                    .HasForeignKey(d => d.ClientTimeSheetId)
                    .HasConstraintName("ClientTimeSheetEmployeeClientTimeSheet");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.ClientTimeSheetEmployee)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("ClientTimeSheetEmployeeDesignation");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ClientTimeSheetEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("ClientTimeSheetEmployeeEmployee");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ClientTimeSheetEmployee)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("ClientTimeSheetEmployeeProject");

                entity.HasOne(d => d.ProjectRate)
                    .WithMany(p => p.ClientTimeSheetEmployee)
                    .HasForeignKey(d => d.ProjectRateId)
                    .HasConstraintName("ClientTimeSheetEmployeeProjectRate");
            });

            modelBuilder.Entity<ClientTimeSheetProject>(entity =>
            {
                entity.HasIndex(e => e.ClientTimeSheetId)
                    .HasName("ClientTimeSheetProjectClientTimeSheet_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectId)
                    .HasName("ClientTimeSheetProjectProject_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ClientTimeSheetId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.ClientTimeSheet)
                    .WithMany(p => p.ClientTimeSheetProject)
                    .HasForeignKey(d => d.ClientTimeSheetId)
                    .HasConstraintName("ClientTimeSheetProjectClientTimeSheet");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ClientTimeSheetProject)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("ClientTimeSheetProjectProject");
            });

            modelBuilder.Entity<CodeGenerator>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("CodeGeneratorBranchId_idx");

                entity.HasIndex(e => e.CodeGeneratorModuleId)
                    .HasName("CodeGeneratorModuleId_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CodeGeneratorModuleId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LatestCode).HasColumnType("bigint(20)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CodeGenerator)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("CodeGeneratorBranchId");

                entity.HasOne(d => d.CodeGeneratorModule)
                    .WithMany(p => p.CodeGenerator)
                    .HasForeignKey(d => d.CodeGeneratorModuleId)
                    .HasConstraintName("CodeGeneratorModuleId");
            });

            modelBuilder.Entity<CodeGeneratorModule>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContractSalaryDetails>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("UserContractSalary_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Basic)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.GrossSalary)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Hra)
                    .HasColumnName("HRA")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.OtherAllowance)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.SpecialAllowance)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.TelephoneAllowance)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.TransportAllowance)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContractSalaryDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("UserContractSalary");
            });

            modelBuilder.Entity<CostCategory>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("CostCategorySponsorshipCompany_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.CostCategory)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("CostCategorySponsorshipCompany");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasIndex(e => e.CurrencyId)
                    .HasName("CountryCurrencyId_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryNameInArabic)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("CountryCurrencyId");
            });

            modelBuilder.Entity<CrmcompanyType>(entity =>
            {
                entity.ToTable("CRMCompanyType");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmcustomerSalesExecutiveHistory>(entity =>
            {
                entity.ToTable("CRMCustomerSalesExecutiveHistory");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("CRMCustomerSalesExecutiveHistoryCustomer_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SalesExecutiveId)
                    .HasName("CRMCustomerSalesExecutiveHistorySalesExecutieve_idx");

                entity.Property(e => e.Id).HasColumnType("bigint unsigned");

                entity.Property(e => e.CustomerId).HasColumnType("bigint unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.SalesExecutiveId).HasColumnType("bigint unsigned");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CrmcustomerSalesExecutiveHistoryCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("CRMCustomerSalesExecutiveHistoryCustomer");

                entity.HasOne(d => d.SalesExecutive)
                    .WithMany(p => p.CrmcustomerSalesExecutiveHistorySalesExecutive)
                    .HasForeignKey(d => d.SalesExecutiveId)
                    .HasConstraintName("CRMCustomerSalesExecutiveHistorySalesExecutieve");
            });

            modelBuilder.Entity<Crmlead>(entity =>
            {
                entity.ToTable("CRMLead");

                entity.HasIndex(e => e.AssignedSalesExecutiveId)
                    .HasName("CRMLeadAssignedUser_idx");

                entity.HasIndex(e => e.BranchId)
                    .HasName("CRMLeadBranch_idx");

                entity.HasIndex(e => e.ClientId)
                    .HasName("CRMLeadCompany_idx");  

                entity.HasIndex(e => e.CompanyLocationId)
                    .HasName("CRMLeadCompanyLocation_idx");

                entity.HasIndex(e => e.CompanyPhotoId)
                    .HasName("CRMLeadComanyLogo_idx");

                entity.HasIndex(e => e.OfficePhotoId)
                   .HasName("CRMLeadOfficePhoto_idx");

                entity.HasIndex(e => e.ProjectSitePhotoId)
                  .HasName("CRMLeadProjectSitePhoto_idx");

                entity.HasIndex(e => e.CompanyTypeId)
                    .HasName("CRMLeadcrmCompanytype_idx");

                entity.HasIndex(e => e.DesignationId)
                    .HasName("CRMLeadDesignation_idx");

                entity.HasIndex(e => e.EmiratesId)
                    .HasName("CRMLeadEmerates_idx");
                entity.HasIndex(e => e.WorkCategoryId)
                  .HasName("CRMLeadWorkCategory_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();
                entity.Property(e => e.IsClient).HasColumnType("bit(1)");
                entity.Property(e => e.IsFatown)
                    .HasColumnName("IsFATOwn")
                    .HasColumnType("bit(1)");
                entity.Property(e => e.Pbno)
                    .HasColumnName("PBNo")
                    .HasMaxLength(45)
                    .IsUnicode(false);
                entity.HasIndex(e => e.LeadStatusCommentId)
                    .HasName("CRMLeadComment_idx");

                entity.HasIndex(e => e.LeadStatusId)
                    .HasName("CRMLead_idx");

                entity.HasIndex(e => e.ProjectLocationId)
                    .HasName("CRMLeadProjectLocation_idx");

                entity.HasIndex(e => e.ProjectPhotoId)
                    .HasName("CRMLeadProjectPhoto_idx");

                entity.HasIndex(e => e.SourceId)
                    .HasName("CRMLeadLeadSlource_idx");

                entity.HasIndex(e => e.SponsorShipCompanyId)
                    .HasName("CRMLeadSponsorshipcompany_idx");

                entity.HasIndex(e => e.PhotoId)
                    .HasName("CRMLeadPhoto_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssignedSalesExecutiveId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ClientId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CompanyLocationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPhotoId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.WorkCategoryId).HasColumnType("bigint unsigned");

                entity.Property(e => e.CompanyTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmiratesId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OfficePhotoId).HasColumnType("bigint unsigned");

                entity.Property(e => e.ProjectSitePhotoId).HasColumnType("bigint unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.IsActive).HasColumnType("bit(1)");

                entity.Property(e => e.Longitude)
                   .HasMaxLength(200)
                   .IsUnicode(false);

                entity.Property(e => e.Latitude)
                   .HasMaxLength(200)
                   .IsUnicode(false);

                entity.Property(e => e.LeadNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LeadStatusCommentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LeadStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ProjectLocationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectPhotoId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SourceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SponsorShipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PhotoId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TelNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.WebSite)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.AssignedSalesExecutive)
                    .WithMany(p => p.CrmleadAssignedSalesExecutive)
                    .HasForeignKey(d => d.AssignedSalesExecutiveId)
                    .HasConstraintName("CRMLeadAssignedUser");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Crmlead)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("CRMLeadBranch");

                entity.HasOne(d => d.OfficePhoto)
                   .WithMany(p => p.CrmleadOfficePhoto)
                   .HasForeignKey(d => d.OfficePhotoId)
                   .HasConstraintName("CRMLeadOfficePhoto");

                entity.HasOne(d => d.ProjectSitePhoto)
                   .WithMany(p => p.CrmleadProjectSitePhoto)
                   .HasForeignKey(d => d.ProjectSitePhotoId)
                   .HasConstraintName("CRMLeadProjectSitePhoto");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CrmleadClient)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("CRMLeadCompany");

                entity.HasOne(d => d.CompanyLocation)
                    .WithMany(p => p.CrmleadCompanyLocation)
                    .HasForeignKey(d => d.CompanyLocationId)
                    .HasConstraintName("CRMLeadCompanyLocation");

                entity.HasOne(d => d.CompanyPhoto)
                    .WithMany(p => p.CrmleadCompanyPhoto)
                    .HasForeignKey(d => d.CompanyPhotoId)
                    .HasConstraintName("CRMLeadComanyLogo");

                entity.HasOne(d => d.CompanyType)
                    .WithMany(p => p.Crmlead)
                    .HasForeignKey(d => d.CompanyTypeId)
                    .HasConstraintName("CRMLeadcrmCompanytype");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.Crmlead)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("CRMLeadDesignation");

                entity.HasOne(d => d.Emirates)
                    .WithMany(p => p.Crmlead)
                    .HasForeignKey(d => d.EmiratesId)
                    .HasConstraintName("CRMLeadEmerates");

                entity.HasOne(d => d.LeadStatusComment)
                    .WithMany(p => p.Crmlead)
                    .HasForeignKey(d => d.LeadStatusCommentId)
                    .HasConstraintName("CRMLeadComment");

                entity.HasOne(d => d.LeadStatus)
                    .WithMany(p => p.Crmlead)
                    .HasForeignKey(d => d.LeadStatusId)
                    .HasConstraintName("CRMLead");

                entity.HasOne(d => d.WorkCategory)
                    .WithMany(p => p.Crmlead)
                    .HasForeignKey(d => d.WorkCategoryId)
                    .HasConstraintName("CRMLeadWorkCategory");

                entity.HasOne(d => d.ProjectLocation)
                    .WithMany(p => p.CrmleadProjectLocation)
                    .HasForeignKey(d => d.ProjectLocationId)
                    .HasConstraintName("CRMLeadProjectLocation");

                entity.HasOne(d => d.ProjectPhoto)
                    .WithMany(p => p.CrmleadProjectPhoto)
                    .HasForeignKey(d => d.ProjectPhotoId)
                    .HasConstraintName("CRMLeadProjectPhoto");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.Crmlead)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("CRMLeadLeadSlource");

                entity.HasOne(d => d.SponsorShipCompany)
                    .WithMany(p => p.Crmlead)
                    .HasForeignKey(d => d.SponsorShipCompanyId)
                    .HasConstraintName("CRMLeadSponsorshipcompany");

                entity.HasOne(d => d.Photo)
                   .WithMany(p => p.CrmLeadPhoto)
                   .HasForeignKey(d => d.PhotoId)
                   .HasConstraintName("CRMLeadPhoto");
            });

            modelBuilder.Entity<CrmleadComments>(entity =>
            {
                entity.ToTable("CRMLeadComments");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Comment)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");
            });

            modelBuilder.Entity<CrmleadDetails>(entity =>
            {
                entity.ToTable("CRMLeadDetails");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.LeadId)
                    .HasName("CRMLeadDetailsLead_idx");

                entity.HasIndex(e => e.TradeId)
                    .HasName("CRMLeadDetailsTrade_idx");

                entity.HasIndex(e => e.FATId)
                  .HasName("CRMLeadDetailsFAT_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");


                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.FATId).HasColumnType("bigint unsigned");


                entity.Property(e => e.LeadId).HasColumnType("bigint(20) unsigned");
                entity.Property(e => e.TypeId).HasColumnType("bigint(20) unsigned");
                entity.Property(e => e.IsClient).HasColumnType("bit(1)");
                entity.Property(e => e.IsFatown)
                    .HasColumnName("IsFATOwn")
                    .HasColumnType("bit(1)");
                entity.Property(e => e.Pbno)
                    .HasColumnName("PBNo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Rate).HasColumnType("decimal(10,2)");

                entity.Property(e => e.TradeId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.FAT)
                   .WithMany(p => p.crmFAT)
                   .HasForeignKey(d => d.FATId)
                   .HasConstraintName("CRMLeadDetailsFAT");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.CrmleadDetails)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("CRMLeadDetailsLead");

                entity.HasOne(d => d.Trade)
                    .WithMany(p => p.CrmleadDetails)
                    .HasForeignKey(d => d.TradeId)
                    .HasConstraintName("CRMLeadDetailsTrade");
            });

            modelBuilder.Entity<CrmleadReference>(entity =>
            {
                entity.ToTable("CRMleadreference");

                entity.HasIndex(e => e.CrmleadId)
                    .HasName("CRMLeadRefrence_idx");

                entity.HasIndex(e => e.CustomerReferenceId)
                    .HasName("CRMleadreferenceCustomerReference_idx");

                entity.HasIndex(e => e.DesignationId)
                    .HasName("CRMLeadRefrenceDesignation_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();


                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CrmleadId).HasColumnType("bigint(20) unsigned");
				
                entity.Property(e => e.CustomerReferenceId).HasColumnType("bigint unsigned");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.CrmleadReference)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("CRMLeadReferenceDesignation");

                entity.HasOne(d => d.Crmlead)
                    .WithMany(p => p.CrmleadReference)
                    .HasForeignKey(d => d.CrmleadId)
                    .HasConstraintName("CRMLeadReference");
				
				entity.HasOne(d => d.CustomerReference)
                    .WithMany(p => p.Crmleadreference)
                    .HasForeignKey(d => d.CustomerReferenceId)
                    .HasConstraintName("CRMleadreferenceCustomerReference");

            });

            modelBuilder.Entity<CrmleadSource>(entity =>
            {
                entity.ToTable("CRMLeadSource");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();
				
				entity.HasIndex(e => e.LeadCatogory)
                    .HasName("CRMLeadSourceLeadCatogory_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.LeadCatogory).HasColumnType("bigint unsigned");

                entity.Property(e => e.Source)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmleadStatus>(entity =>
            {
                entity.ToTable("CRMLeadStatus");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.Status)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CrmType)
                 .HasMaxLength(45)
                 .IsUnicode(false);
            });

            modelBuilder.Entity<Crmopportunity>(entity =>
            {
                entity.ToTable("CRMOpportunity");

                entity.HasIndex(e => e.AccountId)
                      .HasName("CRMOpportunityAccount_idx");

                entity.HasIndex(e => e.SponsorShipCompanyId)
                      .HasName("CRMOpportunitySponsorshipCompany_idx");
                
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.LeadId)
                    .HasName("CRMOpportunityLead_idx");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("CRMOpportunityOwner_idx");

                entity.HasIndex(e => e.StatusId)
                    .HasName("CRMOpportunityStatus_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");
                entity.Property(e => e.SponsorShipCompanyId).HasColumnType("bigint(20) unsigned");
                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.LeadId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OpportunityNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);
                entity.Property(e => e.OpportunityName)
              .HasMaxLength(100)
              .IsUnicode(false);


                entity.Property(e => e.OwnerId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.StatusId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.Crmopportunity)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("CRMOpportunityLead");

                entity.HasOne(d => d.Account)
                                 .WithMany(p => p.CrmopportunityAccount)
                                 .HasForeignKey(d => d.AccountId)
                                 .HasConstraintName("CRMOpportunityAccount");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.CrmopportunityOwner)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("CRMOpportunityOwner");

                entity.HasOne(d => d.SponsorShipCompany)
                   .WithMany(p => p.crmOpportunitySponsorshipCompany)
                   .HasForeignKey(d => d.SponsorShipCompanyId)
                   .HasConstraintName("CRMOpportunitySponsorshipCompany");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Crmopportunity)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("CRMOpportunityStatus");
            });

            modelBuilder.Entity<CrmopportunityDetail>(entity =>
            {
                entity.ToTable("CRMOpportunityDetail");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.LeadDetailId)
                    .HasName("CRMOpportunityDetailLeadDetail_idx");

                entity.HasIndex(e => e.OpportunityId)
                    .HasName("CRMOpportunityDetailOpportunity_idx");

                entity.HasIndex(e => e.TradeId)
                    .HasName("CRMOpportunityDetailTrade_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.LeadDetailId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OpportunityId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Rate).HasColumnType("decimal(10,2)");

                entity.Property(e => e.TradeId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.LeadDetail)
                    .WithMany(p => p.CrmopportunityDetail)
                    .HasForeignKey(d => d.LeadDetailId)
                    .HasConstraintName("CRMOpportunityDetailLeadDetail");

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.CrmopportunityDetail)
                    .HasForeignKey(d => d.OpportunityId)
                    .HasConstraintName("CRMOpportunityDetailOpportunity");

                entity.HasOne(d => d.Trade)
                    .WithMany(p => p.CrmopportunityDetail)
                    .HasForeignKey(d => d.TradeId)
                    .HasConstraintName("CRMOpportunityDetailTrade");
            });

            modelBuilder.Entity<Crmpriority>(entity =>
            {
                entity.ToTable("CRMPriority");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.Priority)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Crmpurpose>(entity =>
            {
                entity.ToTable("CRMPurpose");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

          
            modelBuilder.Entity<WorkCategory>(entity =>
            {
                entity.ToTable("CRMWorkCategory");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint unsigned");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });




            modelBuilder.Entity<CrmquotationTerms>(entity =>
            {
                entity.ToTable("CRMQuotationTerms");

                entity.HasIndex(e => e.BranchId)
                    .HasName("BranchId_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Terms)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CrmquotationTerms)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("BranchId");
            });

            modelBuilder.Entity<Crmtask>(entity =>
            {
                entity.ToTable("CRMTask");

                entity.HasIndex(e => e.ClientId)
                    .HasName("CRMTaskClient_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.LeadId)
                    .HasName("CRMTaskLead_idx");

                entity.HasIndex(e => e.PriorityId)
                    .HasName("CRMTaskPriority_idx");

                entity.HasIndex(e => e.PurposeId)
                    .HasName("CRMTaskPurpose_idx");

                entity.HasIndex(e => e.TaskOwnerId)
                    .HasName("CRMTaskOwner_idx");

                entity.HasIndex(e => e.TaskTypeId)
                    .HasName("CRMTaskTaskType_idx");
                entity.HasIndex(e => e.TaskAssignedBy)
                   .HasName("CRMTaskTaskAssignedBy");

                entity.HasIndex(e => e.TaskAssignedTo)
                    .HasName("CRMTaskTaskAssignedTo");



                entity.Property(e => e.TaskAssignedBy).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");
                entity.Property(e => e.SponsorShipCompanyId).HasColumnType("bigint(20) unsigned");


                entity.Property(e => e.TaskAssignedTo).HasColumnType("bigint(20) unsigned");


                entity.HasOne(d => d.TaskAssignedByNavigation)
                  .WithMany(p => p.CrmtaskTaskAssignedByNavigation)
                  .HasForeignKey(d => d.TaskAssignedBy)
                  .HasConstraintName("CRMTaskTaskAssignedBy");

                entity.HasOne(d => d.TaskAssignedToNavigation)
                    .WithMany(p => p.CrmtaskTaskAssignedToNavigation)
                    .HasForeignKey(d => d.TaskAssignedTo)
                    .HasConstraintName("CRMTaskTaskAssignedTo");

                entity.Property(e => e.StatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CaseId)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.HasOne(d => d.Status)
                   .WithMany(p => p.Crmtask)
                   .HasForeignKey(d => d.StatusId)
                   .HasConstraintName("CRMTaskStatusId");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ClientId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.LeadId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PriorityId).HasColumnType("bigint(20) unsigned");
                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");
                entity.Property(e => e.OpportunityId).HasColumnType("bigint(20) unsigned");
                entity.Property(e => e.TaskOnId).HasColumnType("int(11)");


                entity.Property(e => e.PurposeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TaskOwnerId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TaskTypeId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CrmtaskClient)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("CRMTaskClient");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.Crmtask)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("CRMTaskLead");

                entity.HasOne(d => d.Priority)
                    .WithMany(p => p.Crmtask)
                    .HasForeignKey(d => d.PriorityId)
                    .HasConstraintName("CRMTaskPriority");

                entity.HasOne(d => d.Purpose)
                    .WithMany(p => p.Crmtask)
                    .HasForeignKey(d => d.PurposeId)
                    .HasConstraintName("CRMTaskPurpose");

                entity.HasOne(d => d.TaskOwner)
                    .WithMany(p => p.CrmtaskTaskOwner)
                    .HasForeignKey(d => d.TaskOwnerId)
                    .HasConstraintName("CRMTaskOwner");

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.Crmtask)
                    .HasForeignKey(d => d.TaskTypeId)
                    .HasConstraintName("CRMTaskTaskType");
            });

            modelBuilder.Entity<CrmopportunityTerms>(entity =>
            {
                entity.ToTable("CRMOpportunityTerms");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.OpportunityId)
                    .HasName("ForeignKey_OpportunityId_idx");

                entity.Property(e => e.OpportunityId).HasColumnType("bigint unsigned");

                entity.Property(e => e.Terms)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.CrmopportunityTerms)
                    .HasForeignKey(d => d.OpportunityId)
                    .HasConstraintName("ForeignKey_OpportunityId");
            });

            modelBuilder.Entity<CrmtaskDetail>(entity =>
            {
                entity.ToTable("CRMTaskDetail");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.PhotoId)
                    .HasName("CRMTaskDetailPhoto_idx");

                entity.HasIndex(e => e.TaskTypeId)
                   .HasName("CRMTaskDetailTaskType_idx");

                entity.HasIndex(e => e.TaskId)
                    .HasName("CRMTaskDetailTask_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.TaskDescription)
             .HasMaxLength(200)
             .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.TaskTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PhotoId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.StatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TaskId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.CrmtaskDetail)
                    .HasForeignKey(d => d.PhotoId)
                    .HasConstraintName("CRMTaskDetailPhoto");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.CrmtaskDetail)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("CRMTaskDetailTask");

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.CrmtaskDetail)
                    .HasForeignKey(d => d.TaskTypeId)
                    .HasConstraintName("CRMTaskDetailTaskType");

                entity.Property(e => e.ContactName)
                   .HasMaxLength(150)
                   .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EMail)
                    .HasColumnName("EMail")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Status)
             .WithMany(p => p.CrmtaskDetail)
             .HasForeignKey(d => d.StatusId)
             .HasConstraintName("CRMTaskDetailStatusId");
            });

            modelBuilder.Entity<CrmtaskDocument>(entity =>
            {
                entity.ToTable("CRMTaskDocument");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.TaskId)
                    .HasName("CRMTaskDocumentTask_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");
                entity.Property(e => e.AttachmentId).HasColumnType("bigint(20) unsigned");


                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.TaskId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.CrmtaskDocument)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("CRMTaskDocumentTask");
            });

            modelBuilder.Entity<CrmtaskType>(entity =>
            {
                entity.ToTable("CRMTaskType");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.Type)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Rate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerEvaluation>(entity =>
            {
                entity.HasIndex(e => e.CustomerId)
                    .HasName("CustomerEvaluationCustomer_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint unsigned");

                entity.Property(e => e.CustomerId).HasColumnType("bigint unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerEvaluation)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("CustomerEvaluationCustomer");
            });

            modelBuilder.Entity<CustomerEvaluationAnswer>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.QuestionId)
                    .HasName("CustomerEvaluationAnswerQuestion_idx");

                entity.Property(e => e.Id).HasColumnType("bigint unsigned");

                entity.Property(e => e.Answer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.QuestionId).HasColumnType("bigint unsigned");

                entity.Property(e => e.Score)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.CustomerEvaluationAnswer)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("CustomerEvaluationAnswerQuestion");
            });

            modelBuilder.Entity<CustomerEvaluationDetails>(entity =>
            {
                entity.HasIndex(e => e.AnswerId)
                    .HasName("CustomerEvaluationDetailsAnswer_idx");

                entity.HasIndex(e => e.CustomerEvaluationId)
                    .HasName("CustomerEvaluationDetailsCustomerEvaluation_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.QuestionId)
                    .HasName("CustomerEvaluationDetailsQuestion_idx");

                entity.Property(e => e.Id).HasColumnType("bigint unsigned");

                entity.Property(e => e.AnswerId).HasColumnType("bigint unsigned");

                entity.Property(e => e.CustomerEvaluationId).HasColumnType("bigint unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.QuestionId).HasColumnType("bigint unsigned");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.CustomerEvaluationDetails)
                    .HasForeignKey(d => d.AnswerId)
                    .HasConstraintName("CustomerEvaluationDetailsAnswer");

                entity.HasOne(d => d.CustomerEvaluation)
                    .WithMany(p => p.CustomerEvaluationDetails)
                    .HasForeignKey(d => d.CustomerEvaluationId)
                    .HasConstraintName("CustomerEvaluationDetailsCustomerEvaluation");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.CustomerEvaluationDetails)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("CustomerEvaluationDetailsQuestion");
            });

            modelBuilder.Entity<CustomerEvaluationQuestionnaire>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Question)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeMobilizeReason>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DemandRequest>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("DemandRequestClient_idx");

                entity.HasIndex(e => e.FatId)
                    .HasName("DemandRequestAccomadationType_idx");

                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("DemandRequestFinancialPeriod_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectId)
                    .HasName("DemandRequestProjrct_idx");

                entity.HasIndex(e => e.RequestActionId)
                    .HasName("DemandRequestRequestAction_idx");

                entity.HasIndex(e => e.RequestReasonId)
                    .HasName("DemandRequestRequestReason_idx");

                entity.HasIndex(e => e.RequestStatusId)
                    .HasName("DemandRequestRequestStatus_idx");

                entity.HasIndex(e => e.RequestTypeId)
                    .HasName("DemandRequestRequestType_idx");

                entity.HasIndex(e => e.RequestedById)
                    .HasName("DemandRequestRequestedBy_idx");

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("DemandRequestSponsorshipCompany_idx");

                entity.HasIndex(e => e.TransportationStatusId)
                    .HasName("DemandRequestTransportation_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ClientId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DemandQuantity).HasColumnType("int(11)");

                entity.Property(e => e.FatId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsAllocated)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsOperationApproved)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Rate).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestActionId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RequestNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RequestReasonId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RequestStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RequestTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RequestedById).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TransportationStatusId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DemandRequestClient)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("DemandRequestClient");

                entity.HasOne(d => d.Fat)
                    .WithMany(p => p.DemandRequestFat)
                    .HasForeignKey(d => d.FatId)
                    .HasConstraintName("DemandRequestAccomadation");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.DemandRequest)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("DemandRequestFinancialPeriod");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.DemandRequest)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("DemandRequestProjrct");

                entity.HasOne(d => d.RequestAction)
                    .WithMany(p => p.DemandRequest)
                    .HasForeignKey(d => d.RequestActionId)
                    .HasConstraintName("DemandRequestRequestAction");

                entity.HasOne(d => d.RequestReason)
                    .WithMany(p => p.DemandRequest)
                    .HasForeignKey(d => d.RequestReasonId)
                    .HasConstraintName("DemandRequestRequestReason");

                entity.HasOne(d => d.RequestStatus)
                    .WithMany(p => p.DemandRequest)
                    .HasForeignKey(d => d.RequestStatusId)
                    .HasConstraintName("DemandRequestRequestStatus");

                entity.HasOne(d => d.RequestType)
                    .WithMany(p => p.DemandRequest)
                    .HasForeignKey(d => d.RequestTypeId)
                    .HasConstraintName("DemandRequestRequestType");

                entity.HasOne(d => d.RequestedBy)
                    .WithMany(p => p.DemandRequestRequestedBy)
                    .HasForeignKey(d => d.RequestedById)
                    .HasConstraintName("DemandRequestRequestedBy");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.DemandRequest)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("DemandRequestSponsorshipCompany");

                entity.HasOne(d => d.TransportationStatus)
                    .WithMany(p => p.DemandRequestTransportationStatus)
                    .HasForeignKey(d => d.TransportationStatusId)
                    .HasConstraintName("DemandRequestTransportation");
            });

            modelBuilder.Entity<DemandRequestAction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DemandRequestAllocation>(entity =>
            {
                entity.HasIndex(e => e.DemandRequestId)
                    .HasName("DemandRequestAllocationDEmandRequest_idx");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("DemandRequestAllocationEmployee_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.TradeChangeAsId)
                    .HasName("DemandRequestAllocationTradeChangeAs_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DemandRequestId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EmployeeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsAllocated)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.TradeChangeAsId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.DemandRequest)
                    .WithMany(p => p.DemandRequestAllocation)
                    .HasForeignKey(d => d.DemandRequestId)
                    .HasConstraintName("DemandRequestAllocationDEmandRequest");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.DemandRequestAllocation)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("DemandRequestAllocationEmployee");

                entity.HasOne(d => d.TradeChangeAs)
                    .WithMany(p => p.DemandRequestAllocation)
                    .HasForeignKey(d => d.TradeChangeAsId)
                    .HasConstraintName("DemandRequestAllocationTradeChangeAs");
            });

            modelBuilder.Entity<DemandRequestReason>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DemandRequestStatus>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DemandRequestTrades>(entity =>
            {
                entity.HasIndex(e => e.DemandRequestId)
                    .HasName("DemandRequestTradesDemandRequest_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.TradeId)
                    .HasName("DemandRequestTradesDesignation_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DemandRequestId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.TradeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TypeOfWork)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.DemandRequest)
                    .WithMany(p => p.DemandRequestTrades)
                    .HasForeignKey(d => d.DemandRequestId)
                    .HasConstraintName("DemandRequestTradesDemandRequest");

                entity.HasOne(d => d.Trade)
                    .WithMany(p => p.DemandRequestTrades)
                    .HasForeignKey(d => d.TradeId)
                    .HasConstraintName("DemandRequestTradesDesignation");
            });

            modelBuilder.Entity<DemandRequestType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DepartmentHeadId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Cost)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsLaboursTrade)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsSales)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsStaffsTrade)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsVisasTrade)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.NameInArabic)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasIndex(e => e.CountryId)
                    .HasName("CountryRelation_idx");

                entity.HasIndex(e => e.StateId)
                    .HasName("DistrictStateId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CountryId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StateId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("CountryRelation");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("DistrictStateId");
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.NotificationDays).HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Eidstatus>(entity =>
            {
                entity.ToTable("EIDStatus");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Eidstatus1)
                    .HasColumnName("EIDStatus")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");
            });

            modelBuilder.Entity<Emirate>(entity =>
            {
                entity.HasIndex(e => e.CountryId)
                    .HasName("EmirateCountry_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CountryId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ExtensionCode)
                .HasMaxLength(10)
                .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Emirate)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("EmirateCountry");
            });

            modelBuilder.Entity<FileMigrationInserted>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("bit(1)");
            });

            modelBuilder.Entity<FinancialPeriod>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.IsCurrentPeriod)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ToDate).HasColumnType("date");
            });

            modelBuilder.Entity<GradeType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.RoleId)
                    .HasName("GradeRoleId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.GradeType)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("GradeRoleId");
            });

            modelBuilder.Entity<HeadDepartment>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("HeadDepartmentBranch_idx");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("HeadDepartmentDep_idx");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("HeadDepartmentEmployee_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DepartmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EmployeeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.HeadDepartment)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("HeadDepartmentBranch");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.HeadDepartment)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("HeadDepartmentDep");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.HeadDepartment)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("HeadDepartmentEmployee");
            });

            modelBuilder.Entity<HoliDay>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsRecurring)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.NoDays).HasColumnType("int(11)");

                entity.Property(e => e.Period)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.WeekNumber).HasColumnType("int(11)");
            });

            modelBuilder.Entity<HolidayType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InactiveReason>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceCardType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.InsuranceCardType1)
                    .HasColumnName("InsuranceCardType")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");
            });

            modelBuilder.Entity<InvoiceExpenseType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceReferenceHeadType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobDetails>(entity =>
            {
                entity.HasIndex(e => e.DepartmentId)
                    .HasName("JobDetailsDepartmentId_idx");

                entity.HasIndex(e => e.DesignationId)
                    .HasName("JobDetailsDesignationId_idx");

                entity.HasIndex(e => e.GradeId)
                    .HasName("JobDetailsGradeId_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.LineManagerId)
                    .HasName("LineMangerId_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("JobDetailsUserId_idx");

                entity.HasIndex(e => e.WorkLocationId)
                    .HasName("JobDetailsOfficeLocationId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DepartmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.GradeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LineManagerId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.WorkLocationId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.JobDetails)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("JobDetailsDepartmentId");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.JobDetails)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("JobDetailsDesignationId");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.JobDetails)
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("JobDetailsGradeId");

                entity.HasOne(d => d.LineManager)
                    .WithMany(p => p.JobDetailsLineManager)
                    .HasForeignKey(d => d.LineManagerId)
                    .HasConstraintName("LineMangerId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobDetailsUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("JobDetailsId");

                entity.HasOne(d => d.WorkLocation)
                    .WithMany(p => p.JobDetails)
                    .HasForeignKey(d => d.WorkLocationId)
                    .HasConstraintName("JobDetailsOfficeLocationId");
            });

            modelBuilder.Entity<KnownTrade>(entity =>
            {
                entity.HasIndex(e => e.DesignationId)
                    .HasName("KnownTradeDesignationId_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("KnownTradeUserId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.PerPercentageKnown)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("decimal(10,2) unsigned");

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.KnownTrade)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("KnownTradeDesignationId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.KnownTrade)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("KnownTradeUserId");
            });

            modelBuilder.Entity<LabourTimeCard>(entity =>
            {
                entity.HasIndex(e => e.DesignationId)
                    .HasName("LabourTimeCardDesignation_idx");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("LabourTimeCardEmployee_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.LabourTimeCardHeaderId)
                    .HasName("LabourTimeCardLabourTimeCardHeader_idx");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("LabourTimeCardProject_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DedAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.DedHrs)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.DedRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EmployeeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HotAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.HotHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.HotRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IncAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IncHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.IncRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IsAbsent)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsHoliday)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LabourTimeCardHeaderId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.NormalAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.NormalHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.NormalRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.NotAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.NotHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.NotRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.LabourTimeCard)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("LabourTimeCardDesignation");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LabourTimeCard)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("LabourTimeCardEmployee");

                entity.HasOne(d => d.LabourTimeCardHeader)
                    .WithMany(p => p.LabourTimeCard)
                    .HasForeignKey(d => d.LabourTimeCardHeaderId)
                    .HasConstraintName("LabourTimeCardLabourTimeCardHeader");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.LabourTimeCard)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("LabourTimeCardProject");
            });

            modelBuilder.Entity<LabourTimeCardHeader>(entity =>
            {
                entity.HasIndex(e => e.EmployeeId)
                    .HasName("LabourTimeCardHeaderEmployee_idx");

                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("LabourTimeCardHeaderFinancialPeriodId_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AbsentFine).HasColumnType("decimal(10,2)");

                entity.Property(e => e.AdvanceAllowance).HasColumnType("decimal(10,2)");

                entity.Property(e => e.AdvanceDeduction).HasColumnType("decimal(10,2)");

                entity.Property(e => e.AdvancePayAllowance).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Basic).HasColumnType("decimal(10,2)");

                entity.Property(e => e.CalenderDays).HasColumnType("int(11)");

                entity.Property(e => e.CasualLeave).HasColumnType("decimal(10,2)");

                entity.Property(e => e.DeductionAmt).HasColumnType("decimal(10,2)");

                entity.Property(e => e.DeductionHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.EmployeeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ExtraAllowance).HasColumnType("decimal(10,2)");

                entity.Property(e => e.ExtraPayAllowance).HasColumnType("decimal(10,2)");

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Fine).HasColumnType("decimal(10,2)");

                entity.Property(e => e.HotHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.HotSalary).HasColumnType("decimal(10,2)");

                entity.Property(e => e.IdCard).HasColumnType("decimal(10,2)");

                entity.Property(e => e.IncentiveAllowance).HasColumnType("decimal(10,2)");

                entity.Property(e => e.IncentiveAmt).HasColumnType("decimal(10,2)");

                entity.Property(e => e.IncentiveHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.IncentivePayAllowance).HasColumnType("decimal(10,2)");

                entity.Property(e => e.IsBlockSalary).HasColumnType("bit(1)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsFinalize).HasColumnType("bit(1)");

                entity.Property(e => e.LateComing).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Lwp)
                    .HasColumnName("LWP")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.MedicalLeave).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Month).HasColumnType("int(11)");

                entity.Property(e => e.NetSalary).HasColumnType("decimal(10,2)");

                entity.Property(e => e.NonWps).HasColumnType("decimal(10,2)");

                entity.Property(e => e.NormalHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.NormalSalary).HasColumnType("decimal(10,2)");

                entity.Property(e => e.NotHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.NotSalary).HasColumnType("decimal(10,2)");

                entity.Property(e => e.OtherDeduction).HasColumnType("decimal(10,2)");

                entity.Property(e => e.PaidDays).HasColumnType("decimal(10,2)");

                entity.Property(e => e.PaidLeave).HasColumnType("decimal(10,2)");

                entity.Property(e => e.PreviousMonthAllowance).HasColumnType("decimal(10,2)");

                entity.Property(e => e.PreviousMonthPayAllowance).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryBalance).HasColumnType("decimal(10,2)");

                entity.Property(e => e.TotalHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.TotalSalary).HasColumnType("decimal(10,2)");

                entity.Property(e => e.TotalWorked).HasColumnType("decimal(10,2)");

                entity.Property(e => e.VisaDeduction).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Wps)
                    .HasColumnName("WPS")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.WpsChargeDeduction).HasColumnType("decimal(10,2)");

                entity.Property(e => e.WpsExtra).HasColumnType("decimal(10,2)");

                entity.Property(e => e.WrongDeductionAllowance).HasColumnType("decimal(10,2)");

                entity.Property(e => e.WrongDeductionPayAllowance).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Year).HasColumnType("int(11)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LabourTimeCardHeader)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("LabourTimeCardHeaderEmployee");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.LabourTimeCardHeader)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("LabourTimeCardHeaderFinancialPeriodId");
            });

			 modelBuilder.Entity<LeadComments>(entity =>
            {
                entity.HasIndex(e => e.CommentId)
                    .HasName("LeadCommentsComment_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.LeadId)
                    .HasName("LeadCommentsLead_idx");

                entity.Property(e => e.Id).HasColumnType("bigint unsigned");

                entity.Property(e => e.CommentId).HasColumnType("bigint unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LeadId).HasColumnType("bigint unsigned");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.LeadComments)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("LeadCommentsComment");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadComments)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("LeadCommentsLead");
            });

            modelBuilder.Entity<LicenceType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LicenceType1)
                    .HasColumnName("LicenceType")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LineManager>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MedicalDetails>(entity =>
            {
                entity.HasIndex(e => e.EidstatusId)
                    .HasName("MedicalEIDStatusId_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.MedicalAttachmentId)
                    .HasName("MedicalImageAttachment_idx");

                entity.HasIndex(e => e.MedicalStatusId)
                    .HasName("MedicalStatus_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("MedicalUser_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EidstatusId)
                    .HasColumnName("EIDStatusId")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.MedicalAttachmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MedicalFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Eidstatus)
                    .WithMany(p => p.MedicalDetails)
                    .HasForeignKey(d => d.EidstatusId)
                    .HasConstraintName("MedicalEIDStatusId");

                entity.HasOne(d => d.MedicalAttachment)
                    .WithMany(p => p.MedicalDetails)
                    .HasForeignKey(d => d.MedicalAttachmentId)
                    .HasConstraintName("MedicalAttachmentId");

                entity.HasOne(d => d.MedicalStatus)
                    .WithMany(p => p.MedicalDetails)
                    .HasForeignKey(d => d.MedicalStatusId)
                    .HasConstraintName("MedicalStatus");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MedicalDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("MedicalUser");
            });

            modelBuilder.Entity<MedicalStatus>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Status)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ParantId)
                    .HasName("ModuleParent_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ParantId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SubMenuId).HasColumnType("bigint(20)");

                entity.HasOne(d => d.Parant)
                    .WithMany(p => p.InverseParant)
                    .HasForeignKey(d => d.ParantId)
                    .HasConstraintName("ModuleParent");
            });

            modelBuilder.Entity<NocAccomadationStatus>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Type)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NocDeMobilizeStatus>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NocDetails>(entity =>
            {
                entity.HasIndex(e => e.AssistanceId)
                    .HasName("NocDetailsAssistance_idx");

                entity.HasIndex(e => e.ClientId)
                    .HasName("NocDetailsClient_idx");

                entity.HasIndex(e => e.DemandRequestId)
                    .HasName("NocDetailsDemandRequest_idx");

                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("NocDetailsFinancialPerios_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.NocStatusId)
                    .HasName("NocDetailsNocStatus_idx");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("NocDetailsProject_idx");

                entity.HasIndex(e => e.RegardsId)
                    .HasName("NocDetailsRegards_idx");

                entity.HasIndex(e => e.ReportTypeId)
                    .HasName("NocDetailsReportType_idx");

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("NocDetailsSponsorshipCompany_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssistanceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CertificateDownload).HasColumnType("bit(1)");

                entity.Property(e => e.ClientId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DemandRequestId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.EmiratesIdDownload).HasColumnType("bit(1)");

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.GatePassDownload).HasColumnType("bit(1)");

                entity.Property(e => e.InsuranceDownload).HasColumnType("bit(1)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsReplacement).HasColumnType("bit(1)");

                entity.Property(e => e.MoblieNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NocStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PassportDownload).HasColumnType("bit(1)");

                entity.Property(e => e.PhotoDownload).HasColumnType("bit(1)");

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RegardsId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.ReportTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SupplierUnderTakingDownload).HasColumnType("bit(1)");

                entity.Property(e => e.TradeLicenceDownload).HasColumnType("bit(1)");

                entity.Property(e => e.VisaDownload).HasColumnType("bit(1)");

                entity.Property(e => e.WorkCompensationDownload).HasColumnType("bit(1)");

                entity.HasOne(d => d.Assistance)
                    .WithMany(p => p.NocDetailsAssistance)
                    .HasForeignKey(d => d.AssistanceId)
                    .HasConstraintName("NocDetailsAssistance");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.NocDetailsClient)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("NocDetailsClient");

                entity.HasOne(d => d.DemandRequest)
                    .WithMany(p => p.NocDetails)
                    .HasForeignKey(d => d.DemandRequestId)
                    .HasConstraintName("NocDetailsDemandRequest");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.NocDetails)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("NocDetailsFinancialPeriod");

                entity.HasOne(d => d.NocStatus)
                    .WithMany(p => p.NocDetails)
                    .HasForeignKey(d => d.NocStatusId)
                    .HasConstraintName("NocDetailsNocStatus");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.NocDetails)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("NocDetailsProject");

                entity.HasOne(d => d.Regards)
                    .WithMany(p => p.NocDetailsRegards)
                    .HasForeignKey(d => d.RegardsId)
                    .HasConstraintName("NocDetailsRegards");

                entity.HasOne(d => d.ReportType)
                    .WithMany(p => p.NocDetails)
                    .HasForeignKey(d => d.ReportTypeId)
                    .HasConstraintName("NocDetailsReportType");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.NocDetails)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("NocDetailsSponsorshipCompany");
            });

            modelBuilder.Entity<NocEmployeeDetails>(entity =>
            {
                entity.HasIndex(e => e.AccomadationStatusId)
                    .HasName("NocEmployeeDetailsAccomadation_idx");

                entity.HasIndex(e => e.DeMobilizeReasonId)
                    .HasName("NocEmployeeDetailsDeMobilizeReason_idx");

                entity.HasIndex(e => e.DeMobilizeRequestId)
                    .HasName("NocEmployeeDetailsDemobilizeRequest_idx");

                entity.HasIndex(e => e.DeMobilizeStatusId)
                    .HasName("NocEmployeeDetailsDeMobilizeStatus_idx");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("NocEmployeeDetailsEmployee_idx");

                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("NocEmployeeDetailsFinancialPeriod_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.NocDetailsId)
                    .HasName("NocEmployeeDetailsNocDetails_idx");

                entity.HasIndex(e => e.ProjectLocationId)
                    .HasName("NocEmployeeDetailsProjectLocation_idx");

                entity.HasIndex(e => e.RateTypeId)
                    .HasName("NocEmployeeDetailsRateType_idx");

                entity.HasIndex(e => e.ReasonId)
                    .HasName("NocEmployeeDetailsReason_idx");

                entity.HasIndex(e => e.SafetyStatusId)
                    .HasName("NocEmployeeDetailsSafetyStatus_idx");

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("NocEmployeeDetailsSponsorshipCompany_idx");

                entity.HasIndex(e => e.TradeChangeId)
                    .HasName("NocEmployeeDetailsTradeChange_idx");

                entity.HasIndex(e => e.TransportationStatusId)
                    .HasName("NocEmployeeDetailsTransportation_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccomadationStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ClientProjectId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Complaint)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DeMobilizeReasonId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DeMobilizeRequestId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DeMobilizeStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EmployeeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsApproved).HasColumnType("bit(1)");

                entity.Property(e => e.IsCancelled)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDemobilized)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsMobilized).HasColumnType("bit(1)");

                entity.Property(e => e.IsOperationApproved).HasColumnType("bit(1)");

                entity.Property(e => e.IsSalesApproved).HasColumnType("bit(1)");

                entity.Property(e => e.NocDetailsId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ProjectLocationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RateTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ReasonId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SafetyStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TradeChangeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TrainingRequest).HasColumnType("bit(1)");

                entity.Property(e => e.TransportationStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.WorkComment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccomadationStatus)
                    .WithMany(p => p.NocEmployeeDetailsAccomadationStatus)
                    .HasForeignKey(d => d.AccomadationStatusId)
                    .HasConstraintName("NocEmployeeDetailsAccomadation");

                entity.HasOne(d => d.DeMobilizeReason)
                    .WithMany(p => p.NocEmployeeDetails)
                    .HasForeignKey(d => d.DeMobilizeReasonId)
                    .HasConstraintName("NocEmployeeDetailsDeMobilizeReason");

                entity.HasOne(d => d.DeMobilizeRequest)
                    .WithMany(p => p.NocEmployeeDetailsDeMobilizeRequest)
                    .HasForeignKey(d => d.DeMobilizeRequestId)
                    .HasConstraintName("NocEmployeeDetailsDemobilizeRequest");

                entity.HasOne(d => d.DeMobilizeStatus)
                    .WithMany(p => p.NocEmployeeDetails)
                    .HasForeignKey(d => d.DeMobilizeStatusId)
                    .HasConstraintName("NocEmployeeDetailsDeMobilizeStatus");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.NocEmployeeDetailsEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("NocEmployeeDetailsEmployee");

                entity.HasOne(d => d.NocDetails)
                    .WithMany(p => p.NocEmployeeDetails)
                    .HasForeignKey(d => d.NocDetailsId)
                    .HasConstraintName("NocEmployeeDetailsNocDetails");

                entity.HasOne(d => d.ProjectLocation)
                    .WithMany(p => p.NocEmployeeDetails)
                    .HasForeignKey(d => d.ProjectLocationId)
                    .HasConstraintName("NocEmployeeDetailsProjectLocation");

                entity.HasOne(d => d.RateType)
                    .WithMany(p => p.NocEmployeeDetails)
                    .HasForeignKey(d => d.RateTypeId)
                    .HasConstraintName("NocEmployeeDetailsRateType");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.NocEmployeeDetails)
                    .HasForeignKey(d => d.ReasonId)
                    .HasConstraintName("NocEmployeeDetailsReason");

                entity.HasOne(d => d.SafetyStatus)
                    .WithMany(p => p.NocEmployeeDetails)
                    .HasForeignKey(d => d.SafetyStatusId)
                    .HasConstraintName("NocEmployeeDetailsSafetyStatus");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.NocEmployeeDetails)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("NocEmployeeDetailsSponsorshipCompany");

                entity.HasOne(d => d.TradeChange)
                    .WithMany(p => p.NocEmployeeDetails)
                    .HasForeignKey(d => d.TradeChangeId)
                    .HasConstraintName("NocEmployeeDetailsTradeChange");

                entity.HasOne(d => d.TransportationStatus)
                    .WithMany(p => p.NocEmployeeDetailsTransportationStatus)
                    .HasForeignKey(d => d.TransportationStatusId)
                    .HasConstraintName("NocEmployeeDetailsTransportation");
            });

            modelBuilder.Entity<NocRenarks>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(3000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NocReportType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NocSafetyStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Status)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NocStatus>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NocTradeReason>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("NotificationBranch_idx");

                entity.HasIndex(e => e.DocumentTypeId)
                    .HasName("NotificationDocumentType_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ModuleId)
                    .HasName("NotificationModule_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ActivityId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ExpiryDocumentType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsNotified)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ModuleId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.NotificationType).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("NotificationBranch");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("NotificationDocumentType");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("NotificationModule");
            });

            modelBuilder.Entity<OccuranceType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OfficeLocation>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationSettings>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("OperationSettingsBranch_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttendanceCount)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AttendancePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DemandRequestCount).HasColumnType("bigint(20)");

                entity.Property(e => e.DemandRequestPrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NocCount)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NocPrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.OperationSettings)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("OperationSettingsBranch");
            });

            modelBuilder.Entity<Organisation>(entity =>
            {
                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("DefaultFinancialPerion_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.LogoId)
                    .HasName("LogoAttachmentId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsActive)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LogoId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TrnNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.Organisation)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("DefaultFinancialPeriod");

                entity.HasOne(d => d.Logo)
                    .WithMany(p => p.Organisation)
                    .HasForeignKey(d => d.LogoId)
                    .HasConstraintName("LogoAttachmentId");
            });

            modelBuilder.Entity<PassportStatus>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.PassportStatus1)
                    .HasColumnName("PassportStatus")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentMode>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.PaymentModel)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentSchedule>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Days).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy)
                    .HasName("CreatedUser_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ModuleId)
                    .HasName("UserModule_idx");

                entity.HasIndex(e => e.PermissionTypeId)
                    .HasName("UserPermissionType_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("PermissionUser_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CreatedBy).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsActive)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsModule)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ModuleId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PermissionCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("CreatedUser");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Permission)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("UserModule");

                entity.HasOne(d => d.PermissionType)
                    .WithMany(p => p.Permission)
                    .HasForeignKey(d => d.PermissionTypeId)
                    .HasConstraintName("UserPermissionType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PermissionUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("UserPermissions");
            });

            modelBuilder.Entity<PermissionType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("ProjectBranch_idx");

                entity.HasIndex(e => e.ClientId)
                    .HasName("ProjectClientId_idx");

                entity.HasIndex(e => e.EngineerId)
                    .HasName("ProjectEngineerId_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.PaymentTypeId)
                    .HasName("ProjecctPaymentTypeId_idx");

                entity.HasIndex(e => e.ProjectDetailsId)
                    .HasName("ProjectDetailId_idx");

                entity.HasIndex(e => e.ProjectTypeId)
                    .HasName("ProjectTypeId_idx");

                entity.HasIndex(e => e.SalesExecutiveId)
                    .HasName("ProjectSalesExecutiveId_idx");

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("ProjectSponsorshipCompanyId_idx");

                entity.HasIndex(e => e.TransferSponsorshipCompanyId)
                    .HasName("ProjectTransferSponsorshipCompany_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ClientId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ClientProjectNo)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ContractName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EngineerId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EngineerName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsMiview)
                    .HasColumnName("IsMIView")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsTransfer)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Lpono)
                    .HasColumnName("LPONo")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ProjectDetailsId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesExecutiveId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TransferSponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("ProjectBranch");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ProjectClient)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("ProjectClientId");

                entity.HasOne(d => d.Engineer)
                    .WithMany(p => p.ProjectEngineer)
                    .HasForeignKey(d => d.EngineerId)
                    .HasConstraintName("ProjectEngineerId");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("ProjecctPaymentTypeId");

                entity.HasOne(d => d.ProjectDetails)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.ProjectDetailsId)
                    .HasConstraintName("ProjectDetailId");

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .HasConstraintName("ProjectTypeId");

                entity.HasOne(d => d.SalesExecutive)
                    .WithMany(p => p.ProjectSalesExecutive)
                    .HasForeignKey(d => d.SalesExecutiveId)
                    .HasConstraintName("ProjectSalesExecutiveId");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.ProjectSponsorshipCompany)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("ProjectSponsorshipCompanyId");

                entity.HasOne(d => d.TransferSponsorshipCompany)
                    .WithMany(p => p.ProjectTransferSponsorshipCompany)
                    .HasForeignKey(d => d.TransferSponsorshipCompanyId)
                    .HasConstraintName("ProjectTransferSponsorshipCompany");
            });

            modelBuilder.Entity<ProjectDetails>(entity =>
            {
                entity.HasIndex(e => e.AccomadationTypeId)
                    .HasName("AccomadationTypeId_idx");

                entity.HasIndex(e => e.AccoumadationEmiratesId)
                    .HasName("AccoumadationEmiratesId_idx");

                entity.HasIndex(e => e.CoOrdinatorId)
                    .HasName("ProjectDetailsCoOrdinator_idx");

                entity.HasIndex(e => e.DesignationId)
                    .HasName("ContactPersonDesignationId_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectLocationId)
                    .HasName("ProjectLocationId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccomadationTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccoumadationEmiratesId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AllowableAbsence).HasColumnType("decimal(10,2)");

                entity.Property(e => e.CoOrdinatorId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Gpsxcordinates)
                    .HasColumnName("GPSXCordinates")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gpsycordinates)
                    .HasColumnName("GPSYCordinates")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsFlat)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsOverTime)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.NormalHours).HasColumnType("decimal(10,2)");

                entity.Property(e => e.ProjectLocationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Xcordinates)
                    .HasColumnName("XCordinates")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ycordinates)
                    .HasColumnName("YCordinates")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccomadationType)
                    .WithMany(p => p.ProjectDetails)
                    .HasForeignKey(d => d.AccomadationTypeId)
                    .HasConstraintName("ProjectAccomadationTypeId");

                entity.HasOne(d => d.AccoumadationEmirates)
                    .WithMany(p => p.ProjectDetails)
                    .HasForeignKey(d => d.AccoumadationEmiratesId)
                    .HasConstraintName("ProjectAccoumadationEmiratesId");

                entity.HasOne(d => d.CoOrdinator)
                    .WithMany(p => p.ProjectDetails)
                    .HasForeignKey(d => d.CoOrdinatorId)
                    .HasConstraintName("ProjectDetailsCoOrdinator");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.ProjectDetails)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("ContactPersonDesignationId");

                entity.HasOne(d => d.ProjectLocation)
                    .WithMany(p => p.ProjectDetails)
                    .HasForeignKey(d => d.ProjectLocationId)
                    .HasConstraintName("ProjectLocationId");
            });

            modelBuilder.Entity<ProjectDocument>(entity =>
            {
                entity.HasIndex(e => e.AttachmentId)
                    .HasName("AttachmentId_idx");

                entity.HasIndex(e => e.DocumentTypeId)
                    .HasName("ProjectDocumentDocumentType_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectId)
                    .HasName("ProjectId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttachmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.ProjectDocument)
                    .HasForeignKey(d => d.AttachmentId)
                    .HasConstraintName("AttachmentId");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.ProjectDocument)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("ProjectDocumentDocumentType");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectDocument)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("ProjectId");
            });

            modelBuilder.Entity<ProjectHolidayDetails>(entity =>
            {
                entity.HasIndex(e => e.HolidayTypeId)
                    .HasName("ProjectHolidayTypeId_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectId)
                    .HasName("ProjectId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Days).HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HolidayTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.HolidayType)
                    .WithMany(p => p.ProjectHolidayDetails)
                    .HasForeignKey(d => d.HolidayTypeId)
                    .HasConstraintName("ProjectHolidayTypeId");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectHolidayDetails)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("ProjectHolidayDetailsId");
            });

            modelBuilder.Entity<ProjectLocation>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.LocationId)
                    .HasName("ProjectLocationLocation_idx");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("ProjectLocationProject_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ProjectLocation)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("ProjectLocationLocation");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectLocation)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("ProjectLocationProject");
            });

            modelBuilder.Entity<ProjectRate>(entity =>
            {
                entity.HasIndex(e => e.DetailsId)
                    .HasName("ProjectDetailsId_idx");

                entity.HasIndex(e => e.OccuranceId)
                    .HasName("ProjectRateOccurance_idx");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("ProjectRateId_idx");

                entity.HasIndex(e => e.RateTypeId)
                    .HasName("ProjectRateTypeId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Acctracost)
                    .HasColumnName("ACCTRACost")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.DetailsId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HotRate).HasColumnType("decimal(10,2)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.NotRate).HasColumnType("decimal(10,2)");

                entity.Property(e => e.OccuranceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Rate).HasColumnType("decimal(10,2)");

                entity.Property(e => e.RateTypeId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Details)
                    .WithMany(p => p.ProjectRate)
                    .HasForeignKey(d => d.DetailsId)
                    .HasConstraintName("ProjectDetailsId");

                entity.HasOne(d => d.Occurance)
                    .WithMany(p => p.ProjectRate)
                    .HasForeignKey(d => d.OccuranceId)
                    .HasConstraintName("ProjectRateOccurance");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectRate)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("ProjectRateId");

                entity.HasOne(d => d.RateType)
                    .WithMany(p => p.ProjectRate)
                    .HasForeignKey(d => d.RateTypeId)
                    .HasConstraintName("ProjectRateTypeId");
            });

            modelBuilder.Entity<ProjectType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RateContractTemplete>(entity =>
            {
                entity.HasIndex(e => e.DocumentId)
                    .HasName("RateContractTempleteDocument_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserRoleId)
                    .HasName("RateContractTempleteUserRole_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ContractName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.UserRoleId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.RateContractTemplete)
                    .HasForeignKey(d => d.DocumentId)
                    .HasConstraintName("RateContractTempleteDocument");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.RateContractTemplete)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("RateContractTempleteUserRole");
            });

            modelBuilder.Entity<RateContractTempleteTrades>(entity =>
            {
                entity.HasIndex(e => e.DesignationId)
                    .HasName("RateContractTempleteTradesDesignation_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.OccuranceId)
                    .HasName("RateContractTempleteTradesOccureance_idx");

                entity.HasIndex(e => e.RateContractTempleteId)
                    .HasName("RateContractTempleteTradesRateContractTemplete_idx");

                entity.HasIndex(e => e.RatetypeId)
                    .HasName("RateContractTempleteTradesRate_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AcctraCost)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HotRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.NotRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.OccuranceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.RateContractTempleteId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RatetypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TraCost)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.RateContractTempleteTrades)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("RateContractTempleteTradesDesignation");

                entity.HasOne(d => d.Occurance)
                    .WithMany(p => p.RateContractTempleteTrades)
                    .HasForeignKey(d => d.OccuranceId)
                    .HasConstraintName("RateContractTempleteTradesOccureance");

                entity.HasOne(d => d.RateContractTemplete)
                    .WithMany(p => p.RateContractTempleteTrades)
                    .HasForeignKey(d => d.RateContractTempleteId)
                    .HasConstraintName("RateContractTempleteTradesRateContractTemplete");

                entity.HasOne(d => d.Ratetype)
                    .WithMany(p => p.RateContractTempleteTrades)
                    .HasForeignKey(d => d.RatetypeId)
                    .HasConstraintName("RateContractTempleteTradesRate");
            });

            modelBuilder.Entity<RateType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalaryDetails>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SalaryHeadId)
                    .HasName("SalaryDetailsSalaryHead_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("UserSalary_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccomadationAllowance)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Basic)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.FoodAllowance)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.GrossSalary)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.HourRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.HourlyRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsHourlyRate).HasColumnType("bit(1)");

                entity.Property(e => e.OtherAllowance)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.SalaryHeadId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SpecialAllowance)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.TelephoneAllowance)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.TransportationAllowance)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.SalaryHead)
                    .WithMany(p => p.SalaryDetails)
                    .HasForeignKey(d => d.SalaryHeadId)
                    .HasConstraintName("SalaryDetailsSalaryHead");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SalaryDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("UserSalary");
            });

            modelBuilder.Entity<SalaryHead>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalaryHeadValue>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SalaryHeadId)
                    .HasName("SalaryHeadValueSalaryHead_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HotRatePer)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IsHourly)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsOverTime)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.NotRatePer)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.PotRatePer)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.SalaryHeadId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.SalaryHead)
                    .WithMany(p => p.SalaryHeadValue)
                    .HasForeignKey(d => d.SalaryHeadId)
                    .HasConstraintName("SalaryHeadValueSalaryHead");
            });

			modelBuilder.Entity<SisterConcernCompanies>(entity =>
            {
                entity.HasIndex(e => e.CustomerId)
                    .HasName("CustomerId_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ParentId)
                    .HasName("SisterConcernCompaniesParent_idx");

                entity.Property(e => e.Id).HasColumnType("bigint unsigned");

                entity.Property(e => e.CustomerId).HasColumnType("bigint unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ParentId).HasColumnType("bigint unsigned");

                entity.HasOne(d => d.Customer)
                    .WithOne(p => p.SisterConcernCompanies)
                    .HasForeignKey<SisterConcernCompanies>(d => d.CustomerId)
                    .HasConstraintName("SisterConcernCompaniesCustomer");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("SisterConcernCompaniesParent");
            });

            modelBuilder.Entity<SponsorshipCompany>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("BranchCompany_idx");

                entity.HasIndex(e => e.CountyId)
                    .HasName("CompanyDefauCountry_idx");

                entity.HasIndex(e => e.CrmcealId)
               .HasName("CRMCeal_idx");

                entity.HasIndex(e => e.CurrencyId)
                    .HasName("CompanyDefauCurrency_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.LogoId)
                    .HasName("CompanyLogo_idx");

                entity.HasIndex(e => e.ReportFooterId)
                    .HasName("CompanyReportFooter_idx");

                entity.HasIndex(e => e.ReportHeaderId)
                    .HasName("CompanyReportHeader_idx");

                entity.HasIndex(e => e.StampId)
                    .HasName("CompanyStamp_idx");

                entity.HasIndex(e => e.WaterMarkId)
                    .HasName("SponsorshipCompanyWaterMark_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CrmcealId)
               .HasColumnName("CRMCealId")
               .HasColumnType("bigint unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ClientCodePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CountyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CurrencyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LabourCodePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LogoId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Molid)
                    .HasColumnName("MOLId")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.NameInArabic)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Place)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Pobox)
                    .HasColumnName("POBox")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectCodePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReportFooterId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ReportHeaderId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StaffCodePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StampId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SuppliedLabourCodePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCodePrefix)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Trn)
                    .HasColumnName("TRN")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.WaterMarkId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Website)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.SponsorshipCompany)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("BranchCompany");

                entity.HasOne(d => d.County)
                    .WithMany(p => p.SponsorshipCompany)
                    .HasForeignKey(d => d.CountyId)
                    .HasConstraintName("CompanyDefauCountry");

                entity.HasOne(d => d.Crmceal)
               .WithMany(p => p.SponsorshipCompanyCrmceal)
               .HasForeignKey(d => d.CrmcealId)
               .HasConstraintName("CRMCealId");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.SponsorshipCompany)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("CompanyDefauCurrency");

                entity.HasOne(d => d.Logo)
                    .WithMany(p => p.SponsorshipCompanyLogo)
                    .HasForeignKey(d => d.LogoId)
                    .HasConstraintName("CompanyLogo");

                entity.HasOne(d => d.ReportFooter)
                    .WithMany(p => p.SponsorshipCompanyReportFooter)
                    .HasForeignKey(d => d.ReportFooterId)
                    .HasConstraintName("CompanyReportFooter");

                entity.HasOne(d => d.ReportHeader)
                    .WithMany(p => p.SponsorshipCompanyReportHeader)
                    .HasForeignKey(d => d.ReportHeaderId)
                    .HasConstraintName("CompanyReportHeader");

                entity.HasOne(d => d.Stamp)
                    .WithMany(p => p.SponsorshipCompanyStamp)
                    .HasForeignKey(d => d.StampId)
                    .HasConstraintName("CompanyStamp");

                entity.HasOne(d => d.WaterMark)
                    .WithMany(p => p.SponsorshipCompanyWaterMark)
                    .HasForeignKey(d => d.WaterMarkId)
                    .HasConstraintName("SponsorshipCompanyWaterMark");
            });

            modelBuilder.Entity<SponsorshipCompanyDocument>(entity =>
            {
                entity.HasIndex(e => e.AttachmentId)
                    .HasName("CompanyAttachment_idx");

                entity.HasIndex(e => e.DocumentTypeId)
                    .HasName("SponsorshipCompanyDocumentDocumentType_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SponsershipCompanyId)
                    .HasName("CompanyDocument_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttachmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SponsershipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Type)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.SponsorshipCompanyDocument)
                    .HasForeignKey(d => d.AttachmentId)
                    .HasConstraintName("CompanyAttachment");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.SponsorshipCompanyDocument)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("SponsorshipCompanyDocumentDocumentType");

                entity.HasOne(d => d.SponsershipCompany)
                    .WithMany(p => p.SponsorshipCompanyDocument)
                    .HasForeignKey(d => d.SponsershipCompanyId)
                    .HasConstraintName("CompanyDocument");
            });

            modelBuilder.Entity<StaffSalary>(entity =>
            {
                entity.HasIndex(e => e.EmployeeId)
                    .HasName("StaffSalaryEmployee_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.StaffSalaryHeaderId)
                    .HasName("StaffSalaryStaffSalaryHeader_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Advance).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Allowance).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Basic).HasColumnType("decimal(10,2)");

                entity.Property(e => e.EmployeeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EncashAmount).HasColumnType("decimal(10,2)");

                entity.Property(e => e.EncashDays).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Esi)
                    .HasColumnName("ESI")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.FixedAdditions).HasColumnType("decimal(10,2)");

                entity.Property(e => e.FixedDeduction).HasColumnType("decimal(10,2)");

                entity.Property(e => e.GrossSalary).HasColumnType("decimal(10,2)");

                entity.Property(e => e.HalfPay).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Hra)
                    .HasColumnName("HRA")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Lop).HasColumnType("decimal(10,2)");

                entity.Property(e => e.NoPay).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Not)
                    .HasColumnName("NOT")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.OtherAdditions).HasColumnType("decimal(10,2)");

                entity.Property(e => e.OtherDeduction).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Others).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Pf)
                    .HasColumnName("PF")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Pot)
                    .HasColumnName("POT")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StaffSalaryHeaderId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Ta)
                    .HasColumnName("TA")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.TotalAdditions).HasColumnType("decimal(10,2)");

                entity.Property(e => e.TotalDeductions).HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.StaffSalary)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("StaffSalaryEmployee");

                entity.HasOne(d => d.StaffSalaryHeader)
                    .WithMany(p => p.StaffSalary)
                    .HasForeignKey(d => d.StaffSalaryHeaderId)
                    .HasConstraintName("StaffSalaryStaffSalaryHeader");
            });

            modelBuilder.Entity<StaffSalaryHeader>(entity =>
            {
                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("StaffSalaryHeaderFinancialPeriod_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("StaffSalaryHeaderSponsorshipCompany_idx");

                entity.HasIndex(e => e.UserRoleCategoryId)
                    .HasName("StaffSalaryHeaderUserRoleCategory_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Month).HasColumnType("int(11)");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserRoleCategoryId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Year).HasColumnType("int(11)");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.StaffSalaryHeader)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("StaffSalaryHeaderFinancialPeriod");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.StaffSalaryHeader)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("StaffSalaryHeaderSponsorshipCompany");

                entity.HasOne(d => d.UserRoleCategory)
                    .WithMany(p => p.StaffSalaryHeader)
                    .HasForeignKey(d => d.UserRoleCategoryId)
                    .HasConstraintName("StaffSalaryHeaderUserRoleCategory");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasIndex(e => e.CountryId)
                    .HasName("StateCountry_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CountryId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.StateName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("StateCountry");
            });

            modelBuilder.Entity<SupplierDescription>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SupplierInvoiceDetails>(entity =>
            {
                entity.HasIndex(e => e.AccountUserInvoiceId)
                    .HasName("SupplierInvoiceDetailsAccountUserInvoice_idx");

                entity.HasIndex(e => e.DesignationId)
                    .HasName("SupplierInvoiceDetailsDesignation_idx");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("SupplierInvoiceDetailsEmployee_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectId)
                    .HasName("SupplierInvoiceDetailsProject_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AbsentDays).HasColumnType("int(11)");

                entity.Property(e => e.AccountUserInvoiceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EmployeeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HotHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.HotRate).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Hours).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("bit(1)");

                entity.Property(e => e.NotHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.NotRate).HasColumnType("decimal(10,2)");

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Rate).HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.AccountUserInvoice)
                    .WithMany(p => p.SupplierInvoiceDetails)
                    .HasForeignKey(d => d.AccountUserInvoiceId)
                    .HasConstraintName("SupplierInvoiceDetailsAccountUserInvoice");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.SupplierInvoiceDetails)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("SupplierInvoiceDetailsDesignation");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SupplierInvoiceDetails)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("SupplierInvoiceDetailsEmployee");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SupplierInvoiceDetails)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("SupplierInvoiceDetailsProject");
            });

            modelBuilder.Entity<SupplierTimeCard>(entity =>
            {
                entity.HasIndex(e => e.AccountUserInvoiceId)
                    .HasName("SupplierTimeCardAccountUserInvoice_idx");

                entity.HasIndex(e => e.DesignationId)
                    .HasName("SupplierTimeCardDesignation_idx");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("SupplierTimeCardEmployee_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectId)
                    .HasName("SupplierTimeCardProject_idx");

                entity.HasIndex(e => e.SupplierTimeCardHeaderId)
                    .HasName("SupplierTimeCardSupplierTimeCardHeader_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccountUserInvoiceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DedAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.DedHrs)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.DedRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EmployeeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HotAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.HotHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.HotRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IncAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IncHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.IncRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IsAbsent)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsHoliday)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.NormalAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.NormalHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.NormalRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.NotAmt)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.NotHrs).HasColumnType("decimal(10,2)");

                entity.Property(e => e.NotRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ProjectId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SupplierTimeCardHeaderId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.AccountUserInvoice)
                    .WithMany(p => p.SupplierTimeCard)
                    .HasForeignKey(d => d.AccountUserInvoiceId)
                    .HasConstraintName("SupplierTimeCardAccountUserInvoice");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.SupplierTimeCard)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("SupplierTimeCardDesignation");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SupplierTimeCard)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("SupplierTimeCardEmployee");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SupplierTimeCard)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("SupplierTimeCardProject");

                entity.HasOne(d => d.SupplierTimeCardHeader)
                    .WithMany(p => p.SupplierTimeCard)
                    .HasForeignKey(d => d.SupplierTimeCardHeaderId)
                    .HasConstraintName("SupplierTimeCardSupplierTimeCardHeader");
            });

            modelBuilder.Entity<SupplierTimeCardHeader>(entity =>
            {
                entity.HasIndex(e => e.EmployeeId)
                    .HasName("SupplierTimeCardHeaderEmployee_idx");

                entity.HasIndex(e => e.FinancialPeriodId)
                    .HasName("SupplierTimeCardHeaderFinancialPeriod_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SupplierId)
                    .HasName("SupplierTimeCardHeaderSupplier_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EmployeeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FinancialPeriodId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Month).HasColumnType("int(11)");

                entity.Property(e => e.SupplierId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Year).HasColumnType("int(11)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SupplierTimeCardHeaderEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("SupplierTimeCardHeaderEmployee");

                entity.HasOne(d => d.FinancialPeriod)
                    .WithMany(p => p.SupplierTimeCardHeader)
                    .HasForeignKey(d => d.FinancialPeriodId)
                    .HasConstraintName("SupplierTimeCardHeaderFinancialPeriod");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierTimeCardHeaderSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("SupplierTimeCardHeaderSupplier");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.BasicDetailId)
                    .HasName("BasicDetails_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserDetailsId)
                    .HasName("UserDetailsId_idx");

                entity.HasIndex(e => e.UserName)
                    .HasName("UserName_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserRoleId)
                    .HasName("UserRole_idx");

                entity.HasIndex(e => e.UserRoleRuleId)
                    .HasName("UserRoleRuleId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BasicDetailId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsActive)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                //entity.Property(e => e.IsFound).HasColumnType("bit(1)");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserDetailsId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserRoleRuleId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.BasicDetail)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.BasicDetailId)
                    .HasConstraintName("BasicDetailId");

                entity.HasOne(d => d.UserDetails)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserDetailsId)
                    .HasConstraintName("UserDetailsId");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("UserRoleId");

                entity.HasOne(d => d.UserRoleRule)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserRoleRuleId)
                    .HasConstraintName("UserRoleRuleId");
            });

            modelBuilder.Entity<UserCategory>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.RoleId)
                    .HasName("ClientCategoryUserRoleId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserCategory)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("ClientCategoryUserRoleId");
            });

            modelBuilder.Entity<UserDetails>(entity =>
            {
                entity.HasIndex(e => e.BankDocattachmentId)
                    .HasName("BankDOCAttachmentId_idx");

                entity.HasIndex(e => e.CicpaAttachmentId)
                    .HasName("UserDetailsCicpaAttchment_idx");

                entity.HasIndex(e => e.CicpaStatusId)
                    .HasName("UserDetailsCicpaStatus_idx");

                entity.HasIndex(e => e.DrivingLicenceAttachmentId)
                    .HasName("DrivingLicenceAttachmentId_idx");

                entity.HasIndex(e => e.DrivingLicenceStatusId)
                    .HasName("UserDetailsDrivingLicenceStatus_idx");

                entity.HasIndex(e => e.DrivingLicenceTypeId)
                    .HasName("EmplyeeDrivingLicenceType_idx");

                entity.HasIndex(e => e.EidattachmentId)
                    .HasName("UserEIDAttachmentId_idx");

                entity.HasIndex(e => e.EidstatusId)
                    .HasName("UserEIDStatusId_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.InsuranceCardAttachmentId)
                    .HasName("UserInsuranceCardAttachmentId_idx");

                entity.HasIndex(e => e.InsuranceCardStatusId)
                    .HasName("UserDetailsInsuranceCardStatus_idx");

                entity.HasIndex(e => e.InsuranceCardTypeId)
                    .HasName("UserInsuranceCardTypeId_idx");

                entity.HasIndex(e => e.LabourCardPersonalNo)
                    .HasName("LabourIdAttachment_idx");

                entity.HasIndex(e => e.LabourCardStatusId)
                    .HasName("UserDetailsLabourCardStatus_idx");

                entity.HasIndex(e => e.PassportJpegattachmentId)
                    .HasName("UserPassportJpegAttachmentId_idx");

                entity.HasIndex(e => e.PassportPdfattachmentId)
                    .HasName("UserPassportAttachmentId_idx");

                entity.HasIndex(e => e.PassportStatusId)
                    .HasName("EmplyeePassportStatus_idx");

                entity.HasIndex(e => e.PaymentDocAttachmentId)
                    .HasName("UserPaymentDocAttachmentId_idx");

                entity.HasIndex(e => e.PaymentModeId)
                    .HasName("UserPaymentModeId_idx");

                entity.HasIndex(e => e.VisaAttachmentId)
                    .HasName("VisaImageAttachment_idx");

                entity.HasIndex(e => e.VisaDesignationId)
                    .HasName("EmplyeeVisaDesignation_idx");

                entity.HasIndex(e => e.VisaSponsorId)
                    .HasName("EmplyeeSponser_idx");

                entity.HasIndex(e => e.VisaStatusId)
                    .HasName("UserVisaStatusId_idx");

                entity.HasIndex(e => e.VisaTypeId)
                    .HasName("EmplyeeVisaType_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BankCardNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.BankDocattachmentId)
                    .HasColumnName("BankDOCAttachmentId")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BankDocfileName)
                    .HasColumnName("BankDOCFileName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CicpaAttachmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CicpaNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CicpaStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DrivingLicenceAttachmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DrivingLicenceFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DrivingLicenceNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DrivingLicenceStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DrivingLicenceTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EidFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EidattachmentId)
                    .HasColumnName("EIDAttachmentId")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EidexpiryDate).HasColumnName("EIDExpiryDate");

                entity.Property(e => e.EidissueDate).HasColumnName("EIDIssueDate");

                entity.Property(e => e.Eidno)
                    .HasColumnName("EIDNo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.EidstatusId)
                    .HasColumnName("EIDStatusId")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Ibanno)
                    .HasColumnName("IBANNo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceCardAttachmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.InsuranceCardFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceCardNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceCardStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.InsuranceCardTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LabourCardNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LabourCardPersonalNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LabourCardStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PassportJpegattachmentId)
                    .HasColumnName("PassportJPEGAttachmentId")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PassportJpegfileName)
                    .HasColumnName("PassportJPEGFileName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PassportPdfFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PassportPdfattachmentId)
                    .HasColumnName("PassportPDFAttachmentId")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PassportStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PaymentCardNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDocAttachmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PaymentDocFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentModeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PaymentRemarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceProvider)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Uidno)
                    .HasColumnName("UIDNo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.VisaAttachmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.VisaDesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.VisaDuration)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.VisaFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VisaNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.VisaSponsorId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.VisaStatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.VisaTypeId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.BankDocattachment)
                    .WithMany(p => p.UserDetailsBankDocattachment)
                    .HasForeignKey(d => d.BankDocattachmentId)
                    .HasConstraintName("BankDOCAttachmentId");

                entity.HasOne(d => d.CicpaAttachment)
                    .WithMany(p => p.UserDetailsCicpaAttachment)
                    .HasForeignKey(d => d.CicpaAttachmentId)
                    .HasConstraintName("UserDetailsCicpaAttchment");

                entity.HasOne(d => d.CicpaStatus)
                    .WithMany(p => p.UserDetailsCicpaStatus)
                    .HasForeignKey(d => d.CicpaStatusId)
                    .HasConstraintName("UserDetailsCicpaStatus");

                entity.HasOne(d => d.DrivingLicenceAttachment)
                    .WithMany(p => p.UserDetailsDrivingLicenceAttachment)
                    .HasForeignKey(d => d.DrivingLicenceAttachmentId)
                    .HasConstraintName("DrivingLicenceAttachmentId");

                entity.HasOne(d => d.DrivingLicenceStatus)
                    .WithMany(p => p.UserDetailsDrivingLicenceStatus)
                    .HasForeignKey(d => d.DrivingLicenceStatusId)
                    .HasConstraintName("UserDetailsDrivingLicenceStatus");

                entity.HasOne(d => d.DrivingLicenceType)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.DrivingLicenceTypeId)
                    .HasConstraintName("UserDrivingLicenceType");

                entity.HasOne(d => d.Eidattachment)
                    .WithMany(p => p.UserDetailsEidattachment)
                    .HasForeignKey(d => d.EidattachmentId)
                    .HasConstraintName("UserEIDAttachmentId");

                entity.HasOne(d => d.Eidstatus)
                    .WithMany(p => p.UserDetailsEidstatus)
                    .HasForeignKey(d => d.EidstatusId)
                    .HasConstraintName("UserEIDStatusId");

                entity.HasOne(d => d.InsuranceCardAttachment)
                    .WithMany(p => p.UserDetailsInsuranceCardAttachment)
                    .HasForeignKey(d => d.InsuranceCardAttachmentId)
                    .HasConstraintName("UserInsuranceCardAttachmentId");

                entity.HasOne(d => d.InsuranceCardStatus)
                    .WithMany(p => p.UserDetailsInsuranceCardStatus)
                    .HasForeignKey(d => d.InsuranceCardStatusId)
                    .HasConstraintName("UserDetailsInsuranceCardStatus");

                entity.HasOne(d => d.InsuranceCardType)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.InsuranceCardTypeId)
                    .HasConstraintName("UserInsuranceCardTypeId");

                entity.HasOne(d => d.LabourCardStatus)
                    .WithMany(p => p.UserDetailsLabourCardStatus)
                    .HasForeignKey(d => d.LabourCardStatusId)
                    .HasConstraintName("UserDetailsLabourCardStatus");

                entity.HasOne(d => d.PassportJpegattachment)
                    .WithMany(p => p.UserDetailsPassportJpegattachment)
                    .HasForeignKey(d => d.PassportJpegattachmentId)
                    .HasConstraintName("UserPassportJPEGAttachmentId");

                entity.HasOne(d => d.PassportPdfattachment)
                    .WithMany(p => p.UserDetailsPassportPdfattachment)
                    .HasForeignKey(d => d.PassportPdfattachmentId)
                    .HasConstraintName("UserPassportPDFAttachmentId");

                entity.HasOne(d => d.PassportStatus)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.PassportStatusId)
                    .HasConstraintName("UserPassportStatusId");

                entity.HasOne(d => d.PaymentDocAttachment)
                    .WithMany(p => p.UserDetailsPaymentDocAttachment)
                    .HasForeignKey(d => d.PaymentDocAttachmentId)
                    .HasConstraintName("UserPaymentDocAttachmentId");

                entity.HasOne(d => d.PaymentMode)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.PaymentModeId)
                    .HasConstraintName("UserPaymentModeId");

                entity.HasOne(d => d.VisaAttachment)
                    .WithMany(p => p.UserDetailsVisaAttachment)
                    .HasForeignKey(d => d.VisaAttachmentId)
                    .HasConstraintName("UserVisaAttachmentId");

                entity.HasOne(d => d.VisaDesignation)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.VisaDesignationId)
                    .HasConstraintName("UserVisaDesignationId");

                entity.HasOne(d => d.VisaSponsor)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.VisaSponsorId)
                    .HasConstraintName("UserSponserId");

                entity.HasOne(d => d.VisaStatus)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.VisaStatusId)
                    .HasConstraintName("UserVisaStatusId");

                entity.HasOne(d => d.VisaType)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.VisaTypeId)
                    .HasConstraintName("UserVisaTypeId");
            });

            modelBuilder.Entity<UserDocument>(entity =>
            {
                entity.HasIndex(e => e.AttachmentId)
                    .HasName("DocumentAttachment_idx");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("DocumentCompanyId_idx");

                entity.HasIndex(e => e.DocumentTypeId)
                    .HasName("UserDocumentDocumentType_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.StatusId)
                    .HasName("UserDocumentStatus_idx");

                entity.HasIndex(e => e.SupplierDescriptionId)
                    .HasName("DocumentSupplierDescriptionId_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("DocumentUser_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttachmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SupplierDescriptionId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.UserDocument)
                    .HasForeignKey(d => d.AttachmentId)
                    .HasConstraintName("DocumentAttachment");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserDocument)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("DocumentCompanyId");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.UserDocument)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("UserDocumentDocumentType");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.UserDocument)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("UserDocumentStatus");

                entity.HasOne(d => d.SupplierDescription)
                    .WithMany(p => p.UserDocument)
                    .HasForeignKey(d => d.SupplierDescriptionId)
                    .HasConstraintName("DocumentSupplierDescriptionId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDocument)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("DocumentUser");
            });

            modelBuilder.Entity<UserHistory>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("UserHistoryId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsBlackListed).HasColumnType("bit(1)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserHistory)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("UserHistoryId");
            });

            modelBuilder.Entity<UserRate>(entity =>
            {
                entity.HasIndex(e => e.DesignationId)
                    .HasName("UserRateDesignation_idx");

                entity.HasIndex(e => e.OccuranceId)
                    .HasName("UserRateOccurance_idx");

                entity.HasIndex(e => e.RateTypeId)
                    .HasName("UserRateTypeId_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("UserRateId_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Acctracost)
                    .HasColumnName("ACCTRACost")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Details)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HotRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.NotRate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.OccuranceId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.RateTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TraCost)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.UserRate)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("UserRateDesignation");

                entity.HasOne(d => d.Occurance)
                    .WithMany(p => p.UserRate)
                    .HasForeignKey(d => d.OccuranceId)
                    .HasConstraintName("UserRateOccurance");

                entity.HasOne(d => d.RateType)
                    .WithMany(p => p.UserRate)
                    .HasForeignKey(d => d.RateTypeId)
                    .HasConstraintName("UserRateTypeId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRate)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("UserRateId");
            });

            modelBuilder.Entity<UserRefrence>(entity =>
            {
                entity.HasIndex(e => e.DesignationId)
                    .HasName("UserRefrenceDesignation_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("UserRefrence_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SalutationId).HasColumnType("bigint unsigned");

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.UserRefrence)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("UserRefrenceDesignation");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRefrence)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("UserRefrence");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("Name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRoleCategory>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SalaryHeadId)
                    .HasName("UserRoleCategorySalaryHead_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryHeadId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.SalaryHead)
                    .WithMany(p => p.UserRoleCategory)
                    .HasForeignKey(d => d.SalaryHeadId)
                    .HasConstraintName("UserRoleCategorySalaryHead");
            });

            modelBuilder.Entity<UserRoleRules>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserSponsorshipCompany>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("UserSponsorshipCompanyBranch_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SponsorshipCompanyId)
                    .HasName("UserBranches_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("UserBranchUser_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDefaultSponsorshipCompany)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.SponsorshipCompanyId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.UserSponsorshipCompany)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("UserSponsorshipCompanyBranch");

                entity.HasOne(d => d.SponsorshipCompany)
                    .WithMany(p => p.UserSponsorshipCompany)
                    .HasForeignKey(d => d.SponsorshipCompanyId)
                    .HasConstraintName("UserBranches");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSponsorshipCompany)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("BranchUser");
            });

            modelBuilder.Entity<UserTransfer>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("UserTransferBranch_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("UserTransferUser_idx");

                entity.HasIndex(e => e.UserRoleId)
                    .HasName("UserTransferUserRole_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BranchId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsReTransfer)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.UserId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserRoleId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.UserTransfer)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("UserTransferBranch");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTransfer)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("UserTransferUser");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.UserTransfer)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("UserTransferUserRole");
            });

            modelBuilder.Entity<VisaSponsor>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VisaStatus>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.VisaStatus1)
                    .HasColumnName("VisaStatus")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VisaType>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.VisaType1)
                    .HasColumnName("VisaType")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmleadDocuments>(entity =>
            {
                entity.ToTable("CRMLeadDocuments");

                entity.HasIndex(e => e.AttachmentId)
                    .HasName("CRMLeadDocumentAttachment_idx");

                entity.HasIndex(e => e.DocumentTypeId)
                    .HasName("CRMLeadDocumentDocumentType_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.LeadId)
                    .HasName("CRMLeadDocumentsCRMLead_idx");

                entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttachmentId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeId).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.LeadId).HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.CrmleadDocuments)
                    .HasForeignKey(d => d.AttachmentId)
                    .HasConstraintName("CRMLeadDocumentAttachment");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.CrmleadDocuments)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("CRMLeadDocumentDocumentType");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.CrmleadDocuments)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("CRMLeadDocumentsCRMLead");
            });


            modelBuilder.Entity<feedback>(entity =>
            {
                entity.ToTable("feedback");

                entity.HasIndex(e => e.id)
                    .HasName("id_UNIQUE")
                    .IsUnique();


               //entity.Property(e => e.id).HasColumnType("bigint unsigned");

                entity.Property(e => e.name)
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.email)
                    .HasColumnName("email")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.message)
                    .HasColumnName("message")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                .HasColumnType("bit(1)")
                .HasDefaultValueSql("b'0'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
