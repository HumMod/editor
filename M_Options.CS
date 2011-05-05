/* Model Solver / M_Options

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class M_Options : MenuItem
  { public static M_Options This ;

    public M_Options ()
    { This = this ;
      Text = "Options" ;

      Click += new EventHandler (OnClick) ;
    }

    void OnClick (object Obj, EventArgs EA)
    { Options_Dialog Dlg = new Options_Dialog () ;
      Dlg.ShowDialog () ;
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
