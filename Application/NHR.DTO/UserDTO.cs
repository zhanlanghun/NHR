using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NHR.DTO
{
    public class UserDTO:BaseDTO
    {
        public string Account { get; set; } = "";

        public string PassWord { get; set; } = "";
    }
}
