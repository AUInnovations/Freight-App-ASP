using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FreightAppASP.Models
{
    public class Lanes
    {
        [Key]
        public int LaneId { get; set; }
        
        public int CarrierId { get; set; }
        
        public string OriginCity { get; set; }
        public string OriginState { get; set; }
        public int OriginZip { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationState { get; set; }
        public int DestinationZip { get; set; }
        public int Radius { get; set; }

    }
}
