using System;
using System.ComponentModel.DataAnnotations;

namespace WodScore.Models
{
    public class Parameter
    {
        [Key]
        public int Id { get; set; }
        public int EventId { get; set; }
        public int ExerciseId { get; set; }
        public int IsRequired { get; set; }
    }
}
