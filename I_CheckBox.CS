/* Model Controller / I_CheckBox

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
{ public class I_CheckBox
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "CheckBox" ;
      Insert.Label = "<checkbox>...</checkbox>" ;

      Insert.Content += "      <checkbox>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "        <label>  </label>" + nl ;
      Insert.Content += "      </checkbox>" + nl ;

      Insert.WideContent += "      <checkbox>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += "        <name>  </name><label>  </label>" + nl ;
      Insert.WideContent += "      </checkbox>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
