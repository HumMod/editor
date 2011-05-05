/* Model Controller / I_Parm

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
{ public class I_Parm
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Parm" ;
      Insert.Label = "<parm>...</parm>" ;

      Insert.Content += "      <parm>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "        <val>  </val>" + nl ;
      Insert.Content += "      </parm>" + nl ;

      Insert.WideContent += "      <parm>" + nl ;
      Insert.WideContent += "        <name>  </name><val>  </val>" + nl ;
      Insert.WideContent += "      </parm>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
