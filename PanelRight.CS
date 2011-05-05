/* Model Editor / PanelLeft

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class PanelRight : Panel
  { public static PanelRight This ;

    public PanelRight (Form ParentArg)
    { Parent = ParentArg ;
      This = this ;

      Dock = DockStyle.Fill ;

      TabManager.Attach (this) ;
    }
  }
}

/* End */
