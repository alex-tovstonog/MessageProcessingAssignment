using MessageProcessingAPI.Mpa.Mpapi.Dto;

namespace MessageProcessingAPI.src.Mpa.Mpapi.MessageReader.Services
{
    public interface IMessageQueryService
    {
        Task<IEnumerable<MessageDto>> GetLatestMessagesAsync();
    }
}
