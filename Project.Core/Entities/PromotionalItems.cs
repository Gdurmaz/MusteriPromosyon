using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Core.Entities
{
    [Table("tblPromosyon")]
    public class PromotionalItems
    {
        public PromotionalItems()
        {
            ListParticipants = new List<Participants>();
        }
        [Key,Column("ID"),DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PromotionalID { get; set; }
        [Column("PormosyonAdi"), StringLength(30)]
        public string PromotionalName { get; set; }
        [Column("Açiklama"), StringLength(100)]
        public string Description { get; set; }
        [Column("Tarih"), DataType(DataType.Date)]
        public DateTime CurrentDate { get; set; }
        [Column("Kullanildimi?")]
        public bool IsUsed { get; set; }
        public virtual List<Participants> ListParticipants { get; set; }
    }
}
