using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EdGradAssist.Models.Entities
{
    public partial class GRADAD_DBContext : DbContext
    {
        public GRADAD_DBContext()
        {
        }

        public GRADAD_DBContext(DbContextOptions<GRADAD_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Budget> Budget { get; set; }
        public virtual DbSet<Concentration> Concentration { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Criteria> Criteria { get; set; }
        public virtual DbSet<Degree> Degree { get; set; }
        public virtual DbSet<Gauser> Gauser { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<ReviewCriteria> ReviewCriteria { get; set; }
        public virtual DbSet<Score> Score { get; set; }
        public virtual DbSet<ScoreType> ScoreType { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentCourse> StudentCourse { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=GRADAD_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressId)
                    .HasColumnName("AddressID")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Street1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Street2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FolderNumNavigation)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.FolderNum)
                    .HasConstraintName("FK__Address__FolderN__412EB0B6");
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.HasKey(e => e.FolderNum);

                entity.Property(e => e.FolderNum).ValueGeneratedNever();

                entity.Property(e => e.ApplicationDate).HasColumnType("date");

                entity.Property(e => e.ConcentrationId).HasColumnName("ConcentrationID");

                entity.Property(e => e.Enum)
                    .HasColumnName("ENum")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.HasOne(d => d.Concentration)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.ConcentrationId)
                    .HasConstraintName("FK__Applicati__Conce__3D5E1FD2");

                entity.HasOne(d => d.EnumNavigation)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.Enum)
                    .HasConstraintName("FK__Applicatio__ENum__3C69FB99");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK__Applicati__JobID__3E52440B");
            });

            modelBuilder.Entity<Budget>(entity =>
            {
                entity.Property(e => e.BudgetId)
                    .HasColumnName("BudgetID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Year).HasColumnType("date");
            });

            modelBuilder.Entity<Concentration>(entity =>
            {
                entity.Property(e => e.ConcentrationId)
                    .HasColumnName("ConcentrationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConcentrationDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.EtsucourseId);

                entity.Property(e => e.EtsucourseId)
                    .HasColumnName("ETSUCourseID")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ConcentrationId).HasColumnName("ConcentrationID");

                entity.Property(e => e.CourseStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CourseTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Concentration)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.ConcentrationId)
                    .HasConstraintName("FK__Course__Concentr__2D27B809");
            });

            modelBuilder.Entity<Criteria>(entity =>
            {
                entity.Property(e => e.CriteriaId)
                    .HasColumnName("CriteriaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConcentrationId).HasColumnName("ConcentrationID");

                entity.Property(e => e.CriteriaDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CriteriaDisplayOrder)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CriteriaStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Concentration)
                    .WithMany(p => p.Criteria)
                    .HasForeignKey(d => d.ConcentrationId)
                    .HasConstraintName("FK__Criteria__Concen__2A4B4B5E");
            });

            modelBuilder.Entity<Degree>(entity =>
            {
                entity.Property(e => e.DegreeId)
                    .HasColumnName("DegreeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Degree1)
                    .HasColumnName("Degree")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enum)
                    .HasColumnName("ENum")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Gpa)
                    .HasColumnName("GPA")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Graduated)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GraduationDate).HasColumnType("date");

                entity.Property(e => e.Institution)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Major)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.EnumNavigation)
                    .WithMany(p => p.Degree)
                    .HasForeignKey(d => d.Enum)
                    .HasConstraintName("FK__Degree__ENum__35BCFE0A");
            });

            modelBuilder.Entity<Gauser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("GAUser");

                entity.HasIndex(e => e.Useremail)
                    .HasName("UQ__GAUser__5D9EAE2DA2DFD8AF")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Useremail)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.JobId)
                    .HasColumnName("JobID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BudgetAllocation).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Building)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Professor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.ReviewId)
                    .HasColumnName("ReviewID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.FolderNumNavigation)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.FolderNum)
                    .HasConstraintName("FK__Review__FolderNu__440B1D61");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Review__UserID__44FF419A");
            });

            modelBuilder.Entity<ReviewCriteria>(entity =>
            {
                entity.HasKey(e => new { e.CriteriaId, e.ReviewId });

                entity.Property(e => e.CriteriaId).HasColumnName("CriteriaID");

                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.CriteriaComment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CriteriaScore)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Criteria)
                    .WithMany(p => p.ReviewCriteria)
                    .HasForeignKey(d => d.CriteriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReviewCri__Crite__47DBAE45");

                entity.HasOne(d => d.Review)
                    .WithMany(p => p.ReviewCriteria)
                    .HasForeignKey(d => d.ReviewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReviewCri__Revie__48CFD27E");
            });

            modelBuilder.Entity<Score>(entity =>
            {
                entity.Property(e => e.ScoreId)
                    .HasColumnName("ScoreID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Score1).HasColumnName("Score");

                entity.Property(e => e.ScoreTypeId).HasColumnName("ScoreTypeID");

                entity.HasOne(d => d.FolderNumNavigation)
                    .WithMany(p => p.Score)
                    .HasForeignKey(d => d.FolderNum)
                    .HasConstraintName("FK__Score__FolderNum__4BAC3F29");

                entity.HasOne(d => d.ScoreType)
                    .WithMany(p => p.Score)
                    .HasForeignKey(d => d.ScoreTypeId)
                    .HasConstraintName("FK__Score__ScoreType__4CA06362");
            });

            modelBuilder.Entity<ScoreType>(entity =>
            {
                entity.Property(e => e.ScoreTypeId)
                    .HasColumnName("ScoreTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ScoreTypeDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Enum);

                entity.Property(e => e.Enum)
                    .HasColumnName("ENum")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mname)
                    .HasColumnName("MName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(e => new { e.EtsucourseId, e.Enum });

                entity.Property(e => e.EtsucourseId)
                    .HasColumnName("ETSUCourseID")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Enum)
                    .HasColumnName("ENum")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CourseGrade).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CourseTerm)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.EnumNavigation)
                    .WithMany(p => p.StudentCourse)
                    .HasForeignKey(d => d.Enum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StudentCou__ENum__32E0915F");

                entity.HasOne(d => d.Etsucourse)
                    .WithMany(p => p.StudentCourse)
                    .HasForeignKey(d => d.EtsucourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StudentCo__ETSUC__31EC6D26");
            });
        }
    }
}
