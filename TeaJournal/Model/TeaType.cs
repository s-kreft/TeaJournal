namespace TeaJournal.Model
{
    public class Tea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string TeaType { get; set; }
        public string PlaceOfOrigin { get; set; }
        public List<TeaBatch> TeaBatchList { get; set; }
        public double TeaBatchAverageRate { get; set; }



    }
}
