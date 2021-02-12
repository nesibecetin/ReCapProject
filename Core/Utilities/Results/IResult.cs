using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
       bool isSuccess { get; }
        string Message { get; }
    }
}
