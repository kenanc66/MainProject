using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{//base voids result check
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
