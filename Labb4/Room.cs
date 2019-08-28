using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    public interface IRoom 
    {
        int Keys { get; set; }
        string Symbol { get; set; }

        bool TryEnter();
    }
}
