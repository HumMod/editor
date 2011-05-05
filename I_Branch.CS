/* Model Controller / I_Branch

   Created : 2011-04-13
   Last Modified : 2011-04-13
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class I_Branch
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Branch" ;
      Insert.Label = "<branch>...</branch>" ;

      Insert.Content += "        <branch>" + nl ;
      Insert.Content += "          <name>  </name>" + nl ;
      Insert.Content += "          <label>  </label>" + nl ;
      Insert.Content += "          <parent>  </parent>" + nl ;
      Insert.Content += "        </branch>" + nl ;

      Insert.WideContent += "        <branch>" + nl ;
      Insert.WideContent += "          <name>  </name><label>  </label><parent>  </parent>" + nl ;
      Insert.WideContent += "        </branch>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
