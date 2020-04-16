using System;
using System.Threading.Tasks;

namespace TheChat.Core.Services
{
    public interface IChatService
    {
        bool IsConnectd { get; }
        string ConnectionToken { get; set; }
        Task InitAsync(string userId);
        Task DisconectedAsync();
    }
}
