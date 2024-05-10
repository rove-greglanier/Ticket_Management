using System;
using System.Collections.Generic;

namespace Ticket_Management.Entities;

public partial class Number
{
    public Guid Id { get; set; }

    public string? Number1 { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public virtual ICollection<ContactAudit> ContactAudits { get; set; } = new List<ContactAudit>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}
