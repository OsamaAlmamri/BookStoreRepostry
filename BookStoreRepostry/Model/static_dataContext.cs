using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StaticData.Model
{
    public partial class static_dataContext : DbContext
    {
        public static_dataContext()
        {
        }

        public static_dataContext(DbContextOptions<static_dataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Beneficiaries> Beneficiaries { get; set; }
        public virtual DbSet<ClientTypes> ClientTypes { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Donors> Donors { get; set; }
        public virtual DbSet<FdbTypes> FdbTypes { get; set; }
        public virtual DbSet<Fdbs> Fdbs { get; set; }
        public virtual DbSet<GeoData> GeoData { get; set; }
        public virtual DbSet<Ips> Ips { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Migrations> Migrations { get; set; }
        public virtual DbSet<PersonCategories> PersonCategories { get; set; }
        public virtual DbSet<PersonalAccessTokens> PersonalAccessTokens { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<ProdigySystems> ProdigySystems { get; set; }
        public virtual DbSet<Programmes> Programmes { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Sectors> Sectors { get; set; }
        public virtual DbSet<SystemsUsers> SystemsUsers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\;Database=static_data;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beneficiaries>(entity =>
            {
                entity.ToTable("beneficiaries");

                entity.HasIndex(e => e.BeneficiaryCode)
                    .HasName("beneficiaries_beneficiary_code_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasMaxLength(355);

                entity.Property(e => e.BeneficiaryCode)
                    .HasColumnName("beneficiary_code")
                    .HasMaxLength(355);

                entity.Property(e => e.CellPhone)
                    .HasColumnName("cell_phone")
                    .HasMaxLength(50);

                entity.Property(e => e.CellPhone2)
                    .HasColumnName("cell_phone2")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreationMetadata)
                    .IsRequired()
                    .HasColumnName("creation_metadata");

                entity.Property(e => e.CurrentSiteId).HasColumnName("current_site_id");

                entity.Property(e => e.EMail)
                    .HasColumnName("e-mail")
                    .HasMaxLength(50);

                entity.Property(e => e.IdentityId)
                    .HasColumnName("identity_id")
                    .HasMaxLength(50);

                entity.Property(e => e.IdentityType)
                    .HasColumnName("identity_type")
                    .HasMaxLength(50);

                entity.Property(e => e.NameAr)
                    .HasColumnName("name_ar")
                    .HasMaxLength(350);

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasMaxLength(350);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.CurrentSite)
                    .WithMany(p => p.Beneficiaries)
                    .HasForeignKey(d => d.CurrentSiteId)
                    .HasConstraintName("beneficiaries_current_site_id_foreign");
            });

            modelBuilder.Entity<ClientTypes>(entity =>
            {
                entity.ToTable("client_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.TitleAr)
                    .HasColumnName("title_ar")
                    .HasMaxLength(350);

                entity.Property(e => e.TitleEn)
                    .HasColumnName("title_en")
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.ToTable("clients");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientTypeId).HasColumnName("client_type_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.TitleAr)
                    .HasColumnName("title_ar")
                    .HasMaxLength(350);

                entity.Property(e => e.TitleEn)
                    .HasColumnName("title_en")
                    .HasMaxLength(350);

                entity.HasOne(d => d.ClientType)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ClientTypeId)
                    .HasConstraintName("clients_client_type_id_foreign");
            });

            modelBuilder.Entity<Donors>(entity =>
            {
                entity.ToTable("donors");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.NameAr)
                    .HasColumnName("name_ar")
                    .HasMaxLength(350);

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasMaxLength(350);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('1')");
            });

            modelBuilder.Entity<FdbTypes>(entity =>
            {
                entity.ToTable("FDB_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.TitleAr)
                    .HasColumnName("title_ar")
                    .HasMaxLength(350);

                entity.Property(e => e.TitleEn)
                    .HasColumnName("title_en")
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<Fdbs>(entity =>
            {
                entity.ToTable("FDBs");

                entity.HasIndex(e => e.FdpCode)
                    .HasName("fdbs_fdp_code_unique")
                    .IsUnique();

                entity.HasIndex(e => e.ProdigyCode)
                    .HasName("fdbs_prodigy_code_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasMaxLength(355);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreationMetadata)
                    .IsRequired()
                    .HasColumnName("creation_metadata");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Elevation)
                    .HasColumnName("elevation")
                    .HasMaxLength(50);

                entity.Property(e => e.FdpCode)
                    .IsRequired()
                    .HasColumnName("FDP_code")
                    .HasMaxLength(50);

                entity.Property(e => e.FdpTypeId).HasColumnName("fdp_type_id");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("decimal(10, 8)");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("decimal(11, 8)");

                entity.Property(e => e.ProdigyCode)
                    .HasColumnName("prodigy_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ShortName)
                    .HasColumnName("short_name")
                    .HasMaxLength(350);

                entity.Property(e => e.SiteId).HasColumnName("site_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TitleAr)
                    .HasColumnName("title_ar")
                    .HasMaxLength(350);

                entity.Property(e => e.TitleEn)
                    .HasColumnName("title_en")
                    .HasMaxLength(350);

                entity.HasOne(d => d.FdpType)
                    .WithMany(p => p.Fdbs)
                    .HasForeignKey(d => d.FdpTypeId)
                    .HasConstraintName("fdbs_fdp_type_id_foreign");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Fdbs)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("fdbs_site_id_foreign");
            });

            modelBuilder.Entity<GeoData>(entity =>
            {
                entity.HasKey(e => e.SiteId)
                    .HasName("PK__geo_data__EAF19B5979E1E08F");

                entity.ToTable("geo_data");

                entity.HasIndex(e => e.CountryId)
                    .HasName("geo_data_countryid_index");

                entity.HasIndex(e => e.ParentCode)
                    .HasName("geo_data_parentcode_index");

                entity.HasIndex(e => e.ParentId)
                    .HasName("geo_data_parentid_index");

                entity.HasIndex(e => e.PlaceCode)
                    .HasName("geo_data_place_code_index");

                entity.HasIndex(e => e.SiteCode)
                    .HasName("geo_data_sitecode_index");

                entity.Property(e => e.SiteId).HasColumnName("siteID");

                entity.Property(e => e.ArName)
                    .HasColumnName("Ar_Name")
                    .HasMaxLength(350);

                entity.Property(e => e.CountryId).HasColumnName("countryID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnName)
                    .HasColumnName("En_Name")
                    .HasMaxLength(350);

                entity.Property(e => e.Isparent).HasColumnName("ISParent");

                entity.Property(e => e.ParentCode).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PlaceCode)
                    .HasColumnName("Place_Code")
                    .HasMaxLength(350);

                entity.Property(e => e.SiteCode)
                    .IsRequired()
                    .HasColumnName("siteCode")
                    .HasMaxLength(355);

                entity.Property(e => e.SiteLevel).HasColumnName("siteLevel");
            });

            modelBuilder.Entity<Ips>(entity =>
            {
                entity.ToTable("IPs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.NameAr)
                    .HasColumnName("name_ar")
                    .HasMaxLength(350);

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasMaxLength(350);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('1')");
            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.ToTable("logs");

                entity.HasIndex(e => e.EntityId)
                    .HasName("logs_entity_id_index");

                entity.HasIndex(e => e.EntityType)
                    .HasName("logs_entity_type_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.EntityType)
                    .IsRequired()
                    .HasColumnName("entity_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<Migrations>(entity =>
            {
                entity.ToTable("migrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Migration)
                    .IsRequired()
                    .HasColumnName("migration")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PersonCategories>(entity =>
            {
                entity.ToTable("person_categories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.TitleAr)
                    .HasColumnName("title_ar")
                    .HasMaxLength(350);

                entity.Property(e => e.TitleEn)
                    .HasColumnName("title_en")
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<PersonalAccessTokens>(entity =>
            {
                entity.ToTable("personal_access_tokens");

                entity.HasIndex(e => e.Token)
                    .HasName("personal_access_tokens_token_unique")
                    .IsUnique();

                entity.HasIndex(e => new { e.TokenableType, e.TokenableId })
                    .HasName("personal_access_tokens_tokenable_type_tokenable_id_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abilities).HasColumnName("abilities");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUsedAt)
                    .HasColumnName("last_used_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasMaxLength(64);

                entity.Property(e => e.TokenableId).HasColumnName("tokenable_id");

                entity.Property(e => e.TokenableType)
                    .IsRequired()
                    .HasColumnName("tokenable_type")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.ToTable("persons");

                entity.HasIndex(e => e.BeneficiaryCode)
                    .HasName("persons_beneficiary_code_index");

                entity.HasIndex(e => e.PersonCode)
                    .HasName("persons_person_code_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasMaxLength(355);

                entity.Property(e => e.BeneficiaryCode)
                    .HasColumnName("beneficiary_code")
                    .HasMaxLength(355);

                entity.Property(e => e.CellPhone)
                    .HasColumnName("cell_phone")
                    .HasMaxLength(50);

                entity.Property(e => e.CellPhone2)
                    .HasColumnName("cell_phone2")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreationMetadata)
                    .IsRequired()
                    .HasColumnName("creation_metadata");

                entity.Property(e => e.CurrentSiteId).HasColumnName("current_site_id");

                entity.Property(e => e.EMail)
                    .HasColumnName("e-mail")
                    .HasMaxLength(50);

                entity.Property(e => e.IdentityId)
                    .HasColumnName("identity_id")
                    .HasMaxLength(50);

                entity.Property(e => e.IdentityType)
                    .HasColumnName("identity_type")
                    .HasMaxLength(50);

                entity.Property(e => e.NameAr)
                    .HasColumnName("name_ar")
                    .HasMaxLength(350);

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasMaxLength(350);

                entity.Property(e => e.PersonCategoryId).HasColumnName("person_category_id");

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(355);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.CurrentSite)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.CurrentSiteId)
                    .HasConstraintName("persons_current_site_id_foreign");

                entity.HasOne(d => d.PersonCategory)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.PersonCategoryId)
                    .HasConstraintName("persons_person_category_id_foreign");
            });

            modelBuilder.Entity<ProdigySystems>(entity =>
            {
                entity.ToTable("prodigy_systems");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DevelopmentTeam).HasColumnName("development_team");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<Programmes>(entity =>
            {
                entity.ToTable("programmes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.NameAr)
                    .HasColumnName("name_ar")
                    .HasMaxLength(350);

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasMaxLength(350);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('1')");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.ToTable("projects");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.NameAr)
                    .HasColumnName("name_ar")
                    .HasMaxLength(350);

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasMaxLength(350);

                entity.Property(e => e.ProgrammeId).HasColumnName("programme_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('1')");

                entity.HasOne(d => d.Programme)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ProgrammeId)
                    .HasConstraintName("projects_programme_id_foreign");
            });

            modelBuilder.Entity<Sectors>(entity =>
            {
                entity.ToTable("sectors");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.NameAr)
                    .HasColumnName("name_ar")
                    .HasMaxLength(350);

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasMaxLength(350);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('1')");
            });

            modelBuilder.Entity<SystemsUsers>(entity =>
            {
                entity.ToTable("systems_users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(350);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.System)
                    .WithMany(p => p.SystemsUsers)
                    .HasForeignKey(d => d.SystemId)
                    .HasConstraintName("systems_users_system_id_foreign");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Email)
                    .HasName("users_email_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("('1')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
