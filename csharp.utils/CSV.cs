using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.utils
{
    public class CSV
    {
        public static String[] ReadCSV(string filename, char separator = ',')
        {
            return File.ReadAllText(filename).Split(separator);
        }
    }
}
