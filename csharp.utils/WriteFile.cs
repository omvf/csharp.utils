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
        public static void ReadFile(string content)
        {
            File.WriteAllLines(content);
        }
    }
}
