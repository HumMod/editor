/* Model Editor / FileContextMenu

   Created : 2011-04-09
   Last Modified : 2011-05-02
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class FileContextMenu : ContextMenu
  { public static FileContextMenu This ;

    public FileContextMenu (String Filename)
    { This = this ;

      MenuItems.Add (new M_Refresh ()) ;
      MenuItems.Add (new M_Root (Filename)) ;

    }
  }
}

/* End */
