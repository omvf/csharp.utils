using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.utils
{
    public class ReadFile
    {
        public static string ReadFile(string filename)
        {
            return File.ReadAllText(filename);
        }
    }
}
