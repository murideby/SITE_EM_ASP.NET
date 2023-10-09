﻿using System.ComponentModel.DataAnnotations;

namespace dash_WEB.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o senha")]
        public string Senha { get; set; }
    }
}
