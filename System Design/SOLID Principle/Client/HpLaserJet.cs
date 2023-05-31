using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.Client
{
    internal class HpLaserJet : IPrintTask, IFAXcontent
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine(content +" Fax Done ");
            return true;
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine(content + " PhotoCopy Done");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine(content + " Print Content");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine(content + " Scan Content");
            return true;
        }
    }
}
