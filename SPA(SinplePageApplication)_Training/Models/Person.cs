using System.ComponentModel.DataAnnotations;

namespace SPA.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "نام کاربر را وارد کنید")]
        [StringLength(150, ErrorMessage = "نام کاربر نمیتواند بیشتر از 150 کاراکتر باشد ")]
        [MinLength(5, ErrorMessage = "نام کاربر نمیتواند کمتر از 5 کاراکتر باشد")]
        public string PersonName { get; set; }

        [Required(ErrorMessage = "نام خانوادگی کاربر را وارد کنید")]
        [StringLength(150, ErrorMessage = "نام خانوادگی کاربر نمیتواند بیشتر از 150 کاراکتر باشد")]
        [MinLength(5, ErrorMessage = "نام خانوادگی کاربر نمیتواند کمتر از 5 کاراکتر باشد")]
        public string PersonFamily { get; set; }

        [Required(ErrorMessage = "سن کاربر را وارد کنید")]
        [Range(minimum: 5, maximum: 99, ErrorMessage = "سن کاربر نامعتبر است")]
        public int PersonAge { get; set; }
    }
}