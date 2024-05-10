using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Contact
{
    public class Contact
    {
        [Key]
        public Guid Id { get; set; }
        public List<Guid> EmailId { get; set; }
        public List<Guid> NumberId { get; set; }
        public List<Guid> AddressId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
