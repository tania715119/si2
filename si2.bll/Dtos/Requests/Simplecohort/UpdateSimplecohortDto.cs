﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace si2.bll.Dtos.Requests.Simplecohort
{
    public class UpdateSimplecohortDto
    {
        [Required]
        public string registrationRequirements { get; set; }

        [Required]
        public string graduationRequirements { get; set; }

        [Required]
        public string transferRequirements { get; set; }

        [Required]
        public byte[] RowVersion { get; set; }
    }
}
