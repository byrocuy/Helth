namespace Helth
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JadwalDB")]
    public partial class JadwalDB
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Jadwal { get; set; }

        [Required]
        [StringLength(20)]
        public string Jam { get; set; }

        [Column("Hari/Tanggal")]
        [Required]
        [StringLength(50)]
        public string Hari_Tanggal { get; set; }

        [Required]
        [StringLength(200)]
        public string Lokasi { get; set; }

        [Required]
        [StringLength(300)]
        public string Deskripsi { get; set; }
    }
}
