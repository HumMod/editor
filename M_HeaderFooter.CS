/* Model Editor / M_HeaderFooter

   Created : 2011-04-25
   Last Modified : 2011-04-25
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class M_HeaderFooter : MenuItem
  { public static M_HeaderFooter This ;

    public M_HeaderFooter ()
    { This = this ;
      Text = "Header / Footer" ;

      Click += new EventHandler (OnClick) ;
    }

    void OnClick (object Obj, EventArgs EA)
    { Print_Manager.HeaderFooter () ;
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
