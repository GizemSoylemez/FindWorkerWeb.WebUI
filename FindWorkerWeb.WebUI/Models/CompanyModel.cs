using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class CompanyModel
    {
        [Required(ErrorMessage = "Email boş bırakılamaz")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Email adresi geçersiz")]
        public string CompanyEmail { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Şifreniz 6 haneli olmalıdır.")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Şirket ismini giriniz")]
        public string CompanyName { get; set; }
       
    }
}
