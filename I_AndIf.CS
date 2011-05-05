/* Model Controller / I_AndIf

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
{ public class I_AndIf
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "AndIf" ;
      Insert.Label = "<andif>...</andif>" ;
      Insert.Content += "        <andif>" + nl ;
      Insert.Content += "          <test>  </test>" + nl ;
      Insert.Content += "          <true>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "          </true>" + nl ;
      Insert.Content += "          <false>" + nl ;
      Insert.Content += nl ;
      Insert.Content += "          </false>" + nl ;
      Insert.Content += "        </andif>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
