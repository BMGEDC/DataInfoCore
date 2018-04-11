using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;


namespace DataInfoCore.Models
{
    public class Wholesaler
    {

        public int ID { get; set; }
        
        public int MarketID { get; set; }
        [StringLength(6)]
        public string WholesalerCode { get; set; }
        public string WholesalerName { get; set; }
        public Boolean ETSUser { get; set; }
        public Boolean InBook { get; set; }
        public Boolean Online { get; set; }
        public Boolean DailyFeed { get; set; }
        public Boolean CustomerFeed { get; set; }
        public string Comments { get; set; }
        public string ETSLocation { get; set; }
        [StringLength(3)]
        public string Price_Zone { get; set; }
        [StringLength(10)]
        public string bm_id { get; set; }
        [StringLength(10)]
        public string org_id { get; set; }
        [StringLength(40)]
       
        public virtual Market Market { get; set; }


    }

}