/* Model Controller / I_ShowClock

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
{ public class I_ShowClock
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "ShowClock" ;
      Insert.Label = "<showclock>...</showclock>" ;

      Insert.Content += "      <showclock>" + nl ;
      Insert.Content += "        <row>  </row>" + nl ;
      Insert.Content += "        <col>  </col>" + nl ;
      Insert.Content += "        <name>  </name>" + nl ;
      Insert.Content += "        <timebase>  </timebase>" + nl ;
      Insert.Content += "        <ampm/>" + nl ;
      Insert.Content += "        <secs/>" + nl ;
      Insert.Content += "        <days/>" + nl ;
      Insert.Content += "      </showclock>" + nl ;

      Insert.WideContent += "      <showclock>" + nl ;
      Insert.WideContent += "        <row>  </row><col>  </col>" + nl ;
      Insert.WideContent += "        <name>  </name>" + nl ;
      Insert.WideContent += "        <timebase>  </timebase>" + nl ;
      Insert.WideContent += "        <ampm/><secs/><days/>" + nl ;
      Insert.WideContent += "      </showclock>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
