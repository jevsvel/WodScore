using System.ComponentModel.DataAnnotations.Schema;

namespace WodScore.Models
{
    public class EventAthlete
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int AthleteId { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }

        [ForeignKey("AthleteId")]
        public virtual Athlete Athlete { get; set; }

		[ForeignKey("CategoryId")]
		public virtual Category Category { get; set; }
    }
}
