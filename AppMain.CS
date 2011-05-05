/* Model Editor / AppMain

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ; // Single Thread Application
using System.Windows.Forms ; // Run

namespace ModelEditor
{ class AppMain
  { public static string AppName = "Model Editor" ;

    [STAThread] static void Main ()
    { Application.Run (new MainWindow ()) ;
    }
  }
}

/* End */
