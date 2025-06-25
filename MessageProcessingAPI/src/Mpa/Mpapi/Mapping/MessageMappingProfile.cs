using AutoMapper;
using MessageProcessingAPI.Mpa.Mpapi.Dto;
using MessageProcessingAPI.Mpa.Mpapi.Models;

namespace MessageProcessingAPI.Mpa.Mpapi.Mapping
{
    public class MessageMappingProfile : Profile
    {
        public MessageMappingProfile()
        {
            CreateMap<MessageDto, Message>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(_ => Guid.NewGuid()));
        }
    }
}
