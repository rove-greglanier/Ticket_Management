using System;
using System.Collections.Generic;

namespace Ticket_Management.Entities;

public partial class Audit
{
    public Guid Id { get; set; }

    public string Action { get; set; } = null!;

    public byte[] TimeOfAction { get; set; } = null!;

    public Guid? ChangedById { get; set; }

    public virtual ICollection<AddressAudit> AddressAudits { get; set; } = new List<AddressAudit>();

    public virtual User? ChangedBy { get; set; }

    public virtual User1? ChangedByNavigation { get; set; }

    public virtual ICollection<ContactAudit> ContactAudits { get; set; } = new List<ContactAudit>();

    public virtual ICollection<EmailAduit> EmailAduits { get; set; } = new List<EmailAduit>();

    public virtual ICollection<NumberAudit> NumberAudits { get; set; } = new List<NumberAudit>();

    public virtual ICollection<UsersAudit> UsersAudits { get; set; } = new List<UsersAudit>();
}
