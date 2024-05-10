using System;
using System.Collections.Generic;

namespace Ticket_Management.Entities;

public partial class ContactAudit
{
    public Guid Id { get; set; }

    public Guid? Email { get; set; }

    public Guid? Number { get; set; }

    public Guid? Audit { get; set; }

    public virtual Audit? AuditNavigation { get; set; }

    public virtual Email? EmailNavigation { get; set; }

    public virtual Number? NumberNavigation { get; set; }
}
