﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Areas.Admin.ViewModel
{
    public class ChangePasswordViewModel
    {
        public string Id  { get; set; }
        public string  Username { get; set; }
        [Required,DataType(DataType.Password)]
        public string  OldPassword { get; set; }
        [Required, DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required, DataType(DataType.Password), Compare("NewPassword")]
        public string ConfirmPassword { get; set; }

    }
}
