using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    class EmptyContainerException : Exception
    {
        private string message;

        public EmptyContainerException(string msgText)
            : base(msgText)
        {
            message = msgText;
        }

    }
}
