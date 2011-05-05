/* Model Controller / IO_Close

   Created : 2011-04-21
   Last Modified : 2011-04-21
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class IO_Close
  { public static void Close ()
    { TabData Data = TabManager.GetSelectedTabData () ;

      DialogResult OK = IO_Save.SaveAskIfChanged (Data) ;

      if (OK == DialogResult.Cancel)
      { return ;
      }

      TabManager.Remove () ;

      if (! TabManager.HasTabs ())
      { State.NoFilesOpen () ;
      }
    }

  }
}

/* End */
