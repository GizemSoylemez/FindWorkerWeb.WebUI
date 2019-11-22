using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindWorkerWeb.WebUI.Models
{
    public class UserModel
    {
        // [Required(ErrorMessage = "Kullanıcı Adınızı giriniz")]
        [Required(ErrorMessage = "Email boş bırakılamaz")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Email adresi geçersiz")]
        public string Email { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 6, ErrorMessage ="Şifreniz 6 haneli olmalıdır.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adınızı giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyadınızı giriniz")]
        public string Surname { get; set; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                ErrorMessage = "(5559993333) formatında olmalıdır.")]
        public string PhoneNumber { get; set; }

        public string ProfilePhoto { get; set; }
    }
    
}
