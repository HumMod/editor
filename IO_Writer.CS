/* Model Editor / IO_Writer

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.IO ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class IO_Writer
  { public static void Write (String Filename, String Content)
    { try
      { StatusBarManager.ShowText ("Writing " + Filename + " ... ") ;

        StreamWriter SW = new StreamWriter (Filename) ;
        SW.Write (Content) ;
        SW.Close () ;

        StatusBarManager.AddText ("Done") ;
      }

      catch
      { StatusBarManager.AddText ("Failed") ;
      }
    }

  }
}

/* End */
