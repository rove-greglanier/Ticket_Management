using System;
using System.Collections.Generic;

namespace Ticket_Management.Entities;

public partial class Organization
{
    public Guid Id { get; set; }

    public string? OrganizationName { get; set; }

    public DateTime CreatedAt { get; set; }

    public Guid? Contact { get; set; }

    public virtual Contact? ContactNavigation { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<UsersAudit> UsersAudits { get; set; } = new List<UsersAudit>();
}
