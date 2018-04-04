using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataInfoCore.Models
{
    public class Role
    {
        public int ID { get; set; }
        [MaxLength( 40)]
        public String RoleDescription { get; set; }
        
    }
}
