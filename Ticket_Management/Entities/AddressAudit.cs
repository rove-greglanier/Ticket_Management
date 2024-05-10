using System;
using System.Collections.Generic;

namespace Ticket_Management.Entities;

public partial class AddressAudit
{
    public Guid Id { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zipcode { get; set; }

    public Guid? Audit { get; set; }

    public virtual Audit? AuditNavigation { get; set; }
}
