//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ckeditor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class Account
    {
        [Required(ErrorMessage = "User name is required.")]
        public string ArticleID { get; set; }
        [Required(ErrorMessage = "Password  is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [AllowHtml]
        public string UserName { get; set; }
    }
}
