using InstrumentInformation.Models.Entity;
using System.ComponentModel;
using System.Reflection;

namespace InstrumentInformation.Utils.Converter
{
    public class EnumToInstrumentTypeConverter
    {
        public static List<InstrumentType> ConvertEnumToInstrumentTypeList<TEnum>() where TEnum : Enum
        {
            return Enum.GetValues(typeof(TEnum))
                .Cast<TEnum>()
                .Select(e => new InstrumentType
                {
                    Id = Convert.ToInt32(e),
                    Name = GetEnumDescription(e)
                })
                .ToList();
        }
        private static string GetEnumDescription<TEnum>(TEnum value) where TEnum : Enum
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
