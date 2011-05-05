/* Model Editor / M_Main

   Created : 2011-04-08
   Last Modified : 2011-04-20
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class M_Main : MainMenu
  { public static M_Main This ;

    public M_Main ()
    { This = this ;

      MenuItems.Add (new M_File ()) ;
      MenuItems.Add (new M_Edit ()) ;
      MenuItems.Add (new M_Search ()) ;
      MenuItems.Add (new M_Insert ()) ;
      MenuItems.Add (new M_Run ()) ;
      MenuItems.Add (new M_Options ()) ;
      MenuItems.Add (new M_Help ()) ;

    }
  }
}

/* End */
