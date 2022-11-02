﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ONE.AdministrationService.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace ONE.AdministrationService.Migrations
{
    [DbContext(typeof(AdministrationServiceDbContext))]
    partial class AdministrationServiceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.PostgreSql)
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLog", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("ApplicationName")
                        .HasMaxLength(96)
                        .HasColumnType("character varying(96)")
                        .HasColumnName("ApplicationName");

                    b.Property<string>("BrowserInfo")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)")
                        .HasColumnName("BrowserInfo");

                    b.Property<string>("ClientId")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("ClientId");

                    b.Property<string>("ClientIpAddress")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("ClientIpAddress");

                    b.Property<string>("ClientName")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("ClientName");

                    b.Property<string>("Comments")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("Comments");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("CorrelationId")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("CorrelationId");

                    b.Property<string>("Exceptions")
                        .HasColumnType("text");

                    b.Property<int>("ExecutionDuration")
                        .HasColumnType("integer")
                        .HasColumnName("ExecutionDuration");

                    b.Property<DateTime>("ExecutionTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("HttpMethod")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)")
                        .HasColumnName("HttpMethod");

                    b.Property<int?>("HttpStatusCode")
                        .HasColumnType("integer")
                        .HasColumnName("HttpStatusCode");

                    b.Property<Guid?>("ImpersonatorTenantId")
                        .HasColumnType("uuid")
                        .HasColumnName("ImpersonatorTenantId");

                    b.Property<string>("ImpersonatorTenantName")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("ImpersonatorTenantName");

                    b.Property<Guid?>("ImpersonatorUserId")
                        .HasColumnType("uuid")
                        .HasColumnName("ImpersonatorUserId");

                    b.Property<string>("ImpersonatorUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("ImpersonatorUserName");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uuid")
                        .HasColumnName("TenantId");

                    b.Property<string>("TenantName")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("TenantName");

                    b.Property<string>("Url")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("Url");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("UserId");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "ExecutionTime");

                    b.HasIndex("TenantId", "UserId", "ExecutionTime");

                    b.ToTable("AbpAuditLogs", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLogAction", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AuditLogId")
                        .HasColumnType("uuid")
                        .HasColumnName("AuditLogId");

                    b.Property<int>("ExecutionDuration")
                        .HasColumnType("integer")
                        .HasColumnName("ExecutionDuration");

                    b.Property<DateTime>("ExecutionTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ExecutionTime");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("MethodName")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("MethodName");

                    b.Property<string>("Parameters")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("Parameters");

                    b.Property<string>("ServiceName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("ServiceName");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uuid")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("AuditLogId");

                    b.HasIndex("TenantId", "ServiceName", "MethodName", "ExecutionTime");

                    b.ToTable("AbpAuditLogActions", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityChange", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AuditLogId")
                        .HasColumnType("uuid")
                        .HasColumnName("AuditLogId");

                    b.Property<DateTime>("ChangeTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ChangeTime");

                    b.Property<byte>("ChangeType")
                        .HasColumnType("smallint")
                        .HasColumnName("ChangeType");

                    b.Property<string>("EntityId")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("EntityId");

                    b.Property<Guid?>("EntityTenantId")
                        .HasColumnType("uuid");

                    b.Property<string>("EntityTypeFullName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("EntityTypeFullName");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uuid")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("AuditLogId");

                    b.HasIndex("TenantId", "EntityTypeFullName", "EntityId");

                    b.ToTable("AbpEntityChanges", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityPropertyChange", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("EntityChangeId")
                        .HasColumnType("uuid");

                    b.Property<string>("NewValue")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)")
                        .HasColumnName("NewValue");

                    b.Property<string>("OriginalValue")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)")
                        .HasColumnName("OriginalValue");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("PropertyName");

                    b.Property<string>("PropertyTypeFullName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("PropertyTypeFullName");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uuid")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("EntityChangeId");

                    b.ToTable("AbpEntityPropertyChanges", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.FeatureManagement.FeatureValue", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("ProviderName")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.HasKey("Id");

                    b.HasIndex("Name", "ProviderName", "ProviderKey")
                        .IsUnique();

                    b.ToTable("AbpFeatureValues", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.PermissionManagement.PermissionGrant", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uuid")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "Name", "ProviderName", "ProviderKey")
                        .IsUnique();

                    b.ToTable("AbpPermissionGrants", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.SettingManagement.Setting", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("ProviderName")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("character varying(2048)");

                    b.HasKey("Id");

                    b.HasIndex("Name", "ProviderName", "ProviderKey")
                        .IsUnique();

                    b.ToTable("AbpSettings", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLogAction", b =>
                {
                    b.HasOne("Volo.Abp.AuditLogging.AuditLog", null)
                        .WithMany("Actions")
                        .HasForeignKey("AuditLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityChange", b =>
                {
                    b.HasOne("Volo.Abp.AuditLogging.AuditLog", null)
                        .WithMany("EntityChanges")
                        .HasForeignKey("AuditLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityPropertyChange", b =>
                {
                    b.HasOne("Volo.Abp.AuditLogging.EntityChange", null)
                        .WithMany("PropertyChanges")
                        .HasForeignKey("EntityChangeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLog", b =>
                {
                    b.Navigation("Actions");

                    b.Navigation("EntityChanges");
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityChange", b =>
                {
                    b.Navigation("PropertyChanges");
                });
#pragma warning restore 612, 618
        }
    }
}
