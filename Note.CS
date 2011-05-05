/* Model Editor / Note

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Note : Label
  { public Note (Form ParentArg, int LeftArg, int TopArg, String TextArg)
    { Parent = ParentArg ;
      Text = TextArg ;
      AutoSize = true ;
      Location = new Point (LeftArg, TopArg) ;
    }

    public Note (Panel ParentArg, int LeftArg, int TopArg, String TextArg)
    { Parent = ParentArg ;
      Text = TextArg ;
      AutoSize = true ;
      Location = new Point (LeftArg, TopArg) ;
    }
  }
}

/* End */
