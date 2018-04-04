using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataInfoCore.Models
{
    public class ContactRole
    {
        public int ID { get; set; }
        public int ContactId { get; set; }
        public int RoleId { get; set; }
        public int WholesalerId { get; set; }
         }
}
