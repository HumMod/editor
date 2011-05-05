/* Model Editor / Window_Splitter

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Window_Splitter : Splitter
  { public Window_Splitter (Form ParentArg)
    { Parent = ParentArg ;
      Dock = DockStyle.Left ;
    } 
  }
}

/* End */
