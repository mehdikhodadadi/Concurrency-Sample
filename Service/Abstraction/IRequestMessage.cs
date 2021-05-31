using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Abstraction
{
    public interface IRequestMessage
    {
        string Message { get; set; }
    }
}