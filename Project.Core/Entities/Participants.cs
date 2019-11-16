using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Core.Entities
{
    [Table("tblKatilimcilar")]
    public class Participants
    {
        [Key,Column("KatilimciID"),DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParticipantID { get; set; }
        [Column("OlusturulmaTarihi")]
        public DateTime CreationDate { get; set; }
        public int customerID { get; set; }
        public int StoreID { get; set; }
        public int PromotionalItemsID { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
        public virtual PromotionalItems PromotionalItems { get; set; }
    }
}
