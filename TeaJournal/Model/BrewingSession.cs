namespace TeaJournal.Model
{
    public class BrewingSession
    {
        public int Id { get; set; }
        public DateTime BrewingDate {  get; set; }
        public double WaterTemperature { get; set; }
        public double WaterAmount { get; set; }
        public double LeafAmount { get; set; }
        public double Rating { get; set; }
        public int TeaBatchId { get; set; }

    }
}
