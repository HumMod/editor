/* Model Editor / M_Print

   Created : 2011-04-08
   Last Modified : 2011-04-08
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class M_Print : MenuItem
  { public static M_Print This ;

    public M_Print ()
    { This = this ;
      Text = "Print" ;

      Click += new EventHandler (OnClick) ;
    }

    void OnClick (object Obj, EventArgs EA)
    { Print_Manager.Print () ;
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
