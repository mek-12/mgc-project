using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MGC.ENTITY.MTableRecord
{
    public class FilterRecord
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// Filtre tablosunun codunu tutar
        /// </summary>
        [Required]
        public string TableCode { get; set; }
        /// <summary>
        /// Fitrenin başlık bilgisi.
        /// </summary>
        [Required]
        public string DisplayName { get; set; }
        /// <summary>
        /// Fitre tablosunun tipini(adını) tutar
        /// </summary>
        [Required]
        public string TableType { get; set; }
        // Filtre tablosunun içerdiği property adını tutar.
        [Required]
        public string PropertyName { get; set; }
        /// <summary>
        /// Filtre tablosunu yabancı anahtar olarak tutan tablonun tipini tutar.
        /// </summary>
        [Required]
        public string IncludedTableType { get; set; }
        /// <summary>
        /// İlgili ürün tablosunun tipini(adını) tutan kaydı temsil ediyor.
        /// </summary>
        [Required]
        public Guid ProductRecordId { get; set; }

        [ForeignKey("ProductRecordId")]
        public ProductRecord ProductRecord { get; set; }
    }
}
