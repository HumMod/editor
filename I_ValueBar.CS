/* Model Controller / I_ValueBar

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
{ public class I_ValueBar
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "ValueBar" ;
      Insert.Label = "<valuebar>...</valuebar>" ;

      Insert.Content += "      <valuebar>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <wide>  </wide>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "        <label>  </label>" + nl ;
      Insert.Content += "        <margins>  </margins>" + nl ;
      Insert.Content += "        <symbolname>  </symbolname>" + nl ;
      Insert.Content += "        <ghostname>  </ghostname>" + nl ;
      Insert.Content += "        <scale>" + nl ;
      Insert.Content += "          <min>  </min>" + nl ;
      Insert.Content += "          <max>  </max>" + nl ;
      Insert.Content += "          <inc>  </inc>" + nl ;
      Insert.Content += "        </scale>" + nl ;
      Insert.Content += "      </valuebar>" + nl ;

      Insert.WideContent += "      <valuebar>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col><wide>  </wide>" + nl ;
      Insert.WideContent += "        <name>  </name>" + nl ;
      Insert.WideContent += "        <label>  </label>" + nl ;
      Insert.WideContent += "        <margins>  </margins>" + nl ;
      Insert.WideContent += "        <symbolname>  </symbolname>" + nl ;
      Insert.WideContent += "        <ghostname>  </ghostname>" + nl ;
      Insert.WideContent += "        <scale><min>  </min><max>  </max><inc>  </inc></scale>" + nl ;
      Insert.WideContent += "      </valuebar>" + nl ;

      Insert_Manager.Add (Insert) ;

    } 
  }
}

/* End */
