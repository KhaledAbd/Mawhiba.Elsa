﻿// <auto-generated />
using Elsa.WorkflowSettings.Persistence.EntityFramework.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Elsa.WorkflowSettings.Persistence.EntityFramework.SqlServer.Migrations
{
    [DbContext(typeof(WorkflowSettingsContext))]
    partial class WorkflowSettingsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Elsa")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Elsa.WorkflowSettings.Models.WorkflowSetting", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WorkflowBlueprintId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .HasDatabaseName("IX_WorkflowSetting_Key");

                    b.HasIndex("Value")
                        .HasDatabaseName("IX_WorkflowSetting_Value");

                    b.HasIndex("WorkflowBlueprintId")
                        .HasDatabaseName("IX_WorkflowSetting_WorkflowBlueprintId");

                    b.ToTable("WorkflowSettings");
                });
#pragma warning restore 612, 618
        }
    }
}
