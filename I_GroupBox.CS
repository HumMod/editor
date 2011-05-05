/* Model Controller / I_GroupBox

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
{ public class I_GroupBox
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "GroupBox" ;
      Insert.Label = "<groupbox>...</groupbox>" ;

      Insert.Content += "      <groupbox>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <high>  </high>" + nl ;
      Insert.Content += "        <wide>  </wide>" + nl ;
      Insert.Content += "        <title>  </title>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "      </groupbox>" + nl ;

      Insert.WideContent += "      <groupbox>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += "        <high>  </high><wide>  </wide>" + nl ;
      Insert.WideContent += "        <title>  </title>" + nl ;
      Insert.WideContent += nl ;
      Insert.WideContent += "      </groupbox>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
