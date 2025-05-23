using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JournalistCMS.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "عنوان المقالة")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "محتوى المقالة")]
        public string Content { get; set; }

        [Display(Name = "تاريخ النشر")]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Display(Name = "اسم الصحفي")]
        public string Author { get; set; }
    }
}