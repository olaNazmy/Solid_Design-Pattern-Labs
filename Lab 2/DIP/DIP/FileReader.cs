using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP.Abstraction;

namespace DIP
{
    //first implement IFileReader
    public class FileReader : IFileReader
    {
        //implement method needed
        public string ReadFile(string filePath)
        {
            return "file content";
        }
    }
    // second implement IFileWriter
    public class FileWriter : IFileWriter
    {
        public void WriteFile(string filePath, string content)
        {
          //code here
        }
    }

}
