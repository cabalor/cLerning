using System;
using System.IO;
namespace FirstApp
{
    public class FileLogger : ILoger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }

        

        public void LogError(string msg)
        {
            Log(msg, "Err");
        }

        public void logInfo(string msg)
        {
            Log(msg, "Err");
        }

        private void Log(string msg, string msgType)
        {
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(msgType + DateTime.Now + " " + msg);
            }
        }


    }
}

