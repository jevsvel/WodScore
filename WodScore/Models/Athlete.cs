using System;
using System.ComponentModel.DataAnnotations;

namespace WodScore.Models
{
    public class Athlete
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public char Gender { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
