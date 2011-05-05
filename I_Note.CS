/* Model Controller / I_Note

   Created : 2011-04-18
   Last Modified : 2011-04-18
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class I_Note
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Note" ;
      Insert.Label = "<note>...</note>" ;

      Insert.Content += "      <note>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <high>  </high>" + nl ;
      Insert.Content += "        <wide>  </wide>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "        <text>  </text>" + nl ;
      Insert.Content += "        <text>  </text>" + nl ;
      Insert.Content += "      </note>" + nl ;

      Insert.WideContent += "      <note>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += "        <high>  </high><wide>  </wide>" + nl ;
      Insert.WideContent += "        <name>  </name>" + nl ;
      Insert.WideContent += "        <text>  </text>" + nl ;
      Insert.WideContent += "        <text>  </text>" + nl ;
      Insert.WideContent += "      </note>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
