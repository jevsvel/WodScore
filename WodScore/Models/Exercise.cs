﻿using System.ComponentModel.DataAnnotations;

namespace WodScore.Models
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
