using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Core.Entities
{
    [Table("tblMagazalar")]
    public class Store
    {
        public Store()
        {
            ListParticipants = new List<Participants>();
        }
        private int storeID;
        [Key,Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID
        {
            get { return storeID; }
            set { storeID = value; }
        }
        [Column("MagazaAdi"), StringLength(30)]
        public string StoreName { get; set; }
        [Column("MagazaAdres"), StringLength(25)]
        public string StoreAdress { get; set; }
        [Column("MagazaYonetici"), StringLength(30)]
        public string StoreManager { get; set; }
        [Column("KullaniciAdi"), StringLength(30)]
        public string UserName { get; set; }
        [Column("Sifre"), StringLength(30),DataType(DataType.Password)]
        public string UserPassword { get; set; }
        public virtual List<Participants> ListParticipants { get; set; }
    }
}
