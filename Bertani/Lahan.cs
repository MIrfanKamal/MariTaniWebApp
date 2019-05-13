namespace Bertani
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lahan")]
    public partial class Lahan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Komoditas { get; set; }

        public decimal LuasLahan { get; set; }

        public int JumlahTanaman { get; set; }

        public DateTime TanggalTanam { get; set; }

        public decimal? HargaBibit { get; set; }

        public decimal? HargaPerawatan { get; set; }
    }
}
