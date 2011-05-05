/* Model Editor / PanelLeft

   Created : 2011-04-04
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class PanelLeft : Panel
  { public static PanelLeft This ;

    public PanelLeft (Form ParentArg)
    { Parent = ParentArg ;
      This = this ;

      Size = new Size (FileRegistry.GetLeftPanelWidth (), 0) ;
      Dock = DockStyle.Left ;

      new FileTree (this) ;
    }

    public static void Closing ()
    { int Width = This.Width ;
      FileRegistry.SetLeftPanelWidth (Width) ;
    }
  }
}

/* End */
