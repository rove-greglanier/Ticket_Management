using System;
using System.Collections.Generic;

namespace Ticket_Management.Entities;

public partial class User
{
    public Guid Id { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? FullName { get; set; }

    public Guid? ContactId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public Guid? OrganizationId { get; set; }

    public virtual ICollection<Audit> Audits { get; set; } = new List<Audit>();

    public virtual Contact? Contact { get; set; }

    public virtual Organization? Organization { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
