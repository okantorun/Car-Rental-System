using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result,IDataResult<T>
    {
        public DataResult(bool success,string message,T data):base(success,message)
        {
            Data = data;
        }
        public DataResult(bool success,T data):base(success)
        {
            Data = data;
        }
        
        public T Data { get; }

        public bool Success { get; }

        public string Message { get; }
    }
}
