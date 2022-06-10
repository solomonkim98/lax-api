using System;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Type>().HasData(
                new Type { Id = 1, Name = "Janitorial" },
                new Type { Id = 2, Name = "Landscaping" },
                new Type { Id = 3, Name = "Construction" },
                new Type { Id = 4, Name = "Facility" },
                new Type { Id = 5, Name = "Security" });

            modelBuilder.Entity<Value>().HasData(
                new Value { Id = 1, TypeId = 1, Name = "Inspection 1", Sku = "ASDFA", Score = 61, IsAccepted = true },
                new Value { Id = 2, TypeId = 1, Name = "Inspection 2", Sku = "ASDWE", Score = 34, IsAccepted = true },
                new Value { Id = 3, TypeId = 1, Name = "Inspection 3", Sku = "ASDFG", Score = 33, IsAccepted = true },
                new Value { Id = 4, TypeId = 1, Name = "Inspection 4", Sku = "AMQWE", Score = 95, IsAccepted = true },
                new Value { Id = 5, TypeId = 1, Name = "Inspection 5", Sku = "ASFKW", Score = 60, IsAccepted = true },
                new Value { Id = 6, TypeId = 1, Name = "Inspection 6", Sku = "AMLPS", Score = 95, IsAccepted = true },
                new Value { Id = 7, TypeId = 1, Name = "Inspection 7", Sku = "AQWKS", Score = 65, IsAccepted = true },
                new Value { Id = 8, TypeId = 1, Name = "Inspection 8", Sku = "AZMFJ", Score = 65, IsAccepted = true },
                new Value { Id = 9, TypeId = 1, Name = "Inspection 9", Sku = "AWPSD", Score = 17, IsAccepted = true },
                new Value { Id = 10, TypeId = 2, Name = "Inspection 10", Sku = "AOSID", Score = 99, IsAccepted = true },
                new Value { Id = 11, TypeId = 2, Name = "Inspection 11", Sku = "AXMCN", Score = 0, IsAccepted = false },
                new Value { Id = 12, TypeId = 2, Name = "Inspection 12", Sku = "AKSJD", Score = 68, IsAccepted = true },
                new Value { Id = 13, TypeId = 2, Name = "Inspection 13", Sku = "APWOS", Score = 100, IsAccepted = true },
                new Value { Id = 14, TypeId = 2, Name = "Inspection 14", Sku = "ALSMK", Score = 55, IsAccepted = true },
                new Value { Id = 15, TypeId = 2, Name = "Inspection 15", Sku = "ASKXJ", Score = 22, IsAccepted = true },
                new Value { Id = 16, TypeId = 2, Name = "Inspection 16", Sku = "AMSJX", Score = 95, IsAccepted = true },
                new Value { Id = 17, TypeId = 2, Name = "Inspection 17", Sku = "AIQJW", Score = 17, IsAccepted = true },
                new Value { Id = 18, TypeId = 3, Name = "Inspection 18", Sku = "APWOS", Score = 29, IsAccepted = true },
                new Value { Id = 19, TypeId = 3, Name = "Inspection 19", Sku = "APSLO", Score = 53, IsAccepted = true },
                new Value { Id = 20, TypeId = 3, Name = "Inspection 20", Sku = "AKSJI", Score = 87, IsAccepted = true },
                new Value { Id = 21, TypeId = 3, Name = "Inspection 21", Sku = "AJSUX", Score = 89, IsAccepted = true },
                new Value { Id = 22, TypeId = 3, Name = "Inspection 22", Sku = "AMZJS", Score = 28, IsAccepted = true },
                new Value { Id = 23, TypeId = 3, Name = "Inspection 23", Sku = "AJSUQ", Score = 93, IsAccepted = true },
                new Value { Id = 24, TypeId = 4, Name = "Inspection 24", Sku = "ANSJV", Score = 24, IsAccepted = true },
                new Value { Id = 25, TypeId = 5, Name = "Inspection 25", Sku = "ALCZK", Score = 99, IsAccepted = true },
                new Value { Id = 26, TypeId = 5, Name = "Inspection 26", Sku = "AKSBX", Score = 12, IsAccepted = true },
                new Value { Id = 27, TypeId = 5, Name = "Inspection 27", Sku = "ABVCX", Score = 91, IsAccepted = true },
                new Value { Id = 28, TypeId = 5, Name = "Inspection 28", Sku = "AZXCV", Score = 49, IsAccepted = true },
                new Value { Id = 29, TypeId = 5, Name = "Inspection 29", Sku = "AMNBI", Score = 15, IsAccepted = true },
                new Value { Id = 30, TypeId = 5, Name = "Inspection 30", Sku = "APETAQ", Score = 91, IsAccepted = true });
        }
    }
}
