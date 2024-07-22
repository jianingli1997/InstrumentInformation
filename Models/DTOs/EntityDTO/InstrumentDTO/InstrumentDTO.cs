namespace InstrumentInformation.Models.DTOs.EntityDTO.InstrumentDTO
{
    public class InstrumentDTO
    {
        public required string Name { get; set; }

        public required int InstrumentTypeId { get; set; }

        public required string Description { get; set; }

        public required double Length { get; set; }

        public required string SerialNumber { get; set; }

       
        public DateTime CreatedDate { get; set; }

        public required DateTime ExpiredDate { get; set; }

        // 可用次数可能有一个默认值，但也可以允许用户指定
        public int UsableCount { get; set; } = 10;
    }
}
