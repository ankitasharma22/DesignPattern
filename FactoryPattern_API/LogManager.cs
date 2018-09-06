using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    public class LogManager
    {
        public static LogManager _instance;

        public static LogManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LogManager();

                return _instance;
            }
        }

        public LogManager()  
        {
            _fileStream = File.OpenWrite("C:/LogFile");
            _streamWriter = new StreamWriter(_fileStream);
        }

         FileStream _fileStream;
         StreamWriter _streamWriter;

        public void WriteLog(string message)
        {
            StringBuilder formattedMessage = new StringBuilder();
            formattedMessage.AppendLine("Message: " + message);

            _streamWriter.WriteLine(formattedMessage.ToString());
            _streamWriter.Flush();
        }

      
    }
}
