using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace DataInfoCore.Models
{
    public class Communication
    {
        public int ID { get; set; }
        public int ContactID { get; set; }
        public DateTime CommDate { get; set; }
        [MaxLength(64000)]
        public String CommText { get; set; }

    }
}
