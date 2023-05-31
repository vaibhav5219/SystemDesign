using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    internal class Interface_Segretion_Principle
    {

        // No client should be forced to depend on methods it doen't use
        // OR - "No method should be forcedfully used"
    }
    //public interface IPrintTask
    //{
    //    bool PrintContent(string content);
    //    bool ScanContent(string content);
    //    bool FaxContent(string content);
    //    bool PhotoCopyContent(string content);
    //}

    // OR - "No method should be forcedfully used"  =>  So divide it into two different interfaces

    public interface IPrintTask
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        //bool FaxContent(string content);
        //bool PhotoCopyContent(string content);

    }
    public interface IFAXcontent
    {
        //bool PrintContent(string content);
        //bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotoCopyContent(string content);
    }
}
