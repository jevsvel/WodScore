using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WodScore.Models
{
    public class Event
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Athlete> Athletes { get; set; }
    }
}
