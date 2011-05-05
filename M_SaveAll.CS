/* Model Editor / M_SaveAll

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class M_SaveAll : MenuItem
  { public static M_SaveAll This ;

    public M_SaveAll ()
    { This = this ;
      Text = "Save All" ;

      Click += new EventHandler (OnClick) ;
    }

    void OnClick (object Obj, EventArgs EA)
    { IO_SaveAll.SaveAll () ;
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
