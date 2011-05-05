/* Model Controller / I_VarDoc

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
{ public class I_VarDoc
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "VarDoc" ;
      Insert.Label = "<vardoc>...</vardoc>" ;
      Insert.Content += "    <vardoc>" + nl ;
      Insert.Content += "      <name>  </name>" + nl ;
      Insert.Content += "      <topic>  </topic>" + nl ;
      Insert.Content += "      <seealso>  </seealso>" + nl ;
      Insert.Content += "    </vardoc>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
