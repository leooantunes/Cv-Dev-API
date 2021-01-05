using Microsoft.EntityFrameworkCore;

namespace Data.Entidades
{
    public partial class ContextDB : DbContext
    {
        public ContextDB()
        {
        }

        public ContextDB(DbContextOptions<ContextDB> options)
            : base(options)
        {
        }

        public virtual DbSet<Experiencia> Experiencia { get; set; }
        public virtual DbSet<Redesocial> Redesocial { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<Tiposkill> Tiposkill { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Experiencia>(entity =>
            {
                entity.HasKey(e => e.IdExperiencia)
                    .HasName("PRIMARY");

                entity.ToTable("experiencia");

                entity.HasIndex(e => e.IdExperiencia)
                    .HasName("idExperiencia_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserIdUser)
                    .HasName("fk_Experiencia_User1_idx");

                entity.Property(e => e.IdExperiencia)
                    .HasColumnName("idExperiencia")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Entrada)
                    .HasColumnName("entrada")
                    .HasColumnType("date");

                entity.Property(e => e.NomeEmpresa)
                    .IsRequired()
                    .HasColumnName("nomeEmpresa")
                    .HasMaxLength(100);

                entity.Property(e => e.Saida)
                    .HasColumnName("saida")
                    .HasColumnType("date");

                entity.Property(e => e.UserIdUser)
                    .HasColumnName("User_idUser")
                    .HasColumnType("int unsigned");

                entity.HasOne(d => d.UserIdUserNavigation)
                    .WithMany(p => p.Experiencia)
                    .HasForeignKey(d => d.UserIdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Experiencia_User1");
            });

            modelBuilder.Entity<Redesocial>(entity =>
            {
                entity.HasKey(e => e.IdRedeSocial)
                    .HasName("PRIMARY");

                entity.ToTable("redesocial");

                entity.HasIndex(e => e.IdRedeSocial)
                    .HasName("idRedeSocial_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserIdUser)
                    .HasName("fk_RedeSocial_User_idx");

                entity.Property(e => e.IdRedeSocial)
                    .HasColumnName("idRedeSocial")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(45);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(100);

                entity.Property(e => e.UserIdUser)
                    .HasColumnName("User_idUser")
                    .HasColumnType("int unsigned");

                entity.HasOne(d => d.UserIdUserNavigation)
                    .WithMany(p => p.Redesocial)
                    .HasForeignKey(d => d.UserIdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_RedeSocial_User");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasKey(e => e.IdSkill)
                    .HasName("PRIMARY");

                entity.ToTable("skill");

                entity.HasIndex(e => e.IdSkill)
                    .HasName("idSkill_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.TipoSkillIdTipoSkill)
                    .HasName("fk_Skill_TipoSkill1_idx");

                entity.HasIndex(e => e.UserIdUser)
                    .HasName("fk_Skill_User1_idx");

                entity.Property(e => e.IdSkill)
                    .HasColumnName("idSkill")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Nivel).HasColumnName("nivel");

                entity.Property(e => e.TipoSkillIdTipoSkill)
                    .HasColumnName("TipoSkill_idTipoSkill")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserIdUser)
                    .HasColumnName("User_idUser")
                    .HasColumnType("int unsigned");

                entity.HasOne(d => d.TipoSkillIdTipoSkillNavigation)
                    .WithMany(p => p.Skill)
                    .HasForeignKey(d => d.TipoSkillIdTipoSkill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Skill_TipoSkill1");

                entity.HasOne(d => d.UserIdUserNavigation)
                    .WithMany(p => p.Skill)
                    .HasForeignKey(d => d.UserIdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Skill_User1");
            });

            modelBuilder.Entity<Tiposkill>(entity =>
            {
                entity.HasKey(e => e.IdTipoSkill)
                    .HasName("PRIMARY");

                entity.ToTable("tiposkill");

                entity.HasIndex(e => e.IdTipoSkill)
                    .HasName("idTipoSkill_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdTipoSkill)
                    .HasColumnName("idTipoSkill")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PRIMARY");

                entity.ToTable("user");

                entity.HasIndex(e => e.IdUser)
                    .HasName("idUser_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdUser)
                    .HasColumnName("idUser")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(45);

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(500);

                entity.Property(e => e.Idade)
                    .HasColumnName("idade")
                    .HasColumnType("date");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(45);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("userName")
                    .HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
