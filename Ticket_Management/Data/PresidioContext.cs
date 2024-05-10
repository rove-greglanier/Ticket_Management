using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Ticket_Management.Entities;

namespace Ticket_Management.Data;

public partial class PresidioContext : DbContext
{
    public PresidioContext()
    {
    }

    public PresidioContext(DbContextOptions<PresidioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AddressAudit> AddressAudits { get; set; }

    public virtual DbSet<Audit> Audits { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ContactAudit> ContactAudits { get; set; }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<EmailAduit> EmailAduits { get; set; }

    public virtual DbSet<Number> Numbers { get; set; }

    public virtual DbSet<NumberAudit> NumberAudits { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<User1> Users1 { get; set; }

    public virtual DbSet<UsersAudit> UsersAudits { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Address__3213E83FCCF62524");

            entity.ToTable("Address", "Contact");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.AddressLine1)
                .HasMaxLength(255)
                .HasColumnName("address_line1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(255)
                .HasColumnName("address_line2");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.ModifiedAt)
                .HasColumnType("datetime")
                .HasColumnName("modified_at");
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .HasColumnName("state");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(255)
                .HasColumnName("zipcode");
        });

        modelBuilder.Entity<AddressAudit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AddressA__3213E83F1BD22167");

            entity.ToTable("AddressAudit", "Contact");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.AddressLine1)
                .HasMaxLength(255)
                .HasColumnName("address_line1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(255)
                .HasColumnName("address_line2");
            entity.Property(e => e.Audit).HasColumnName("audit");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city");
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .HasColumnName("state");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(255)
                .HasColumnName("zipcode");

            entity.HasOne(d => d.AuditNavigation).WithMany(p => p.AddressAudits)
                .HasForeignKey(d => d.Audit)
                .HasConstraintName("FK__AddressAu__audit__379037E3");
        });

        modelBuilder.Entity<Audit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__audit__3213E83F87489832");

            entity.ToTable("audit");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("action");
            entity.Property(e => e.ChangedById).HasColumnName("changedByID");
            entity.Property(e => e.TimeOfAction)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("timeOfAction");

            entity.HasOne(d => d.ChangedBy).WithMany(p => p.Audits)
                .HasForeignKey(d => d.ChangedById)
                .HasConstraintName("FK__audit__changedBy__627A95E8");

            entity.HasOne(d => d.ChangedByNavigation).WithMany(p => p.Audits)
                .HasForeignKey(d => d.ChangedById)
                .HasConstraintName("FK__audit__changedBy__636EBA21");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contact__3213E83F0131ADAC");

            entity.ToTable("Contact", "Contact");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.ModifiedAt)
                .HasColumnType("datetime")
                .HasColumnName("modified_at");
            entity.Property(e => e.Number).HasColumnName("number");

            entity.HasOne(d => d.AddressNavigation).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.Address)
                .HasConstraintName("FK__Contact__address__5AD97420");

            entity.HasOne(d => d.EmailNavigation).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.Email)
                .HasConstraintName("FK__Contact__email__58F12BAE");

            entity.HasOne(d => d.NumberNavigation).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.Number)
                .HasConstraintName("FK__Contact__number__59E54FE7");
        });

        modelBuilder.Entity<ContactAudit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ContactA__3213E83F5A2725F9");

            entity.ToTable("ContactAudit", "Contact");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Audit).HasColumnName("audit");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Number).HasColumnName("number");

            entity.HasOne(d => d.AuditNavigation).WithMany(p => p.ContactAudits)
                .HasForeignKey(d => d.Audit)
                .HasConstraintName("FK__ContactAu__audit__369C13AA");

            entity.HasOne(d => d.EmailNavigation).WithMany(p => p.ContactAudits)
                .HasForeignKey(d => d.Email)
                .HasConstraintName("FK__ContactAu__email__5BCD9859");

            entity.HasOne(d => d.NumberNavigation).WithMany(p => p.ContactAudits)
                .HasForeignKey(d => d.Number)
                .HasConstraintName("FK__ContactAu__numbe__5CC1BC92");
        });

        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__email__3213E83F04D94807");

            entity.ToTable("email", "Contact");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Email1)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.ModifiedAt)
                .HasColumnType("datetime")
                .HasColumnName("modified_at");
        });

        modelBuilder.Entity<EmailAduit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__emailAdu__3213E83F29F63587");

            entity.ToTable("emailAduit", "Contact");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Audit).HasColumnName("audit");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");

            entity.HasOne(d => d.AuditNavigation).WithMany(p => p.EmailAduits)
                .HasForeignKey(d => d.Audit)
                .HasConstraintName("FK__emailAdui__audit__39788055");
        });

        modelBuilder.Entity<Number>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__number__3213E83F7E6C434F");

            entity.ToTable("number", "Contact");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.ModifiedAt)
                .HasColumnType("datetime")
                .HasColumnName("modified_at");
            entity.Property(e => e.Number1)
                .HasMaxLength(255)
                .HasColumnName("number");
        });

        modelBuilder.Entity<NumberAudit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__numberAu__3213E83FABEA93C0");

            entity.ToTable("numberAudit", "Contact");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Audit).HasColumnName("audit");
            entity.Property(e => e.Number)
                .HasMaxLength(255)
                .HasColumnName("number");

            entity.HasOne(d => d.AuditNavigation).WithMany(p => p.NumberAudits)
                .HasForeignKey(d => d.Audit)
                .HasConstraintName("FK__numberAud__audit__38845C1C");
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3213E83FFB470EE1");

            entity.ToTable("organization", "Organization");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(255)
                .HasColumnName("organization_name");

            entity.HasOne(d => d.ContactNavigation).WithMany(p => p.Organizations)
                .HasForeignKey(d => d.Contact)
                .HasConstraintName("FK__organizat__Conta__1F83A428");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tickets__3213E83FA5D44215");

            entity.ToTable("Tickets", "Tickets");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Issue)
                .HasMaxLength(255)
                .HasColumnName("issue");
            entity.Property(e => e.ModifiedAt)
                .HasColumnType("datetime")
                .HasColumnName("modified_at");
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");
            entity.Property(e => e.OwnerId).HasColumnName("Owner_id");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");

            entity.HasOne(d => d.Organization).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.OrganizationId)
                .HasConstraintName("FK__Tickets__organiz__2630A1B7");

            entity.HasOne(d => d.Owner).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK__Tickets__Owner_i__00FF1D08");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83F57ECF46A");

            entity.ToTable("users", "Organization");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.ContactId).HasColumnName("Contact_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("First_name");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .HasColumnName("Full_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("Last_name");
            entity.Property(e => e.ModifiedAt)
                .HasColumnType("datetime")
                .HasColumnName("modified_at");
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

            entity.HasOne(d => d.Contact).WithMany(p => p.Users)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK__users__Contact_i__53385258");

            entity.HasOne(d => d.Organization).WithMany(p => p.Users)
                .HasForeignKey(d => d.OrganizationId)
                .HasConstraintName("FK__users__organizat__216BEC9A");
        });

        modelBuilder.Entity<User1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user__3213E83F4DE9CE3C");

            entity.ToTable("user", "presidio");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.ContactId).HasColumnName("Contact_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("First_name");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .HasColumnName("Full_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("Last_name");
            entity.Property(e => e.ModifiedAt)
                .HasColumnType("datetime")
                .HasColumnName("modified_at");

            entity.HasOne(d => d.Contact).WithMany(p => p.User1s)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK__user__Contact_id__57FD0775");
        });

        modelBuilder.Entity<UsersAudit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usersAud__3213E83FA65D640E");

            entity.ToTable("usersAudit", "Organization");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Audit).HasColumnName("audit");
            entity.Property(e => e.ContactId).HasColumnName("Contact_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("First_name");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .HasColumnName("Full_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("Last_name");
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

            entity.HasOne(d => d.AuditNavigation).WithMany(p => p.UsersAudits)
                .HasForeignKey(d => d.Audit)
                .HasConstraintName("FK__usersAudi__audit__32CB82C6");

            entity.HasOne(d => d.Contact).WithMany(p => p.UsersAudits)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK__usersAudi__Conta__55209ACA");

            entity.HasOne(d => d.Organization).WithMany(p => p.UsersAudits)
                .HasForeignKey(d => d.OrganizationId)
                .HasConstraintName("FK__usersAudi__organ__2354350C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
