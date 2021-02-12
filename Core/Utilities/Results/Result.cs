using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool issuccess,string message):this(issuccess)
        {
            Message = message;
                
        }
        public Result(bool issuccess)
        {
            isSuccess = issuccess;

        }
        public bool isSuccess { get; }
        public string Message { get; }
    }
}
