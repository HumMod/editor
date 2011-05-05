/* Model Controller / I_ShowValue

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
{ public class I_ShowValue
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "ShowValue" ;
      Insert.Label = "<showvalue>...</showvalue>" ;

      Insert.Content += "      <showvalue>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "        <format>" + nl ;
      Insert.Content += "          <decimal>  </decimal>" + nl ;
      Insert.Content += "        </format>" + nl ;
      Insert.Content += "        <label>  </label>" + nl ;
      Insert.Content += "      </showvalue>" + nl ;

      Insert.WideContent += "      <showvalue>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += "        <name>  </name>" + nl ;
      Insert.WideContent += "        <format><decimal>  </decimal></format>" + nl ;
      Insert.WideContent += "        <label>  </label>" + nl ;
      Insert.WideContent += "      </showvalue>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Push () ;

      Insert = new Insert_Data () ;

      Insert.Name = "ValueFormat" ;
      Insert.Label = "<format>...</format>" ;
      Insert.Content += "        <format>" + nl ;
      Insert.Content += "          <none/>" + nl ;
      Insert.Content += "          <integer/>" + nl ;
      Insert.Content += "          <decimal>  </decimal>" + nl ;
      Insert.Content += "          <list>  </list>" + nl ;
      Insert.Content += "          <timer/>" + nl ;
      Insert.Content += "          <timestamp/>" + nl ;
      Insert.Content += "          <boolean/>" + nl ;
      Insert.Content += "          <fieldwidth>  </fieldwidth>" + nl ;
      Insert.Content += "          <justify>  </justify>" + nl ;
      Insert.Content += "        </format>" + nl ;

      Insert_Manager.Add (Insert) ;

      Insert_Manager.Pop () ;
    } 
  }
}

/* End */
