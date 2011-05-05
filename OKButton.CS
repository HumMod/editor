/* Model Editor / OKButton

   Created : 2011-04-04
   Last Modified : 2011-04-04
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class OKButton : Panel
  { public OKButton (Form ParentArg)
    { Parent = ParentArg ;

      Size = new Size (0, 40) ;
      Dock = DockStyle.Bottom ;

      Button OK = new Button () ;

      OK.Parent = this ;
      OK.Text = "OK" ;
      OK.Size = new Size (70, 20) ;
      OK.Location = new Point (50, 10) ;
      OK.DialogResult = DialogResult.OK ;

    }
  }
}

/* End */
