/* Model Controller / Insert_Data

   Created : 2011-04-11
   Last Modified : 2011-04-22
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class Insert_Data
  { protected String nl ;

    public String Name ;
    public String Label ;
    public String Content ;
    public String WideContent ;

    public Insert_Data ()
    { nl = Environment.NewLine ;

      Content = "" ;
      WideContent = "" ;
    }
  }
}

/* End */
