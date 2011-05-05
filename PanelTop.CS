/* Model Editor / PanelTop

   Created : 2011-04-05
   Last Modified : 2011-04-05
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class PanelTop : Panel
  { public static PanelTop This ;

    public PanelTop (Form ParentArg)
    { This = this ;

      Parent = ParentArg ;
      Size = new Size (0, 30) ;
      Dock = DockStyle.Top ;

      ToolBar_Manager.Install (this) ;
    }

  }
}

/* End */
