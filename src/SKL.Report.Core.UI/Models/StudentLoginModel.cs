using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SKL.Report.Core.UI.Models
{
    //查询登录
    public class StudentLoginModel
    {
        [Required, MinLength(2), MaxLength(6)]
        public string StuName { get; set; }

        [Required, StringLength(11)]
        public string Phone { get; set; }
    }
}
