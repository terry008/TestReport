using System;
using System.Collections.Generic;

namespace SKL.Report.Core.Models
{
    public class PageModel<T> where T : class
    {
        public PageModel()
        {
            
        }
        public PageModel(int pageIndex,int pageSize)
        {
            this.PageIndex=pageIndex;
            this.PageSize=pageSize;
        }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int PageCount { get; set; }
        public List<T> PageData { get; set; }
    }
}
