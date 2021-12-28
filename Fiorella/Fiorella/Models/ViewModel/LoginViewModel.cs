﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required, MaxLength(100), MinLength(6)]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
