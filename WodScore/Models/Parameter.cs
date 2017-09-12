using System;
using System.ComponentModel.DataAnnotations;

namespace WodScore.Models
{
    public class Parameter
    {
        [Key]
        public int ID { get; set; }
        public int EventID { get; set; }
        public int ExerciseID { get; set; }
        public int IsRequired { get; set; }
    }
}
