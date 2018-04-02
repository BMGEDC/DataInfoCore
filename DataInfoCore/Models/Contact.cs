using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DataInfoCore.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public int WholesalerID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
    }
}
