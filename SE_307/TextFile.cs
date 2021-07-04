using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_307
{
    class TextFile
    {
        public void TextReader()
        {
            Console.WriteLine();
            string file_path = @"C:\Users\berke\Desktop\Se 307 Project\ATSList.txt";
            string text = System.IO.File.ReadAllText(file_path);
            Console.WriteLine(text);
            Console.WriteLine();
        }

    }
}
