using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsPreview.Media.Ocr;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            OcrEngine e = new OcrEngine(OcrLanguage.English);
        }
    }
}
