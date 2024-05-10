using System;
using System.Collections.Generic;

namespace Ticket_Management.Entities;

public partial class EmailAduit
{
    public Guid Id { get; set; }

    public string? Email { get; set; }

    public Guid? Audit { get; set; }

    public virtual Audit? AuditNavigation { get; set; }
}
