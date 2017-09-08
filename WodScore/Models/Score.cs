using System;
using System.ComponentModel.DataAnnotations;

namespace WodScore.Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }
        public int ScoreS { get; set; }
    }
}
