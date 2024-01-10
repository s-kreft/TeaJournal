namespace TeaJournal.Model
{
    public class TeaBatch
    {
        public int Id { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime BuyDate { get; set; }
        public double BrewingSessionAverageRate { get; set; }
        public double TeaBatchPrice { get; set; }
    }
}
