namespace InstrumentInformation.Models.DTOs.QueryDTO
{
    /// <summary>
    /// 动态查询器械参数
    /// </summary>
    public class InstrumentQueryParams
    {
        public List<QueryCondition<string>> StringConditions { get; set; } = new();
        public List<QueryCondition<DateTime?>> DateConditions { get; set; } = new();
        public List<QueryCondition<int?>> IntConditions { get; set; } = new();
    }
}
