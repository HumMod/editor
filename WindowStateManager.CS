/* Model Editor / WindowStateManager

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center

   The 2 states of interest are

       FormWindowState.Normal
       FormWindowState.Maximized                   */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class WindowStateManager
  { public static String WindowState = "WindowState" ;
    public static String HasWindowStateData = "HasWindowStateData" ;

    public static int DefaultValue = (int) FormWindowState.Normal ;

    public static int GetState ()
    { if (RegistryManager.HasKey (HasWindowStateData))
      { return (int) RegistryManager.GetValue (WindowState) ;
      }
      else
      { return DefaultValue ;
      }
    }

    public static void SetState (int Value)
    { RegistryManager.SetValue (WindowState, Value) ;
      RegistryManager.SetValue (HasWindowStateData, true) ;
    }
  }
}

/* End */
