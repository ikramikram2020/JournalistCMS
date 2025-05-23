using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace JournalistCMS.Models
    {
        public class Journalist
        {
            public int Id { get; set; }

            [Required]
            [Display(Name = "اسم المستخدم")]
            public string Username { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "كلمة المرور")]
            public string Password { get; set; }
        }
    }
