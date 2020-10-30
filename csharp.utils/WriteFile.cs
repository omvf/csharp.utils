using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.utils
{
    public class WriteFile
    {
        public static void WriteFile(string content)
        {
            File.WriteAllLines(content);
        }
    }
}
