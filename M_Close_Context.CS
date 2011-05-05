/* Model Editor / M_Close_Context

   Created : 2011-04-21
   Last Modified : 2011-04-21
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class M_Close_Context : MenuItem
  { public static M_Close_Context This ;

    public M_Close_Context ()
    { This = this ;
      Text = "Close" ;

      Click += new EventHandler (OnClick) ;
    }

    void OnClick (object Obj, EventArgs EA)
    { IO_Close.Close () ;
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
