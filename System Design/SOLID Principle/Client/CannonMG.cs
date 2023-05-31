using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.Client
{
    internal class CannonMG : IPrintTask
    {

        //   FaxContent, PhotoCopyContent - we have to forcefully implement these two methods
        //   Interface Segretion Principle states that "No method should be forcedfully used"

        //public bool FaxContent(string content)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PhotoCopyContent(string content)
        //{
        //    throw new NotImplementedException();
        //}



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
