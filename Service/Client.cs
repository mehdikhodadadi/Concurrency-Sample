using Service.Abstraction;
using System;
using System.Threading.Tasks;

namespace Service
{
    public class Client : IClient
    {
        private object obj = new object();

        public Task<IResponseMessage> SendAsync(IRequestMessage requestMessage)
        {
            lock (obj)
            {
                var message = requestMessage.Message;
                IResponseMessage response = new ResponseMessage();

                switch (message)
                {
                    case "Hello":
                        Task.Delay(1000);
                        response.Message = "Hi";
                        break;

                    //I have no idea to close the client connection.
                    //Maybe, you mean using Socket or SignalR!
                    case "Bye":
                        response.Message = "Bye";
                        break;

                    case "Ping":
                        response.Message = "Pong";
                        break;

                    default:
                        throw new Exception("Invalid request.");
                }

                return Task.FromResult(response);
            }
        }

        public Task<TResponseMessage> SendAsync<TResponseMessage>(IRequestMessage requestMessage) where TResponseMessage : IResponseMessage
        {
            //No implementation.
            return null;
        }
    }
}