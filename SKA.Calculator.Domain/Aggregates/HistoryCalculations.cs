namespace SKA.Calculator.Domain.Aggregates
{
    public class HistoryCalculations
    {
        public Guid Id { get; set; }
        public string? Operation { get; set; }
        public double Result { get; set; }
        public DateTime DateTime { get; set; }

        public HistoryCalculations(string? operation, double result)
        {
            Id = Guid.NewGuid();
            Operation = operation;
            DateTime = DateTime.Now;
            Result = result;
        }

        public HistoryCalculations()
        {
        }
    }
}
