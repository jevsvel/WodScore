using System.ComponentModel.DataAnnotations.Schema;

namespace WodScore.Models
{
    public class EventAthlete
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public int AthleteID { get; set; }
        public int CategoryID { get; set; }

        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }

        [ForeignKey("AthleteId")]
        public virtual Athlete Athlete { get; set; }

		[ForeignKey("CategoryId")]
		public virtual Category Category { get; set; }
    }
}
