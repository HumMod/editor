/* Model Controller / I_EditBox

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
{ public class I_EditBox
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "EditBox" ;
      Insert.Label = "<editbox>...</editbox>" ;

      Insert.Content += "      <editbox>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "        <label>  </label>" + nl ;
      Insert.Content += "        <min>  </min>" + nl ;
      Insert.Content += "        <max>  </max>" + nl ;
      Insert.Content += "      </editbox>" + nl ;

      Insert.WideContent += "      <editbox>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += "        <name>  </name><label>  </label>" + nl ;
      Insert.WideContent += "        <min>  </min><max>  </max>" + nl ;
      Insert.WideContent += "      </editbox>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
