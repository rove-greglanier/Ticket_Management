using System;
using System.Collections.Generic;

namespace Ticket_Management.Entities;

public partial class UsersAudit
{
    public Guid Id { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? FullName { get; set; }

    public Guid? ContactId { get; set; }

    public Guid? Audit { get; set; }

    public Guid? OrganizationId { get; set; }

    public virtual Audit? AuditNavigation { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual Organization? Organization { get; set; }
}
