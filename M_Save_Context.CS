/* Model Editor / M_Save_Context

   Created : 2011-04-21
   Last Modified : 2011-04-21
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class M_Save_Context : MenuItem
  { public static M_Save_Context This ;

    public M_Save_Context ()
    { This = this ;
      Text = "Save" ;

      Click += new EventHandler (OnClick) ;
    }

    void OnClick (object Obj, EventArgs EA)
    { IO_Save.Save () ;
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
