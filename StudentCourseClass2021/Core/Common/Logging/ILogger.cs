using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Common.Logging
{
    public interface ILogger
    {
        public Task Log(string text, string path);
    }
}
