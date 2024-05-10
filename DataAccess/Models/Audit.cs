using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Audit
    {
        [Key]
        public Guid Id { get; set; }
        public AuditAction Action { get; set; }
        public DateTime TimeOfAction { get; set; }
        public Guid ChangedById { get; set; }
    }
    public enum AuditAction
    {
        Created,
        Updated,
        Deleted
    }
}
