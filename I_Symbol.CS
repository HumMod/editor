/* Model Controller / I_Symbol

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
{ public class I_Symbol
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Symbol" ;
      Insert.Label = "<symbol>...</symbol>" ;

      Insert.Content += "        <symbol>" + nl ;
      Insert.Content += "          <name>  </name>" + nl ;
      Insert.Content += "          <style>  </style>" + nl ;
      Insert.Content += "          <color>  </color>" + nl ;
      Insert.Content += "          <size>  </size>" + nl ;
      Insert.Content += "          <linewidth>  </linewidth>" + nl ;
      Insert.Content += "        </symbol>" + nl ;

      Insert.WideContent += "        <symbol>" + nl ;
      Insert.WideContent += "          <name>  </name><style>  </style><color>  </color>" + nl ;
      Insert.WideContent += "          <size>  </size><linewidth>  </linewidth>" + nl ;
      Insert.WideContent += "        </symbol>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
