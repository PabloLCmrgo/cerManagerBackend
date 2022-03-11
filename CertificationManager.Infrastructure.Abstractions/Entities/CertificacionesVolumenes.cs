namespace CertificationManager.Infrastructure.Abstractions.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CertificacionesVolumenes : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cod { get; set; }

        [StringLength(75)]
        public string den { get; set; }

        [StringLength(80)]
        public string dom { get; set; }

        [StringLength(50)]
        public string col { get; set; }

        [StringLength(50)]
        public string del { get; set; }

        [StringLength(50)]
        public string ciu { get; set; }

        [StringLength(50)]
        public string est { get; set; }

        [StringLength(30)]
        public string tel { get; set; }

        [StringLength(30)]
        public string fax { get; set; }

        [StringLength(16)]
        public string rfc { get; set; }

        public byte? tipval { get; set; }

        public double? mtoasg { get; set; }

        public double? mtodis { get; set; }

        public double? mtorep { get; set; }

        public short? cndpag { get; set; }

        public short? diarev { get; set; }

        [StringLength(15)]
        public string horrev { get; set; }

        public short? diapag { get; set; }

        [StringLength(15)]
        public string horpag { get; set; }

        [StringLength(50)]
        public string cto { get; set; }

        [Column(TypeName = "text")]
        public string obs { get; set; }

        [StringLength(10)]
        public string codext { get; set; }

        public int? datcon { get; set; }

        [StringLength(10)]
        public string codpos { get; set; }

        public byte? pto { get; set; }

        public double? ptosdo { get; set; }

        public double? debsdo { get; set; }

        public double? cresdo { get; set; }

        public int? fmtexp { get; set; }

        [StringLength(30)]
        public string arcexp { get; set; }
    }
}
