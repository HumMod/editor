/* Model Editor / M_Root

   Created : 2011-04-21
   Last Modified : 2011-04-21
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class M_Root : MenuItem
  { public static M_Root This ;
    private String Filename ;

    public M_Root (String FilenameArg)
    { This = this ;

      Filename = FilenameArg ;

      Text = "Make This File The Model Root" ;
      Click += new EventHandler (OnClick) ;
    }

    void OnClick (object Obj, EventArgs EA)
    { RunRegistry.SetModel (Filename) ;
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
