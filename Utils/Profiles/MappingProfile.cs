using AutoMapper;
using InstrumentInformation.Models.DTOs.EntityDTO.InstrumentDTO;
using InstrumentInformation.Models.Entity.Instrument;

namespace InstrumentInformation.Utils.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<InstrumentDTO, Instrument>();
        }

    }
}
