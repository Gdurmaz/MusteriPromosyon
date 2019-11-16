using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Core.Entities
{
    [Table("tblMusteriler")]
    public class Customer
    {
        public Customer()
        {
            ListParticipants = new List<Participants>();
        }
        private int ID;
        [Key,Column("MusteriID"),DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID
        {
            get { return ID; }
            set { ID = value; }
        }
        [Column("TCKN"),Required,StringLength(11)]
        public string CustomerIdentity { get; set; }
        [Column("MusteriAdi"), Required,StringLength(25)]
        public string CustomerName { get; set; }
        [Column("MusteriSoyadi"), Required, StringLength(25)]
        public string CustomerSurName { get; set; }
        [Column("DogumTarihi"), Required]
        public DateTime CustomerDateOFBirth { get; set; }
        [Column("Cinsiyet"),DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? CustomerGender { get; set; }
        [Column("MusteriIş"),DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? CustomerJob { get; set; }
        [Column("Email"), Required]
        public string CustomerEmail { get; set; }
        [Column("Telefon"), Required]
        public string CustomerPhone { get; set; }
        [Column("EmailBildirim")]
        public bool NotificationAcceptForMail { get; set; }
        [Column("TelefonBildirim")]
        public bool NotificationAcceptForPhone { get; set; }
        [Column("OlusturulmaTarihi")]
        public DateTime? CreationDate { get; set; }
        [Column("MagazaID")]
        public int StoreID { get; set; }
        public List<Participants> ListParticipants{ get; set; }
    }
}
