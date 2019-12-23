using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.Exceptions
{
    public class NoUserException : Exception
    {
        public string Message { get; private set; }

        public NoUserException(string msg)
        {
            Message = msg;
        }
    }
}
