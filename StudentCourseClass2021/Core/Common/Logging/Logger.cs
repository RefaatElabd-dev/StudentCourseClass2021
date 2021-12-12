using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Core.Common.Logging
{
    public class Logger : ILogger
    {
        private const string defaultPath = "F:\\StudentCourseClass2021\\StudentCourseClass2021\\Logs\\log.txt";

        public async Task Log(string text, string path = defaultPath)
        {
            using (StreamWriter File = new StreamWriter(path, append: true))
            {
                await File.WriteLineAsync(text);
            };
        }
    }
}
