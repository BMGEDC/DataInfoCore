using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DataInfoCore.Models
{
    public class Processlog
    {
        public int ID { get; set; }
        public string  User { get; set; }
        public DateTime Logdate { get; set; }
        public int ConfigID { get; set; }
        public string Comment { get; set; }
    }
}
