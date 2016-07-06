using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NHR.Entity
{
    [Table("User")]
    public class User : EntityBase
    {
      
        public string Account { get; set; } = "";

        public string PassWord { get; set; } = "";
        public string UserName { get; set; } = "";
        public string Tel { get; set; } = "";
        public string Email { get; set; } = "";

    }
}
