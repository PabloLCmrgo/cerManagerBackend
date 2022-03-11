using CertificationManager.Infrastructure.Abstractions.Entities;
using CertificationManager.Infrastructure.Abstractions.Entities.SPs;
using Microsoft.EntityFrameworkCore;

namespace CertificationManager.Infrastructure.Data.DBContexts
{
    public partial class SGDObrasContext : DbContext
    {
        public SGDObrasContext(DbContextOptions<SGDObrasContext> options)
            : base(options)
        {
        }


        public virtual DbSet<CertificacionesVolumenes> CertificacionesVolumenes { get; set; }

        public virtual DbSet<ResponseUspWebCertificacionesVolumenesPagoDetallesObtener> UspWebCertificacionesVolumenesPagoDetallesObtener { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.den)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.dom)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.col)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.del)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.ciu)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.est)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.rfc)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.horrev)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.horpag)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.cto)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.obs)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.codext)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.codpos)
                .IsUnicode(false);

            modelBuilder.Entity<CertificacionesVolumenes>()
                .Property(e => e.arcexp)
                .IsUnicode(false);
        }
    }
}
