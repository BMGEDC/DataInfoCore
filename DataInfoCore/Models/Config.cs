using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataInfoCore.Models
{
    public class Config
    {
        public int ID { get; set; }
        public int MarketID { get; set; }
        public int WholesalerID { get; set; }
        [StringLength (1)]
        public string DataPeriod { get; set; }
        //M = Monthly
        //D = Daily
        //O = Occasionaly    
        //I = Informational only
        //  Monthly will have the last processed date reset on the first of the month-Warning after the 15th if not processed, Daily will not reset - Warning after 24 hours with no update(we might need to modify this if customer only sends data m-f or s-th, etc)
        // Occasionaly - Like General in WI, we get the data when they feel like.  So this would generate no warnings, but just be informational as to when the last sumbission was recieved
        public Boolean Active { get; set; } //Is the record active in the system
        [StringLength(1)]
        public string Function { get; set; }
        // W = Import to website
        // B = Import for Magazine
        // I = Inventory Status
        // R = Report
        public DateTime DataRecieved { get; set; }
        public DateTime DataProcessed { get; set; }
        public DateTime DataUploaded { get; set; }
        public DateTime ProofSent { get; set; }
        public DateTime PagesApproved { get; set; }
        public string Summary { get; set; } // Short Description of Task
        public string ExternalProcess { get; set; } //Name of DLL function, Fox EXE or other function to call 
        public DateTime ProcessStartTime { get; set; }
        public DateTime ProcessEndTIme { get; set; }



    }
}
