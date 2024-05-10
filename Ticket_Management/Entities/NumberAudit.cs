using System;
using System.Collections.Generic;

namespace Ticket_Management.Entities;

public partial class NumberAudit
{
    public Guid Id { get; set; }

    public string? Number { get; set; }

    public Guid? Audit { get; set; }

    public virtual Audit? AuditNavigation { get; set; }
}
