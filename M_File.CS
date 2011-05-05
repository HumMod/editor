/* Model Editor / M_File

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class M_File : MenuItem
  { public static M_File This ;

    public M_File ()
    { This = this ;

      Text = "File" ;

      MenuItems.Add (new M_New ()) ;
      MenuItems.Add (new M_Open ()) ;
      MenuItems.Add ("-") ;
      MenuItems.Add (new M_Save ()) ;
      MenuItems.Add (new M_SaveAs ()) ;
      MenuItems.Add (new M_SaveAll ()) ;
      MenuItems.Add ("-") ;
      MenuItems.Add (new M_Close ()) ;
      MenuItems.Add (new M_CloseAll ()) ;
      MenuItems.Add ("-") ;
      MenuItems.Add (new M_PageSetup ()) ;
      MenuItems.Add (new M_HeaderFooter ()) ;
      MenuItems.Add (new M_PrintPreview ()) ;
      MenuItems.Add (new M_Print ()) ;
      MenuItems.Add ("-") ;
      MenuItems.Add (new M_Exit ()) ;
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
