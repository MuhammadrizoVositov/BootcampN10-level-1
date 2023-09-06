using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    public abstract class FileManagementServiceBase
    {
        public abstract Task<string> ReadAsync(string filePath);
        public abstract Task WriteAsync(string filePath,object Data)
    }
}
