namespace Fiorella.Models.Entity
{
    public class MiniSlider : BaseEntity
    {
        public string Title { get; set; }
        public int ExpertId { get; set; }
        public Experts Expert { get; set; }

    }
}
