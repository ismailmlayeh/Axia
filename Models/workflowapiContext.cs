using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace webapiworkflow.Models
{
    public partial class workflowapiContext : DbContext
    {
        public workflowapiContext()
        {
        }

        public workflowapiContext(DbContextOptions<workflowapiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aspnetroleclaims> Aspnetroleclaims { get; set; }
        public virtual DbSet<Aspnetroles> Aspnetroles { get; set; }
        public virtual DbSet<Aspnetuserclaims> Aspnetuserclaims { get; set; }
        public virtual DbSet<Aspnetuserlogins> Aspnetuserlogins { get; set; }
        public virtual DbSet<Aspnetuserroles> Aspnetuserroles { get; set; }
        public virtual DbSet<Aspnetusers> Aspnetusers { get; set; }
        public virtual DbSet<AspnetusersHasRolelist> AspnetusersHasRolelist { get; set; }
        public virtual DbSet<Aspnetusertokens> Aspnetusertokens { get; set; }
        public virtual DbSet<Calendar> Calendar { get; set; }
        public virtual DbSet<Condition> Condition { get; set; }
        public virtual DbSet<Conditionvalue> Conditionvalue { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Domain> Domain { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Rolelist> Rolelist { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<Taskbasket> Taskbasket { get; set; }
        public virtual DbSet<Workflow> Workflow { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=root;database=workflowapi", x => x.ServerVersion("8.0.23-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aspnetroleclaims>(entity =>
            {
                entity.ToTable("aspnetroleclaims");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.ClaimType)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ClaimValue)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetroleclaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
            });

            modelBuilder.Entity<Aspnetroles>(entity =>
            {
                entity.ToTable("aspnetroles");

                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ConcurrencyStamp)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NormalizedName)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Aspnetuserclaims>(entity =>
            {
                entity.ToTable("aspnetuserclaims");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserClaims_UserId");

                entity.Property(e => e.ClaimType)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ClaimValue)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserclaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserlogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("aspnetuserlogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProviderKey)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProviderDisplayName)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserlogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserroles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("aspnetuserroles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetUserRoles_RoleId");

                entity.Property(e => e.UserId)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.RoleId)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetusers>(entity =>
            {
                entity.ToTable("aspnetusers");

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ConcurrencyStamp)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Idrole).HasColumnName("idrole");

                entity.Property(e => e.NormalizedEmail)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NormalizedUserName)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PasswordHash)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SecurityStamp)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserName)
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<AspnetusersHasRolelist>(entity =>
            {
                entity.HasKey(e => new { e.AspnetusersId, e.RolelistId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("aspnetusers_has_rolelist");

                entity.HasIndex(e => e.AspnetusersId)
                    .HasName("fk_aspnetusers_has_rolelist_aspnetusers1_idx");

                entity.HasIndex(e => e.RolelistId)
                    .HasName("fk_aspnetusers_has_rolelist_rolelist1_idx");

                entity.Property(e => e.AspnetusersId)
                    .HasColumnName("aspnetusers_Id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.RolelistId).HasColumnName("rolelist_id");

                entity.HasOne(d => d.Aspnetusers)
                    .WithMany(p => p.AspnetusersHasRolelist)
                    .HasForeignKey(d => d.AspnetusersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aspnetusers_has_rolelist_aspnetusers1");

                entity.HasOne(d => d.Rolelist)
                    .WithMany(p => p.AspnetusersHasRolelist)
                    .HasForeignKey(d => d.RolelistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aspnetusers_has_rolelist_rolelist1");
            });

            modelBuilder.Entity<Aspnetusertokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("aspnetusertokens");

                entity.Property(e => e.UserId)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LoginProvider)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Value)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetusertokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.Idcalendar)
                    .HasName("PRIMARY");

                entity.ToTable("calendar");

                entity.HasIndex(e => e.Idtask)
                    .HasName("idtask1_idx");

                entity.Property(e => e.Idcalendar).HasColumnName("idcalendar");

                entity.Property(e => e.Idtask).HasColumnName("idtask");

                entity.HasOne(d => d.IdtaskNavigation)
                    .WithMany(p => p.Calendar)
                    .HasForeignKey(d => d.Idtask)
                    .HasConstraintName("idtask1");
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.HasKey(e => e.Idcondition)
                    .HasName("PRIMARY");

                entity.ToTable("condition");

                entity.HasIndex(e => e.Idtask)
                    .HasName("idtask_idx");

                entity.HasIndex(e => e.Iduser)
                    .HasName("iduser1_idx");

                entity.HasIndex(e => e.Idworkflow)
                    .HasName("idworkflow2_idx");

                entity.Property(e => e.Idcondition).HasColumnName("idcondition");

                entity.Property(e => e.ConditionFactor)
                    .HasColumnName("condition_factor")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ConditionTitle)
                    .HasColumnName("condition_title")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Conditionvalue).HasColumnName("conditionvalue");

                entity.Property(e => e.Iddocument).HasColumnName("iddocument");

                entity.Property(e => e.Iddomain).HasColumnName("iddomain");

                entity.Property(e => e.Idtask).HasColumnName("idtask");

                entity.Property(e => e.Iduser)
                    .HasColumnName("iduser")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Idworkflow).HasColumnName("idworkflow");

                entity.Property(e => e.Requete)
                    .HasColumnName("requete")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdtaskNavigation)
                    .WithMany(p => p.Condition)
                    .HasForeignKey(d => d.Idtask)
                    .HasConstraintName("idtask");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Condition)
                    .HasForeignKey(d => d.Iduser)
                    .HasConstraintName("iduser1");

                entity.HasOne(d => d.IdworkflowNavigation)
                    .WithMany(p => p.Condition)
                    .HasForeignKey(d => d.Idworkflow)
                    .HasConstraintName("idworkflow2");
            });

            modelBuilder.Entity<Conditionvalue>(entity =>
            {
                entity.HasKey(e => e.Idconditionvalue)
                    .HasName("PRIMARY");

                entity.ToTable("conditionvalue");

                entity.Property(e => e.Idconditionvalue).HasColumnName("idconditionvalue");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.Iddocument)
                    .HasName("PRIMARY");

                entity.ToTable("document");

                entity.HasIndex(e => e.Iddomain)
                    .HasName("iddomain_idx");

                entity.Property(e => e.Iddocument).HasColumnName("iddocument");

                entity.Property(e => e.Iddomain).HasColumnName("iddomain");

                entity.Property(e => e.Mantant).HasColumnName("mantant");

                entity.Property(e => e.Range).HasColumnName("range");

                entity.Property(e => e.Referance)
                    .HasColumnName("referance")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IddomainNavigation)
                    .WithMany(p => p.Document)
                    .HasForeignKey(d => d.Iddomain)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("iddomain");
            });

            modelBuilder.Entity<Domain>(entity =>
            {
                entity.HasKey(e => e.Iddomain)
                    .HasName("PRIMARY");

                entity.ToTable("domain");

                entity.Property(e => e.Iddomain).HasColumnName("iddomain");

                entity.Property(e => e.DomainDescription)
                    .HasColumnName("domain_description")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DomainTitle)
                    .HasColumnName("domain_title")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId)
                    .HasColumnType("varchar(95)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasKey(e => e.Idnotification)
                    .HasName("PRIMARY");

                entity.ToTable("notification");

                entity.Property(e => e.Idnotification).HasColumnName("idnotification");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Rolelist>(entity =>
            {
                entity.ToTable("rolelist");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.Idtask)
                    .HasName("PRIMARY");

                entity.ToTable("task");

                entity.HasIndex(e => e.Idconditionvalue)
                    .HasName("idcvalue_idx");

                entity.HasIndex(e => e.Iduser)
                    .HasName("iduser_idx");

                entity.HasIndex(e => e.Idworkflow)
                    .HasName("idworkflow_idx");

                entity.Property(e => e.Idtask).HasColumnName("idtask");

                entity.Property(e => e.Attachement)
                    .HasColumnName("attachement")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Begin)
                    .HasColumnName("begin")
                    .HasColumnType("date");

                entity.Property(e => e.Deadline)
                    .HasColumnName("deadline")
                    .HasColumnType("date");

                entity.Property(e => e.Idconditionvalue).HasColumnName("idconditionvalue");

                entity.Property(e => e.Iduser)
                    .HasColumnName("iduser")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Idworkflow).HasColumnName("idworkflow");

                entity.Property(e => e.TaskStatus)
                    .HasColumnName("task_status")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TaskTitle)
                    .HasColumnName("task_title")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdconditionvalueNavigation)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.Idconditionvalue)
                    .HasConstraintName("idcvalue");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.Iduser)
                    .HasConstraintName("iduser");

                entity.HasOne(d => d.IdworkflowNavigation)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.Idworkflow)
                    .HasConstraintName("idworkflow");
            });

            modelBuilder.Entity<Taskbasket>(entity =>
            {
                entity.HasKey(e => e.Idtaskbasket)
                    .HasName("PRIMARY");

                entity.ToTable("taskbasket");

                entity.HasIndex(e => e.Idtask)
                    .HasName("idtask2_idx");

                entity.Property(e => e.Idtaskbasket).HasColumnName("idtaskbasket");

                entity.Property(e => e.Idtask).HasColumnName("idtask");

                entity.HasOne(d => d.IdtaskNavigation)
                    .WithMany(p => p.Taskbasket)
                    .HasForeignKey(d => d.Idtask)
                    .HasConstraintName("idtask2");
            });

            modelBuilder.Entity<Workflow>(entity =>
            {
                entity.HasKey(e => e.Idworkflow)
                    .HasName("PRIMARY");

                entity.ToTable("workflow");

                entity.HasIndex(e => e.Iddocument)
                    .HasName("iddocument_idx");

                entity.Property(e => e.Idworkflow).HasColumnName("idworkflow");

                entity.Property(e => e.Iddocument).HasColumnName("iddocument");

                entity.Property(e => e.WorkflowTitle)
                    .HasColumnName("workflow_title")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IddocumentNavigation)
                    .WithMany(p => p.Workflow)
                    .HasForeignKey(d => d.Iddocument)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("iddocument");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
