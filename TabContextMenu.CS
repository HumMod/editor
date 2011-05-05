/* Model Editor / TabContextMenu

   Created : 2011-04-09
   Last Modified : 2011-04-09
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class TabContextMenu : ContextMenu
  { public static TabContextMenu This ;

    public TabContextMenu (String Filename)
    { This = this ;

      MenuItems.Add (new M_Root_Context (Filename)) ;
      MenuItems.Add (new M_Save_Context ()) ;
      MenuItems.Add (new M_Close_Context ()) ;

    }
  }
}

/* End */
