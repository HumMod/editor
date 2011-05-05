/* Model Controller / I_ActionButton

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
{ public class I_ActionButton
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "ActionButton" ;
      Insert.Label = "<actionbutton>...</actionbutton>" ;

      Insert.Content += "      <actionbutton>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <blockname>  </blockname>" + nl ;
      Insert.Content += "        <label>  </label>" + nl ;
      Insert.Content += "        <layout>  </layout>" + nl ;
      Insert.Content += "      </actionbutton>" + nl ;

      Insert.WideContent += "      <actionbutton>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += "        <blockname>  </blockname>" + nl ;
      Insert.WideContent += "        <label>  </label><layout>  </layout>" + nl ;
      Insert.WideContent += "      </actionbutton>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
