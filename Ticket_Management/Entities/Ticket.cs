using System;
using System.Collections.Generic;

namespace Ticket_Management.Entities;

public partial class Ticket
{
    public Guid Id { get; set; }

    public Guid? OrganizationId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public Status Status { get; set; } 

    public Category Category { get; set; } 

    public string? Issue { get; set; }

    public Guid? OwnerId { get; set; }

    public virtual Organization? Organization { get; set; }

    public virtual User? Owner { get; set; }
}
public enum Status
{
    Complete,
    InProgress,
    Open,
    OnHold,
    Abandoned
}

public enum Category
{
    Bug,
    Request,
    Update
}
