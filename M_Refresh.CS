/* Model Editor / M_Refresh

   Created : 2011-05-02
   Last Modified : 2011-05-02
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class M_Refresh : MenuItem
  { public static M_Refresh This ;

    public M_Refresh ()
    { This = this ;

      Text = "Refresh" ;
      Click += new EventHandler (OnClick) ;
    }

    void OnClick (object Obj, EventArgs EA)
    { FileTree.This.RefreshTree () ;
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
