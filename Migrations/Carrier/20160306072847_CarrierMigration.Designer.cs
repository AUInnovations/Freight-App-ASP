using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using FreightAppASP.DataContexts;

namespace FreightAppASP.Migrations.Carrier
{
    [DbContext(typeof(CarrierContext))]
    [Migration("20160306072847_CarrierMigration")]
    partial class CarrierMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("FreightAppASP.Models.Carrier", b =>
                {
                    b.Property<int>("CarrierId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountingContactEmail");

                    b.Property<string>("AccountingContactName");

                    b.Property<string>("AccountingContactPhone");

                    b.Property<string>("CompanyName");

                    b.Property<string>("DbaName");

                    b.Property<string>("DispatchContactEmail");

                    b.Property<string>("DispatchContactName");

                    b.Property<string>("DispatchContactPhone");

                    b.Property<int>("DotNumber");

                    b.Property<string>("Fax");

                    b.Property<bool>("IsTaxtId");

                    b.Property<string>("MailingAddress");

                    b.Property<string>("MailingCity");

                    b.Property<string>("MailingState");

                    b.Property<string>("MailingZip");

                    b.Property<string>("Phone");

                    b.Property<string>("PhysicalAddress");

                    b.Property<string>("PhysicalCity");

                    b.Property<string>("PhysicalState");

                    b.Property<string>("PhysicalZip");

                    b.Property<string>("PrimaryContactEmail");

                    b.Property<string>("PrimaryContactName");

                    b.Property<string>("PrimaryContactPhone");

                    b.HasKey("CarrierId");
                });
        }
    }
}