using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataInfoCore.Models
{
    public class Wholesaler
    {
        public int ID { get; set; }
        [StringLength (5)]
        public string Market { get; set; }
        [StringLength(6)]
        public string WholesalerCode { get; set; }
        public string WholesalerName { get; set; }
        public int BookContactID { get; set; }
        public int BookContact1ID { get; set; }
        public int WebContactID { get; set; }
        public int WebContact1ID { get; set; }
        public int ITContactID { get; set; }
        public int OrderContactID { get; set; }
        public int BookFileID { get; set; }
        public int InvFileID { get; set; }
        public int CustFileID { get; set; }
        public Boolean  ETSUser { get; set; }
        public Boolean InBook { get; set; }
        public Boolean Online { get; set; }
        public Boolean DailyFeed { get; set; }
        public Boolean CustomerFeed { get; set; }
        public string Comments { get; set; }
        public string ETSLocation { get; set; }


    }
}
