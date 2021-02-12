using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T> 
    {
        public T Data { get; }
        public DataResult(T data ,bool issuccess,string message):base(issuccess,message)
        {
              Data = data;
        }
        public DataResult(T data, bool issuccess) : base(issuccess)
        {
            Data = data;
        }

    }
}
