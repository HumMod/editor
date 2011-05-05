/* Model Controller / I_Label

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
{ public class I_Label
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Label" ;
      Insert.Label = "<label>...</label>" ;

      Insert.Content += "      <label>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <text>  </text>" + nl ;
      Insert.Content += "        <fieldwidth>  </fieldwidth>" + nl ;
      Insert.Content += "        <justify>  </justify>" + nl ;
      Insert.Content += "        <color>  </color>" + nl ;
      Insert.Content += "      </label>" + nl ;

      Insert.WideContent += "      <label>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += "        <text>  </text>" + nl ;
      Insert.WideContent += "        <fieldwidth>  </fieldwidth><justify>  </justify>" + nl ;
      Insert.WideContent += "        <color>  </color>" + nl ;
      Insert.WideContent += "      </label>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
