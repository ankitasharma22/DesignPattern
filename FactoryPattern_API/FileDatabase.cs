using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class FileDatabase : IDatabase
    {
        FileStream _fileStream;
        StreamWriter _streamWriter;
        public FileDatabase()
        {
            _fileStream = File.OpenWrite("C:/DatabaseFile");
            _streamWriter = new StreamWriter(_fileStream);
        }

 
        public void EnterBookingDetails(string name, int price, string tableName)
        {
            StringBuilder formattedMessage = new StringBuilder();
            formattedMessage.AppendLine("Name Of Product: " + name);
            formattedMessage.AppendLine("Proce Of Product: " + price);  
            _streamWriter.WriteLine(formattedMessage.ToString());
            _streamWriter.Flush();
        }
    }
}
