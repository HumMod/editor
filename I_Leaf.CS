/* Model Controller / I_Leaf

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
{ public class I_Leaf
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Leaf" ;
      Insert.Label = "<leaf>...</leaf>" ;

      Insert.Content += "        <leaf>" + nl ;
      Insert.Content += "          <name>  </name>" + nl ;
      Insert.Content += "          <label>  </label>" + nl ;
      Insert.Content += "          <parent>  </parent>" + nl ;
      Insert.Content += "        </leaf>" + nl ;

      Insert.WideContent += "        <leaf>" + nl ;
      Insert.WideContent += "          <name>  </name><label>  </label><parent>  </parent>" + nl ;
      Insert.WideContent += "        </leaf>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
