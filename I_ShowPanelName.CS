/* Model Controller / I_ShowPanelName

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
{ public class I_ShowPanelName
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "ShowPanelName" ;
      Insert.Label = "<showpanelname>...</showpanelname>" ;

      Insert.Content += "      <showpanelname>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "      </showpanelname>" + nl ;

      Insert.WideContent += "      <showpanelname>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += "      </showpanelname>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
