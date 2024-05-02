using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Abstraction
{
    public interface IFileWriter
    {
        void WriteFile(string filePath, string content);
    }
}
