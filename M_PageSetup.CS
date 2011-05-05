/* Model Editor / M_PageSetup

   Created : 2011-04-08
   Last Modified : 2011-04-19
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class M_PageSetup : MenuItem
  { public static M_PageSetup This ;

    public M_PageSetup ()
    { This = this ;
      Text = "Page Setup" ;

      Click += new EventHandler (OnClick) ;
    }

    void OnClick (object Obj, EventArgs EA)
    { Print_Manager.PageSetup () ;
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
