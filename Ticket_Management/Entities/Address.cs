using System;
using System.Collections.Generic;

namespace Ticket_Management.Entities;

public partial class Address
{
    public Guid Id { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zipcode { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}
