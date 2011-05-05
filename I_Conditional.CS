/* Model Controller / I_Conditional

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
{ public class I_Conditional
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Conditional" ;
      Insert.Label = "<conditional>...</conditional>" ;
      Insert.Content += "        <conditional>" + nl ;
      Insert.Content += "          <name>  </name>" + nl ;
      Insert.Content += "          <test>  </test>" + nl ;
      Insert.Content += "          <true>  </true>" + nl ;
      Insert.Content += "          <false>  </false>" + nl ;
      Insert.Content += "        </conditional>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
