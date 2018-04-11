using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataInfoCore.Models
{
    public class WholesalerInfo
    {
        public int ID { get; set; }
        public int WholesalerID { get; set; }

        public string dba { get; set; }
        [StringLength(30)]
        public string address1 { get; set; }
        [StringLength(30)]
        public string address2 { get; set; }
        [StringLength(30)]
        public string address3 { get; set; }
        [StringLength(30)]
        public string city { get; set; }
        [StringLength(2)]
        public string state { get; set; }
        [StringLength(10)]
        public string zip { get; set; }
        [StringLength(30)]
        public string MainPhone { get; set; }
        [StringLength(30)]
        public string Fax { get; set; }
        public string Desc { get; set; }
        public Single min_case { get; set; }
        [StringLength (10)]
        public string cutoff_tm { get; set; }
        [StringLength(1)]
        public string level3 { get; set; }
        [StringLength(1)]
        public string skipfaxord { get; set; }
        [StringLength(1)]
        public string show_blind { get; set; }
        public string policies { get; set; }
        public string nostockmsg { get; set; }
        [StringLength(1)]
        public string faxcheck { get; set; }
        [StringLength(1)]
        public string rejectord { get; set; }
        public DateTime? downstart { get; set; }
        [MaxLength(150)]
        public string facetsname { get; set; }

        [MaxLength(150)]
        public string webname { get; set; }
        [MaxLength(250)]
        public string avail_mess { get; set; }
        public DateTime? tstamp { get; set; }
        public int smancnt { get; set; }
        public int itemcnt { get; set; }
        [StringLength (1)]
        public string novirtual { get; set; }
        [StringLength(1)]
        public string statusrpt { get; set; }
        [StringLength(2)]
        public string allowedits { get; set; }
        public DateTime? strepstamp { get; set; }
        public int sqlfailno { get; set; }
        [MaxLength(50)]
        public string usewhdesc { get; set; }
        [StringLength(1)]
        public string min_type { get; set; }
        public Single freeshpamt { get; set; }
        public Single split_fee  {get; set; }
        public Single ship_fee { get; set; }
        public Single newratcnt { get; set; }






        public virtual Wholesaler Wholesaler { get; set; }
    }
}
