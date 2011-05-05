/* Model Editor / M_Edit

   Created : 2011-04-04
   Last Modified : 2011-04-11
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class M_Edit : MenuItem
  { public static M_Edit This ;

    public M_Edit ()
    { This = this ;
      Text = "Edit" ;

      MenuItems.Add (new M_Cut ()) ;
      MenuItems.Add (new M_Copy ()) ;
      MenuItems.Add (new M_Paste()) ;
      MenuItems.Add ("-") ;
      MenuItems.Add (new M_SelectAll ()) ;
      MenuItems.Add ("-") ;
      MenuItems.Add (new M_Clipboard ()) ;
    }

    public static void TurnOn ()
    { This.Enabled = true ;
    }

    public static void TurnOff ()
    { This.Enabled = false ;
    }
  }
}

/* End */
