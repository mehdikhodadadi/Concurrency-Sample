using Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ResponseMessage : IResponseMessage
    {
        public string Message { get; set; }
    }
}