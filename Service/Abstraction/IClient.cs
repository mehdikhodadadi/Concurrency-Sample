using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstraction
{
    public interface IClient
    {
        Task<IResponseMessage> SendAsync(IRequestMessage requestMessage);

        Task<TResponseMessage> SendAsync<TResponseMessage>(IRequestMessage requestMessage) where TResponseMessage : IResponseMessage;
    }
}