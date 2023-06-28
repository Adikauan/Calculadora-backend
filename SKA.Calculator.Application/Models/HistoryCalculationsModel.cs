namespace SKA.Calculator.Application.Models
{
    public class HistoryCalculationsModel
    {
        public Guid Id { get; set; }
        public string Operation { get; set; }
        public double Result { get; set; }
        public DateTime DateTime { get; set; }
    }
}
