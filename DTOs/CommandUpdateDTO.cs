﻿using System.ComponentModel.DataAnnotations;

namespace CommanderWebAPI.DTOs
{
    public class CommandUpdateDTO
    {
        [Required]
        public string HowTo { get; set; }

        [Required]
        [MaxLength(250)]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}
