using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Organization
{
    public class Organization
    {
        [Key]
        public Guid Id { get; set; }
        public string OrganizationName { get; set; }
        public DateTime CreatedAt { get; set; }

        public Guid ContactId { get; set; }
        [ForeignKey("ContactId")]
        public virtual Contact.Contact Contact { get; set; }
    }
}
