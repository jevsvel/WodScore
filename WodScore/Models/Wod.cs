using System.ComponentModel.DataAnnotations;

namespace WodScore.Models
{
    public class Wod
    {
        [Key]
        public int ID { get; set; }
        public int NumWod { get; set; }
        public string Name { get; set; }
        public bool HasTimeCap { get; set; }
        public int EventId { get; set; }
    }
}
