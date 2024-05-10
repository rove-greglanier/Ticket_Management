using System;
using System.Collections.Generic;

namespace Ticket_Management.Entities;

public partial class Contact
{
    public Guid Id { get; set; }

    public Guid? Email { get; set; }

    public Guid? Number { get; set; }

    public Guid? Address { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public virtual Address? AddressNavigation { get; set; }

    public virtual Email? EmailNavigation { get; set; }

    public virtual Number? NumberNavigation { get; set; }

    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();

    public virtual ICollection<User1> User1s { get; set; } = new List<User1>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<UsersAudit> UsersAudits { get; set; } = new List<UsersAudit>();
}
