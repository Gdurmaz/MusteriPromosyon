using System;
using System.Data.Entity;
using System.Collections.Generic;

namespace Project.Core.Connection
{
    public class Initializer : CreateDatabaseIfNotExists<Connection.ConnectionDb>
    {
        protected override void Seed(ConnectionDb context)
        {
            try
            {
                Entities.Store store1 = new Entities.Store()
                {
                    StoreName = "AVM-1",
                    StoreAdress = "Abc mah.A sokak",
                    StoreManager = "OrnYönetici1",
                    UserName = "yonetici1@hot.com",
                    UserPassword = "12345"
                };
                Entities.Store store2 = new Entities.Store()
                {
                    StoreName = "AVM-2",
                    StoreAdress = "Cba mah.b sokak",
                    StoreManager = "OrnYönetici2",
                    UserName = "yonetici2@hot.com",
                    UserPassword = "123456"
                };
                context.TableStores.Add(store1);
                context.TableStores.Add(store2);

                context.SaveChanges();
                Entities.PromotionalItems promotional1 = new Entities.PromotionalItems()
                {
                    PromotionalName = "%25",
                    Description = "Tüm Mağalazarda indirim",
                    CurrentDate = Convert.ToDateTime("12.12.2019"),
                    IsUsed = false
                };
                Entities.PromotionalItems promotional2 = new Entities.PromotionalItems()
                {
                    PromotionalName = "%15",
                    Description = "Tüm Mağalazarda indirim",
                    CurrentDate = Convert.ToDateTime("01.12.01"),
                    IsUsed = false
                };
                Entities.PromotionalItems promotional3 = new Entities.PromotionalItems()
                {
                    PromotionalName = "%23",
                    Description = "Tüm Mağalazarda indirim",
                    CurrentDate = Convert.ToDateTime("04.12.2019"),
                    IsUsed = false
                };
                Entities.PromotionalItems promotional4 = new Entities.PromotionalItems()
                {
                    PromotionalName = "%34",
                    Description = "Tüm Mağalazarda indirim",
                    CurrentDate = Convert.ToDateTime("04.12.2019"),
                    IsUsed = false
                };
                Entities.PromotionalItems promotional5 = new Entities.PromotionalItems()
                {
                    PromotionalName = "%21",
                    Description = "Tüm Mağalazarda indirim",
                    CurrentDate = Convert.ToDateTime("04.12.2019"),
                    IsUsed = false
                };
                Entities.PromotionalItems promotional6 = new Entities.PromotionalItems()
                {
                    PromotionalName = "%25",
                    Description = "Tüm Mağalazarda indirim",
                    CurrentDate = Convert.ToDateTime("21.11.2019"),
                    IsUsed = false
                };
                Entities.PromotionalItems promotional7 = new Entities.PromotionalItems()
                {
                    PromotionalName = "%26",
                    Description = "Tüm Mağalazarda indirim",
                    CurrentDate = Convert.ToDateTime("19.11.2019"),
                    IsUsed = false
                };
                context.TablePromotionalItems.Add(promotional1);
                context.TablePromotionalItems.Add(promotional2);
                context.TablePromotionalItems.Add(promotional3);
                context.TablePromotionalItems.Add(promotional5);
                context.TablePromotionalItems.Add(promotional6);
                context.TablePromotionalItems.Add(promotional7);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Failed - DB");
            }
        }

    }
}
