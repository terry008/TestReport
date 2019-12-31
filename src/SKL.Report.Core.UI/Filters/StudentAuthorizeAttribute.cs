using System;
using Microsoft.AspNetCore.Authorization;

namespace SKL.Report.Core.UI.Filters
{
    //学员登录票据
    public class StudentAuthorizeAttribute : AuthorizeAttribute
    {
        public const string StudentAuthenticationScheme = "StudentScheme";
        public StudentAuthorizeAttribute()
        {
            this.AuthenticationSchemes = StudentAuthenticationScheme;
        }
    }
}
