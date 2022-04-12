using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.DataBase
{
    public static class ModelBuilderExtensions
    {
        /// <summary>
        /// Extension Class for OnModelCreating Method to seed initial data to database
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 1,
                    name = "ProductType",
                    Description = "NULL",

                    ParentId = Products.LookUpId.ProductType
                }
                );
            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 2,
                    name = "ProductBrand",
                    Description = "NULL",

                    ParentId = Products.LookUpId.ProductBrand
                }
                );

            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 3,
                    name = "Color",
                    Description = "NULL",

                    ParentId = Products.LookUpId.Color
                }
                );

            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 4,
                    name = "Storage",
                    Description = "NULL",

                    ParentId = Products.LookUpId.Storage
                }
                );

            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 5,
                    name = "SimType",
                    Description = "NULL",

                    ParentId = Products.LookUpId.SimType
                }
                );

            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 6,
                    name = "OperatingSystem",
                    Description = "NULL",

                    ParentId = Products.LookUpId.OperatingSystem
                }
                );

            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 7,
                    name = "ProcessorType",
                    Description = "NULL",

                    ParentId = Products.LookUpId.ProcessorType
                }
                );

            modelBuilder.Entity<Products.LookUp>().HasData(
               new Products.LookUp
               {
                   Id = 8,
                   name = "ProcessorCore",
                   Description = "NULL",

                   ParentId = Products.LookUpId.ProcessorCore
               }
               );

            modelBuilder.Entity<Products.LookUp>().HasData(
               new Products.LookUp
               {
                   Id = 9,
                   name = "PrimaryCamera",
                   Description = "NULL",

                   ParentId = Products.LookUpId.PrimaryCamera
               }
               );
        }
    }
}
