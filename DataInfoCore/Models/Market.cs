using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataInfoCore.Models
{
    public class Market
    {
        public int ID { get; set; }
        [StringLength(6)]
        public String MarketCode { get; set; }
        public String MarketName { get; set; }
        [StringLength(1)]
        public String Status { get; set; }


    }
}
