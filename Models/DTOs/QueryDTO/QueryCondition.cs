namespace InstrumentInformation.Models.DTOs.QueryDTO
{
    public class QueryCondition<T>
    {
        public string? Field { get; set; } = string.Empty;
        //单个字段 例如等于某个值
        public T? SingleValue { get; set; }

        //两个字段 例如在某个范围内
        public T? MaxValue { get; set; }
        public T? MinValue { get; set; }

    }
}
