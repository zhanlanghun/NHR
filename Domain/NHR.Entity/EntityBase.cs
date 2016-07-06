using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NHR.Entity
{
    /// <summary>
    /// 所有实体类的基类
    /// </summary>
    public class EntityBase
    {
      
        
        public int ID { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
