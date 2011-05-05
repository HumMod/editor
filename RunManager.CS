/* Model Editor / RunManager

   Created : 2011-04-04
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ModelEditor
{ public class RunManager
  { public static void Run()
    { if (GeneralRegistry.GetSaveFiles ())
      { IO_SaveAll.SaveAll () ;
      }

      if (RunRegistry.GetIsModular ())
      { RunManager_Modular.Run () ;
      }
      else
      { RunManager_Combined.Run () ;
      }
    }
  }
}

/* End */
