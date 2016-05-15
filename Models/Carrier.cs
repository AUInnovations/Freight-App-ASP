using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreightAppASP.Models
{
    public class Carrier
    {
        [Key]
        public int CarrierId { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9]*$")]
        public int DotNumber { get; set; }

        public bool IsTaxtId { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string CompanyName { get; set; }

        public string DbaName { get; set; }
        public string MailingAddress { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingZip { get; set; }
        public string PhysicalAddress { get; set; }
        public string PhysicalCity { get; set; }
        public string PhysicalState { get; set; }

        [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$")]
        public string PhysicalZip { get; set; }

        [RegularExpression(@"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$")]
        public string Phone { get; set; }

        public string Fax { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactPhone { get; set; }

        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")]
        public string PrimaryContactEmail { get; set; }

        public string DispatchContactName { get; set; }
        public string DispatchContactPhone { get; set; }
        public string DispatchContactEmail { get; set; }
        public string AccountingContactName { get; set; }
        public string AccountingContactPhone { get; set; }
        public string AccountingContactEmail { get; set; }
    }
}
