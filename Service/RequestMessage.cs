using Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class RequestMessage : IRequestMessage
    {
        public string Message { get; set; }
    }
}