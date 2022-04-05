using System;
using System.Collections.Generic;
using System.Text;

namespace BigTask
{
    class CustomException:Exception
    {
            public CustomException(string message) : base(message)
            {

            }
        
    }
}
