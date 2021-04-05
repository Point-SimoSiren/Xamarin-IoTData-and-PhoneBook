using System;
using System.Collections.Generic;
using System.Text;

namespace OmaXamarin2021.Models
{
    public class RaakaData
    {
        public int measurementId { get; set; }
        public string sender { get; set; }
        public DateTime time { get; set; }
        public decimal temperature { get; set; }
        public decimal humidity { get; set; }
        public decimal pressure { get; set; }
    }
}
