using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Abstraction
{
    public interface IResponseMessage
    {
        string Message { get; set; }
    }
}