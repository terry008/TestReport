using System;

namespace SKL.Report.Core.Models
{
    //实体基类
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Status = 1;
            CreatedBy = 6247;
            CreatedDate = DateTime.Now;
            UpdatedBy = 6247;
            UpdatedDate = DateTime.Now;
        }

        public int ID { get; set; }
        public int Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
