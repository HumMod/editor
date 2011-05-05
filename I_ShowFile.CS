/* Model Controller / I_ShowFile

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
{ public class I_ShowFile
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "ShowFile" ;
      Insert.Label = "<showfile>...</showfile>" ;

      Insert.Content += "      <showfile>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <high>  </high>" + nl ;
      Insert.Content += "        <wide>  </wide>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "      </showfile>" + nl ;

      Insert.WideContent += "      <showfile>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += "        <high>  </high><wide>  </wide>" + nl ;
      Insert.WideContent += "        <name>  </name>" + nl ;
      Insert.WideContent += nl ;
      Insert.WideContent += "      </showfile>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
