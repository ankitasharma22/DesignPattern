using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class FileDatabase
    {
        FileStream _fileStream;
        StreamWriter _streamWriter;
        public FileDatabase()
        {
            _fileStream = File.OpenWrite("C:/DatabaseFile");
            _streamWriter = new StreamWriter(_fileStream);
        }
       public void EnterBookingDetails(string BookOrSave)
        {
            StringBuilder formattedMessage = new StringBuilder();
            formattedMessage.AppendLine("Message: " + BookOrSave);

            _streamWriter.WriteLine(formattedMessage.ToString());
            _streamWriter.Flush();
        }
    }
}
