using System;
using System.ComponentModel.DataAnnotations;

namespace WodScore.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
