//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjaxTry.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Table
    {
        [Required(ErrorMessage ="Field cannot be Empty")]
        public int EMPLOYEE_Id { get; set; }
        [Required(ErrorMessage = "Field cannot be Empty")]
        public string EMPLOYEE_NAME { get; set; }
        [Required(ErrorMessage = "Field cannot be Empty")]
        public int SALARY { get; set; }
        [Required(ErrorMessage = "Field cannot be Empty")]
        public string DEPARTMENT { get; set; }
    }
}
