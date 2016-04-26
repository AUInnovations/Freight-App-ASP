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
        public int DotNumber { get; set; }
        public bool IsTaxtId { get; set; }
        public string CompanyName { get; set; }
        public string DbaName { get; set; }
        public string MailingAddress { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingZip { get; set; }
        public string PhysicalAddress { get; set; }
        public string PhysicalCity { get; set; }
        public string PhysicalState { get; set; }
        public string PhysicalZip { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactPhone { get; set; }
        public string PrimaryContactEmail { get; set; }
        public string DispatchContactName { get; set; }
        public string DispatchContactPhone { get; set; }
        public string DispatchContactEmail { get; set; }
        public string AccountingContactName { get; set; }
        public string AccountingContactPhone { get; set; }
        public string AccountingContactEmail { get; set; }
        public double Rating { get; set; }
    }
}
