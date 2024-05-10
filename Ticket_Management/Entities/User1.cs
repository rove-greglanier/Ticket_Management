using System;
using System.Collections.Generic;

namespace Ticket_Management.Entities;

public partial class User1
{
    public Guid Id { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? FullName { get; set; }

    public Guid? ContactId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public virtual ICollection<Audit> Audits { get; set; } = new List<Audit>();

    public virtual Contact? Contact { get; set; }
}
