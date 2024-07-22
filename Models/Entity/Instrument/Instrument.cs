namespace InstrumentInformation.Models.Entity.Instrument
{
    public class Instrument
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int InstrumentTypeId { get; set; }

        public string Description { get; set; } = string.Empty;

        public double Length { get; set; }

        public string SerialNumber { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ExpiredDate { get; set; } = DateTime.MaxValue;

        public int UsableCount { get; set; } = 10;

    }
}
