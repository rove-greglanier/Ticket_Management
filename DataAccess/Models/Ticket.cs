using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Status Status { get; set; }
        public Category Category { get; set; }
        public string Issue { get; set; }
        public Guid OwnerId { get; set; }
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
}
