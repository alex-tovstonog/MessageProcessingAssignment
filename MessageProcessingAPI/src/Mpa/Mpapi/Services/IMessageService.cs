using MessageProcessingAPI.Mpa.Mpapi.Dto;

namespace MessageProcessingAPI.Mpa.Mpapi.Services
{
    public interface IMessageService
    {
        Task ProcessMessageAsync(MessageDto message);
    }
}
