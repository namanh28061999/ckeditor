using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;

namespace ckeditor.Models
{
    public class Encrytion
    {
        public string PasswordEncrytion(string pass)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "MD5");
        }

    }
}