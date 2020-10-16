using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ta3allam_Parmja.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "الاسم الأول"), Required(AllowEmptyStrings = false, ErrorMessage = "حقل مطلوب")]
        public string FirstName { get; set; }

        [Display(Name = "الاسم الأخير"), Required(AllowEmptyStrings = false, ErrorMessage = "حقل مطلوب")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress), Display(Name = "عنوان البريد الإلكتروني"), Required(AllowEmptyStrings = false, ErrorMessage = "حقل مطلوب")]
        public string EmailAddress { get; set; }

        [DataType(DataType.Date), Display(Name = "تاريخ الميلاد"), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Birthdate { get; set; }

        [DataType(DataType.Password), Required(AllowEmptyStrings = false, ErrorMessage = "حقل مطلوب"), MinLength(6, ErrorMessage = "مطلوب 6 حروف على الأقل"), Display(Name = "كلمة السر")]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare("Password", ErrorMessage = "الكلمتان غير متطابقتان"), Display(Name = "تأكيد كلمة السر")]
        public string CofirmPassword { get; set; }
    }
}
