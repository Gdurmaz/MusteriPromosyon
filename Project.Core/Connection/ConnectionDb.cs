using System.Data.Entity;
using Project.Core.Entities;

namespace Project.Core.Connection
{
    public class ConnectionDb:DbContext
    {
        public ConnectionDb():base("Db1")
        {
            Database.SetInitializer(new Initializer());
        }
        public  DbSet<Customer>   TableCustomer { get; set; }
        public  DbSet<PromotionalItems> TablePromotionalItems { get; set; }
        public  DbSet<Participants> TableParticipants { get; set; }
        public  DbSet<Store> TableStores { get; set; }
    }
}
