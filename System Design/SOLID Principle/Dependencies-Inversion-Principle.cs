using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    class Dependencies_Inversion_Principle
    {
        // High level module should not depend on Low level module, but both should dependent on abstractions, interfaces.
        // Abstractions should not depend on Details but details should depend on abstractions.
        // Intension of usages -:
        //  
        //      Presentation   ->     Business      ->     DataAccess 
        //        Layer                Layer                  Layer
        //
        //      Button click  ->      Employee Save    ->     Save Data In DB
    }
}
