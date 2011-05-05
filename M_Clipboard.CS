/* Model Editor / M_Clipboard

   Created : 2011-04-11
   Last Modified : 2011-04-11
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class M_Clipboard : MenuItem
  { public static M_Clipboard This ;

    public M_Clipboard ()
    { This = this ;
      Text = "Clipboard" ;

      Click += new EventHandler (OnClick) ;
    }

    void OnClick (object Obj, EventArgs EA)
    { Clipboard_Dialog.Make () ;
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
