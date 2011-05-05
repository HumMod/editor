/* Model Editor / User32

   Created : 2011-05-03
   Last Modified : 2011-05-03
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Drawing.Printing ;
using System.Runtime.InteropServices ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class User32
  { [DllImport ("user32.dll")]
    public static extern IntPtr SetActiveWindow (IntPtr HWnd) ;

    [DllImport ("user32.dll")]
    public static extern IntPtr SetForegroundWindow (IntPtr HWnd) ;

    [DllImport ("user32.dll")]
    public static extern IntPtr FindWindow (String Class, String Caption) ;

    public static void MakeMainWindowActive ()
    { IntPtr HWnd = FindWindow (null, "Model Editor") ;
//MsgBox.Show(HWnd.ToString());
      SetForegroundWindow (HWnd) ;
      SetActiveWindow (HWnd) ;
    }
  }
}

/* End */
