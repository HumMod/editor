/* Model Controller / I_InfoButton

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
{ public class I_InfoButton
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "InfoButton" ;
      Insert.Label = "<infobutton>...</infobutton>" ;
      Insert.Content += "      <infobutton>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <label>  </label>" + nl ;
      Insert.Content += "        <layout>  </layout>" + nl ;
      Insert.Content += "        <line>  </line>" + nl ;
      Insert.Content += "        <line>  </line>" + nl ;
      Insert.Content += "      </infobutton>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
